﻿using System.Linq;
using Discord;
using Discord.Rest;
using GrillBot.App.Handlers.GuildMemberUpdated;
using GrillBot.App.Managers;
using GrillBot.Database.Enums;
using GrillBot.Tests.Infrastructure.Common;
using GrillBot.Tests.Infrastructure.Discord;

namespace GrillBot.Tests.App.Handlers.GuildMemberUpdated;

[TestClass]
public class AuditUserRoleUpdatedInstanceTests : TestBase<AuditUserRoleUpdatedHandler>
{
    private IGuildUser User { get; set; } = null!;

    protected override void PreInit()
    {
        var guild = new GuildBuilder(Consts.GuildId, Consts.GuildName).Build();
        User = new GuildUserBuilder(Consts.UserId, Consts.Username, Consts.Discriminator).SetRoles(Enumerable.Empty<ulong>())
            .SetGuild(guild).Build();
    }

    protected override AuditUserRoleUpdatedHandler CreateInstance()
    {
        var auditLogManager = new AuditLogManager();
        var auditLogWriter = new AuditLogWriteManager(DatabaseBuilder);
        return new AuditUserRoleUpdatedHandler(auditLogManager, TestServices.CounterManager.Value, DatabaseBuilder, auditLogWriter);
    }

    private async Task InitDataAsync()
    {
        await Repository.AddAsync(Database.Entity.User.FromDiscord(User));
        await Repository.AddAsync(Database.Entity.Guild.FromDiscord(User.Guild));
        await Repository.AddAsync(Database.Entity.GuildUser.FromDiscord(User.Guild, User));

        await Repository.AddAsync(new Database.Entity.AuditLogItem
        {
            Data = "{}",
            GuildId = Consts.GuildId.ToString(),
            CreatedAt = DateTime.Now,
            Type = AuditLogItemType.MemberRoleUpdated,
            ProcessedUserId = Consts.UserId.ToString(),
            DiscordAuditLogItemId = (Consts.AuditLogEntryId + 1).ToString()
        });
        await Repository.CommitAsync();
    }

    [TestMethod]
    public async Task ProcessAsync_CannotProcess()
        => await Instance.ProcessAsync(User, User);

    [TestMethod]
    public async Task ProcessAsync_WithoutAuditLog()
    {
        var guild = new GuildBuilder(Consts.GuildId, Consts.GuildName).SetGetAuditLogsAction(new List<IAuditLogEntry>()).Build();
        var anotherUser = new GuildUserBuilder(Consts.UserId, Consts.Username, Consts.Discriminator).SetRoles(new[] { Consts.RoleId }).SetGuild(guild).Build();

        await Instance.ProcessAsync(User, anotherUser);
    }

    [TestMethod]
    public async Task ProcessAsync_Ok()
    {
        await InitDataAsync();
        var roleEditInfo = ReflectionHelper.CreateWithInternalConstructor<MemberRoleEditInfo>(Consts.RoleName, Consts.RoleId, true);
        var data = ReflectionHelper.CreateWithInternalConstructor<MemberRoleAuditLogData>(new List<MemberRoleEditInfo> { roleEditInfo }, User);
        var logEntry = new AuditLogEntryBuilder(Consts.AuditLogEntryId).SetData(data).SetUser(User).SetActionType(ActionType.MemberRoleUpdated).Build();
        var role = new RoleBuilder(Consts.RoleId, Consts.RoleName).Build();
        var guild = new GuildBuilder(Consts.GuildId, Consts.GuildName).SetRoles(new[] { role }).SetGetAuditLogsAction(new List<IAuditLogEntry> { logEntry }).Build();
        var userAfter = new GuildUserBuilder(User).SetRoles(new[] { role.Id }).SetGuild(guild).Build();

        await Instance.ProcessAsync(User, userAfter);
    }
}

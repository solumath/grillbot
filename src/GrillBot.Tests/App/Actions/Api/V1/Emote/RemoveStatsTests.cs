﻿using GrillBot.App.Actions.Api.V1.Emote;
using GrillBot.App.Managers;
using GrillBot.Database.Entity;
using GrillBot.Tests.Infrastructure.Common;
using GrillBot.Tests.Infrastructure.Discord;

namespace GrillBot.Tests.App.Actions.Api.V1.Emote;

[TestClass]
public class RemoveStatsTests : ApiActionTest<RemoveStats>
{
    protected override RemoveStats CreateInstance()
    {
        var auditLogWriter = new AuditLogWriteManager(DatabaseBuilder);
        return new RemoveStats(ApiRequestContext, DatabaseBuilder, auditLogWriter);
    }

    [TestMethod]
    public async Task ProcessAsync_NoEmotes()
    {
        var result = await Instance.ProcessAsync(Consts.PepeJamEmote);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public async Task ProcessAsync_WithEmotes()
    {
        var guild = new GuildBuilder(Consts.GuildId, Consts.GuildName).Build();
        var guildUser = new GuildUserBuilder(Consts.UserId, Consts.Username, Consts.Discriminator).SetGuild(guild).Build();

        await Repository.AddAsync(new EmoteStatisticItem
        {
            EmoteId = Consts.PepeJamEmote,
            FirstOccurence = DateTime.MinValue,
            Guild = Database.Entity.Guild.FromDiscord(guild),
            GuildId = guild.Id.ToString(),
            LastOccurence = DateTime.MaxValue,
            UseCount = 1,
            User = GuildUser.FromDiscord(guild, guildUser),
            UserId = Consts.UserId.ToString()
        });
        await Repository.CommitAsync();

        var result = await Instance.ProcessAsync(Consts.PepeJamEmote);
        Assert.AreEqual(1, result);
    }
}

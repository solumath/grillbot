﻿using GrillBot.App.Services.Logging;
using GrillBot.App.Services.Permissions;
using GrillBot.App.Services.Unverify;
using GrillBot.Common.Managers.Counters;
using GrillBot.Tests.Infrastructure;
using GrillBot.Tests.Infrastructure.Discord;

namespace GrillBot.Tests.App.Services.Unverify;

[TestClass]
public class UnverifyServiceTests : ServiceTest<UnverifyService>
{
    protected override UnverifyService CreateService()
    {
        var discordClient = DiscordHelper.CreateClient();
        var configuration = ConfigurationHelper.CreateConfiguration();
        var environment = EnvironmentHelper.CreateEnv("Production");
        var checker = new UnverifyChecker(DatabaseBuilder, configuration, environment);
        var profileGenerator = new UnverifyProfileGenerator(DatabaseBuilder);
        var logger = new UnverifyLogger(discordClient, DatabaseBuilder);
        var commandsService = DiscordHelper.CreateCommandsService();
        var loggerFactory = LoggingHelper.CreateLoggerFactory();
        var interactionService = DiscordHelper.CreateInteractionService(discordClient);
        var loggingService = new LoggingService(discordClient, commandsService, loggerFactory, configuration, DatabaseBuilder, interactionService);
        var counter = new CounterManager();
        var logging = LoggingHelper.CreateLogger<PermissionsCleaner>();
        var permissionsCleaner = new PermissionsCleaner(counter, logging);

        return new UnverifyService(discordClient, checker, profileGenerator, logger, DatabaseBuilder, loggingService, permissionsCleaner);
    }

    [TestMethod]
    public async Task GetUnverifyCountsOfGuildAsync()
    {
        var guild = new GuildBuilder().SetIdentity(Consts.GuildId, Consts.GuildName).Build();
        var result = await Service.GetUnverifyCountsOfGuildAsync(guild);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public async Task GetUserIdsWithUnverifyAsync()
    {
        var guild = new GuildBuilder().SetIdentity(Consts.GuildId, Consts.GuildName).Build();
        var result = await Service.GetUserIdsWithUnverifyAsync(guild);
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public async Task GetPendingUnverifiesForRemoveAsync()
    {
        var result = await Service.GetPendingUnverifiesForRemoveAsync();
        Assert.AreEqual(0, result.Count);
    }
}

﻿using GrillBot.App.Actions.Api.V2;
using GrillBot.Common.Services.RubbergodService.Models.Karma;
using GrillBot.Tests.Infrastructure.Common;

namespace GrillBot.Tests.App.Actions.Api.V2;

[TestClass]
public class StoreKarmaTests : ApiActionTest<StoreKarma>
{
    protected override StoreKarma CreateInstance()
    {
        return new StoreKarma(ApiRequestContext, TestServices.RubbergodServiceClient.Value);
    }

    [TestMethod]
    public async Task ProcessAsync()
        => await Instance.ProcessAsync(new List<KarmaItem>());
}
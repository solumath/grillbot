﻿using GrillBot.App.Infrastructure.RequestProcessing;
using GrillBot.App.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using GrillBot.Common.Managers.Logging;
using GrillBot.Data.Models.AuditLog;
using GrillBot.Tests.Infrastructure.Common;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Routing;

namespace GrillBot.Tests.App.Infrastructure.RequestProcessing;

[TestClass]
public class ExceptionFilterTests : TestBase<ExceptionFilter>
{
    protected override ExceptionFilter CreateInstance()
    {
        var discordClient = TestServices.DiscordSocketClient.Value;
        var interactions = DiscordHelper.CreateInteractionService(discordClient);
        var apiRequest = new ApiRequest();
        var auditLogWriter = new AuditLogWriteManager(DatabaseBuilder);
        var loggingManager = new LoggingManager(discordClient, interactions, TestServices.Provider.Value);

        return new ExceptionFilter(apiRequest, auditLogWriter, new ApiRequestContext(), loggingManager);
    }

    private static ExceptionContext CreateContext(Exception exception)
    {
        var httpContext = new DefaultHttpContext();
        var actionContext = new ActionContext(httpContext, new RouteData(), new ActionDescriptor());

        return new ExceptionContext(actionContext, new List<IFilterMetadata>()) { Exception = exception };
    }

    [TestMethod]
    public async Task OperationCancelledException()
    {
        var context = CreateContext(new OperationCanceledException());

        await Instance.OnExceptionAsync(context);
        Assert.IsTrue(context.ExceptionHandled);
    }

    [TestMethod]
    public async Task AnotherError()
    {
        var context = CreateContext(new ArgumentException("Test"));

        await Instance.OnExceptionAsync(context);
        Assert.IsFalse(context.ExceptionHandled);
    }
}

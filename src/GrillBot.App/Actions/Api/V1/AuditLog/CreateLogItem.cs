﻿using GrillBot.App.Managers;
using GrillBot.Common.Managers.Localization;
using GrillBot.Common.Models;
using GrillBot.Data.Models.API.AuditLog;
using GrillBot.Data.Models.AuditLog;

namespace GrillBot.App.Actions.Api.V1.AuditLog;

public class CreateLogItem : ApiAction
{
    private AuditLogWriteManager AuditLogWriteManager { get; }
    private ITextsManager Texts { get; }

    public CreateLogItem(ApiRequestContext apiContext, AuditLogWriteManager auditLogWriteManager, ITextsManager texts) : base(apiContext)
    {
        AuditLogWriteManager = auditLogWriteManager;
        Texts = texts;
    }

    public async Task ProcessAsync(ClientLogItemRequest request)
    {
        ValidateParameters(request);

        var logItem = new AuditLogDataWrapper(request.GetAuditLogType(), request.Content, processedUser: ApiContext.LoggedUser);
        await AuditLogWriteManager.StoreAsync(logItem);
    }

    private void ValidateParameters(ClientLogItemRequest request)
    {
        var flags = new[] { request.IsInfo, request.IsWarning, request.IsError };
        var names = new[] { nameof(request.IsInfo), nameof(request.IsWarning), nameof(request.IsError) };

        ValidationResult result = null;
        if (!flags.Any(o => o))
            result = new ValidationResult(Texts["AuditLog/CreateLogItem/Required", ApiContext.Language], names);
        else if (flags.Count(o => o) > 1)
            result = new ValidationResult(Texts["AuditLog/CreateLogItem/MultipleTypes", ApiContext.Language], names);

        if (result != null)
            throw new ValidationException(result, null, request);
    }
}

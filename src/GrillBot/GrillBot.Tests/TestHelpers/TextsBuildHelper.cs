﻿using GrillBot.Common.Managers.Localization;

namespace GrillBot.Tests.TestHelpers;

public static class TextsBuildHelper
{
    public static ITextsManager CreateTexts()
    {
        return new TextsBuilder()
            .AddText("PublicApiClients/NotFound", "cs", "NotFound")
            .AddText("Invite/NotFound", "cs", "NotFound")
            .AddText("Unverify/SelfUnverify/Keepables/Exists", "cs", "Exists")
            .AddText("ChannelModule/Clean/ResultMessage", "en-US", "{0}-{1}")
            .AddText("AutoReply/NotFound", "cs", "NotFound")
            .AddText("AuditLog/CreateLogItem/Required", "cs", "Required")
            .AddText("AuditLog/CreateLogItem/MultipleTypes", "cs", "MultipleTypes")
            .AddText("ChannelModule/ChannelDetail/ChannelNotFound", "cs", "ChannelNotFound")
            .AddText("Emojization/NoContent", "en-US", "NoContent")
            .AddText("Emojization/DuplicateChar", "en-US", "DuplicateChar")
            .AddText("GuildScheduledEvents/GuildNotFound", "cs", "GuildNotFound")
            .AddText("GuildScheduledEvents/Required/Name", "cs", "Name")
            .AddText("GuildScheduledEvents/Required/StartAt", "cs", "StartAt")
            .AddText("GuildScheduledEvents/Required/EndAt", "cs", "EndAt")
            .AddText("GuildScheduledEvents/Required/Location", "cs", "Location")
            .AddText("AuditLog/GetFileContent/NotFound", "cs", "NotFound")
            .AddText("RemindModule/List/Embed/Title", "en-US", "{0}")
            .AddText("RemindModule/List/Embed/NoItems", "en-US", "{0}")
            .AddText("RemindModule/List/Embed/RowTitle", "en-US", "{0},{1},{2},{3}")
            .AddText("Auth/CreateToken/UserNotFound", "cs", "UserNotFound")
            .AddText("Auth/CreateToken/PublicAdminBlocked", "cs", "PublicAdminBlocked")
            .AddText("Auth/CreateToken/PrivateAdminDisabled", "cs", "PrivateAdminBlocked")
            .AddText("RemindModule/Suggestions/Incoming", "en-US", "{0}{1}{2}")
            .AddText("RemindModule/Suggestions/Outgoing", "en-US", "{0}{1}{2}")
            .AddText("SearchingModule/List/Embed/NoItems", "en-US", "NoItems")
            .AddText("SearchingModule/List/Embed/NoItemsWithQuery", "en-US", "NoItemsWithQuery")
            .AddText("SearchingModule/List/Embed/Title", "en-US", "Title")
            .AddText("BirthdayModule/Info/NoOneHave", "cs", "NoOneHave {0}")
            .AddText("BirthdayModule/Info/Parts/WithoutYears", "cs", "{0}")
            .AddText("BirthdayModule/Info/Parts/WithYears", "cs", "{0},{1}")
            .AddText("BirthdayModule/Info/Template/MultipleForm", "cs", "{0},{1},{2}")
            .AddText("BirthdayModule/Info/Template/SingleForm", "cs", "{0},{1}")
            .AddText("GuildModule/GuildDetail/NotFound", "cs", "GuildNotFound")
            .AddText("User/NotFound", "cs", "NotFound")
            .AddText("AuditLog/List/IdNotNumber", "cs", "{0}")
            .AddText("Points/Board/Counts/FiveAndMore", "en-US", "{0} points")
            .AddText("Points/Board/Row", "en-US", "**{0:N0}.** {1} ({2})")
            .AddText("Points/Board/Title", "en-US", "Title")
            .AddText("Pins/UnpinCount", "en-US", "{0}")
            .AddText("AutoReply/NotFound", "cs", "NotFound")
            .AddText("AuditLog/RemoveItem/NotFound", "cs", "NotFound")
            .AddText("Unverify/SelfUnverify/Keepables/GroupNotExists", "cs", "GroupNotExists")
            .AddText("Unverify/SelfUnverify/Keepables/NotExists", "cs", "NotExists")
            .AddText("ChannelModule/GetChannelboard/NoActivity", "en-US", "NoActivity")
            .AddText("ChannelModule/GetChannelboard/NoAccess", "en-US", "NoAccess")
            .AddText("ChannelModule/GetChannelboard/Title", "en-US", "Title")
            .AddText("ChannelModule/GetChannelboard/Row", "en-US", "Row")
            .AddText("ChannelModule/GetChannelboard/Counts/One", "en-US", "One")
            .AddText("ChannelModule/GetChannelboard/Counts/TwoToFour", "en-US", "TwoToFour")
            .AddText("ChannelModule/GetChannelboard/Counts/FiveAndMore", "en-US", "FiveAndMore")
            .AddText("RemindModule/Copy/RemindNotFound", "en-US", "RemindNotFound")
            .AddText("RemindModule/Copy/SelfCopy", "en-US", "SelfCopy")
            .AddText("RemindModule/Copy/WasCancelled", "en-US", "WasCancelled")
            .AddText("RemindModule/Copy/WasSent", "en-US", "WasSent")
            .AddText("RemindModule/Copy/CopyExists", "en-US", "CopyExists")
            .AddText("RemindModule/Copy/OriginalUserNotFound", "en-US", "OriginalUserNotFound")
            .AddText("BirthdayModule/Info/Parts/WithYears", "cs", "WithYears")
            .AddText("RemindModule/Create/Validation/MinimalTime/One", "en-US", "One")
            .AddText("RemindModule/Create/Validation/MinimalTime/TwoToFour", "en-US", "TwoToFour")
            .AddText("RemindModule/Create/Validation/MinimalTime/FiveAndMore", "en-US", "FiveAndMore")
            .AddText("RemindModule/Create/Validation/MustInFuture", "en-US", "MustInFuture")
            .AddText("RemindModule/Create/Validation/MinimalTimeTemplate", "en-US", "MinimalTimeTemplate,{0}")
            .AddText("RemindModule/Create/Validation/MessageRequired", "en-US", "MessageRequired")
            .AddText("RemindModule/Create/Validation/MaxLengthExceeded", "en-US", "MaxLengthExceeded")
            .AddText("ChannelModule/PostMessage/NoContent", "en-US", "NoContent")
            .AddText("Roles/ListTitle", "en-US", "ListTitle")
            .AddText("Roles/MemberCounts/One", "en-US", "{0}")
            .AddText("Roles/MemberCounts/TwoToFour", "en-US", "{0}")
            .AddText("Roles/MemberCounts/FiveAndMore", "en-US", "{0}")
            .AddText("Roles/Mentionable", "en-US", "Mentionable")
            .AddText("Roles/Managed", "en-US", "Managed")
            .AddText("Roles/PremiumSubscriberRole", "en-US", "PremiumSubscriberRole")
            .AddText("Roles/RoleSummaryLine", "en-US", "RoleSummaryLine_{0}_{1}_{2}_{3}_{4}")
            .AddText("Roles/GuildSummary", "en-US", "{0}_{1}_{2}")
            .AddText("Roles/DetailTitle", "en-US", "{0}")
            .AddText("Roles/DetailFields/CreatedAt", "en-US", "{0}")
            .AddText("Roles/DetailFields/Everyone", "en-US", "{0}")
            .AddText("Roles/DetailFields/Hoisted", "en-US", "{0}")
            .AddText("Roles/DetailFields/Managed", "en-US", "{0}")
            .AddText("Roles/DetailFields/Mentionable", "en-US", "{0}")
            .AddText("Roles/DetailFields/MemberCount", "en-US", "{0}")
            .AddText("Roles/DetailFields/BoosterRole", "en-US", "{0}")
            .AddText("Roles/DetailFields/BotUser", "en-US", "{0}")
            .AddText("Roles/DetailFields/Permissions", "en-US", "{0}")
            .AddText("Roles/Boolean/True", "en-US", "Yes")
            .AddText("Roles/Boolean/False", "en-US", "No")
            .AddText("Unverify/Validation/MinimalTime", "cs", "{0}")
            .AddText("Unverify/Validation/MinimalTime", "cs", "{0}")
            .AddText("Permissions/Useless/CheckSummary", "en-US", "{0}-{1}-{2}")
            .AddText("Unverify/Validation/MinimalTime", "cs", "{0}")
            .AddText("Unverify/Validation/MinimalTime", "cs", "{0}")
            .AddText("AutoReply/NotFound", "cs", "NotFound")
            .AddText("Unverify/Message/UnverifyToChannelWithoutReason", "cs", "{0},{1}")
            .AddText("Unverify/Message/UnverifyToChannelWithReason", "cs", "{0},{1},{2}")
            .AddText("Unverify/Message/PrivateUnverifyWithoutReason", "cs", "{0},{1}")
            .AddText("Unverify/Message/PrivateUnverifyWithReason", "cs", "{0},{1},{2}")
            .AddText("Unverify/Message/PrivateUpdate", "cs", "{0},{1}")
            .AddText("Unverify/Message/PrivateUpdateWithReason", "cs", "{0},{1},{2}")
            .AddText("Unverify/Message/UpdateToChannel", "cs", "{0},{1}")
            .AddText("Unverify/Message/UpdateToChannelWithReason", "cs", "{0},{1},{2}")
            .AddText("Unverify/Message/PrivateManuallyRemovedUnverify", "cs", "{0}")
            .AddText("Unverify/Message/ManuallyRemoveToChannel", "cs", "{0}")
            .AddText("Unverify/Message/ManuallyRemoveFailed", "cs", "{0}({1})")
            .AddText("Unverify/Message/RemoveAccessUnverifyNotFound", "cs", "{0}")
            .AddText("Unverify/Message/UnverifyFailedToChannel", "cs", "{0}")
            .AddText("PublicApiClients/NotFound", "cs", "NotFound")
            .AddText("ChannelModule/ChannelDetail/ChannelNotFound", "cs", "ChannelNotFound")
            .AddText("Jobs/NotFound", "cs", "NotFound")
            .AddText("GuildModule/GuildDetail/NotFound", "cs", "GuildNotFound")
            .AddText("GuildModule/UpdateGuild/AdminChannelNotFound", "cs", "AdminChannelNotFound")
            .AddText("GuildModule/UpdateGuild/MuteRoleNotFound", "cs", "MuteRoleNotFound")
            .AddText("GuildModule/UpdateGuild/EmoteSuggestionChannelNotFound", "cs", "EmoteSuggestionChannelNotFound")
            .AddText("GuildModule/UpdateGuild/VoteChannelNotFound", "cs", "VoteChannelNotFound")
            .AddText("GuildModule/UpdateGuild/BotRoomChannelNotFound", "cs", "BotRoomChannelNotFound")
            .AddText("GuildScheduledEvents/GuildNotFound", "cs", "GuildNotFound")
            .AddText("GuildScheduledEvents/EventNotFound", "cs", "EventNotFound")
            .AddText("GuildScheduledEvents/ForbiddenAccess", "cs", "Forbidden")
            .AddText("User/NotFound", "cs", "NotFound")
            .AddText("ChannelModule/PostMessage/GuildNotFound", "cs", "GuildNotFound")
            .AddText("ChannelModule/PostMessage/ChannelNotFound", "cs", "ChannelNotFound")
            .AddText("User/AccessList/Title", "en-US", "Title")
            .AddText("User/AccessList/NoAccess", "en-US", "NoAccess")
            .AddText("User/AccessList/WithoutCategory", "en-US", "WithoutCategory")
            .AddText("GuildScheduledEvents/GuildNotFound", "cs", "GuildNotFound")
            .AddText("GuildScheduledEvents/EventNotFound", "cs", "EventNotFound")
            .AddText("GuildScheduledEvents/ForbiddenAccess", "cs", "Forbidden")
            .AddText("Unverify/Update/UnverifyNotFound", "cs", "UnverifyNotFound")
            .AddText("RemindModule/CancelRemind/NotFound", "cs", "NotFound")
            .AddText("RemindModule/CancelRemind/AlreadyCancelled", "cs", "AlreadyCancelled")
            .AddText("RemindModule/CancelRemind/AlreadyNotified", "cs", "AlreadyNotified")
            .AddText("RemindModule/CancelRemind/InvalidOperator", "cs", "InvalidOperator")
            .AddText("RemindModule/NotifyMessage/ForceTitle", "cs", "ForceTitle")
            .AddText("RemindModule/NotifyMessage/Title", "cs", "Title")
            .AddText("RemindModule/NotifyMessage/Fields/Id", "cs", "Fields/Id")
            .AddText("RemindModule/NotifyMessage/Fields/From", "cs", "Fields/From")
            .AddText("RemindModule/NotifyMessage/Fields/Attention", "cs", "Fields/Attention")
            .AddText("RemindModule/NotifyMessage/Postponed", "cs", "Postponed")
            .AddText("RemindModule/NotifyMessage/Fields/Message", "cs", "Fields/Message")
            .AddText("RemindModule/NotifyMessage/Fields/Options", "cs", "Fields/Options")
            .AddText("RemindModule/NotifyMessage/Options", "cs", "Options")
            .AddText("User/InfoEmbed/Title", "en-US", "Title")
            .AddText("User/UserStatus/Offline", "en-US", "Offline")
            .AddText("User/InfoEmbed/Fields/State", "en-US", "State")
            .AddText("User/InfoEmbed/Fields/CreatedAt", "en-US", "CreatedAt")
            .AddText("User/InfoEmbed/Fields/ActiveDevices", "en-US", "ActiveDevices")
            .AddText("User/InfoEmbed/Fields/Roles", "en-US", "Roles")
            .AddText("User/InfoEmbed/NoRoles", "en-US", "NoRoles")
            .AddText("User/InfoEmbed/Fields/JoinedAt", "en-US", "JoinedAt")
            .AddText("User/InfoEmbed/Fields/PremiumSince", "en-US", "PremiumSince")
            .AddText("User/InfoEmbed/Fields/Reactions", "en-US", "Reactions")
            .AddText("User/InfoEmbed/Fields/Points", "en-US", "Points")
            .AddText("User/InfoEmbed/Fields/MessageCount", "en-US", "MessageCount")
            .AddText("User/InfoEmbed/Fields/UnverifyCount", "en-US", "UnverifyCount")
            .AddText("User/InfoEmbed/Fields/SelfUnverifyCount", "en-US", "SelfUnverifyCount")
            .AddText("User/InfoEmbed/Fields/UnverifyInfo", "en-US", "UnverifyInfo")
            .AddText("User/InfoEmbed/ReasonRow", "en-US", "ReasonRow")
            .AddText("User/InfoEmbed/UnverifyRow", "en-US", "UnverifyRow")
            .AddText("User/InfoEmbed/UsedVanityInviteRow", "en-US", "UsedVanityInviteRow")
            .AddText("User/InfoEmbed/UsedInviteRow", "en-US", "UsedInviteRow")
            .AddText("User/InfoEmbed/VanityInvite", "en-US", "VanityInvite")
            .AddText("User/InfoEmbed/Fields/UsedInvite", "en-US", "UsedInvite")
            .AddText("User/InfoEmbed/Fields/MostActiveChannel", "en-US", "MostActiveChannel")
            .AddText("User/InfoEmbed/Fields/LastMessageIn", "en-US", "LastMessageIn")
            .AddText("Unverify/ListEmbed/NoUnverify", "en-US", "NoUnverify")
            .AddText("Unverify/ListEmbed/Title", "en-US", "Title")
            .AddText("Unverify/ListEmbed/Boolean/True", "en-US", "True")
            .AddText("Unverify/ListEmbed/Boolean/False", "en-US", "False")
            .AddText("Unverify/ListEmbed/Fields/StartAt", "en-US", "StartAt")
            .AddText("Unverify/ListEmbed/Fields/EndAt", "en-US", "EndAt")
            .AddText("Unverify/ListEmbed/Fields/EndFor", "en-US", "EndFor")
            .AddText("Unverify/ListEmbed/Fields/Selfunverify", "en-US", "Selfunverify")
            .AddText("Unverify/ListEmbed/Fields/Reason", "en-US", "Reason")
            .AddText("Unverify/ListEmbed/Fields/RetainedRoles", "en-US", "RetainedRoles")
            .AddText("Unverify/ListEmbed/Fields/RemovedRoles", "en-US", "RemovedRoles")
            .AddText("Unverify/ListEmbed/Fields/RetainedChannels", "en-US", "RetainedChannels")
            .AddText("Unverify/ListEmbed/Fields/RemovedChannels", "en-US", "RemovedChannels")
            .AddText("Unverify/Recover/MemberNotFound", "cs", "MemberNotFound{0}")
            .AddText("Points/Service/Transfer/UserIsBot", "cs", "UserIsBot{0}")
            .AddText("Points/Service/Transfer/InsufficientAmount", "cs", "InsufficientAmount{0}")
            .AddText("ChannelModule/ChannelInfo/NoAccess", "en-US", "NoAccess")
            .AddText("ChannelModule/ChannelInfo/CreatedAt", "en-US", "CreatedAt")
            .AddText("ChannelModule/ChannelInfo/TextChannelTitle", "en-US", "TextChannelTitle")
            .AddText("ChannelModule/ChannelInfo/MemberCountValue/One", "en-US", "One")
            .AddText("ChannelModule/ChannelInfo/MemberCountValue/FiveAndMore", "en-US", "FiveAndMore")
            .AddText("ChannelModule/ChannelInfo/MemberCount", "en-US", "MemberCount")
            .AddText("ChannelModule/ChannelInfo/PermsCountValue/FiveAndMore", "en-US", "Zero")
            .AddText("ChannelModule/ChannelInfo/PermsCountValue/One", "en-US", "One")
            .AddText("ChannelModule/ChannelInfo/PermsCount", "en-US", "PermsCount")
            .AddText("ChannelModule/ChannelInfo/PermsCountTitle", "en-US", "PermsCountTitle")
            .AddText("ChannelModule/ChannelInfo/MessageCountValue/One", "en-US", "One")
            .AddText("ChannelModule/ChannelInfo/MessageCountValue/FiveAndMore", "en-US", "FiveAndMore")
            .AddText("ChannelModule/ChannelInfo/MessageCount", "en-US", "MessageCount")
            .AddText("ChannelModule/ChannelInfo/FirstMessage", "en-US", "FirstMessage")
            .AddText("ChannelModule/ChannelInfo/LastMessage", "en-US", "LastMessage")
            .AddText("ChannelModule/ChannelInfo/TopTen", "en-US", "TopTen")
            .AddText("ChannelModule/ChannelInfo/Configuration", "en-US", "Configuration")
            .AddText("ChannelModule/ChannelInfo/Flags/CommandsDisabled", "en-US", "CommandsDisabled")
            .AddText("ChannelModule/ChannelInfo/Flags/AutoReplyDeactivated", "en-US", "AutoReplyDeactivated")
            .AddText("ChannelModule/ChannelInfo/Flags/StatsHidden", "en-US", "StatsHidden")
            .AddText("ChannelModule/ChannelInfo/Channel", "en-US", "Channel")
            .AddText("ChannelModule/ChannelInfo/TagsCountValue/FiveAndMore", "en-US", "FiveAndMore")
            .AddText("ChannelModule/ChannelInfo/TagsCount", "en-US", "TagsCount")
            .AddText("ChannelModule/ChannelInfo/PublicThreadCountValue/One", "en-US", "One")
            .AddText("ChannelModule/ChannelInfo/PrivateThreadCountValue/One", "en-US", "One")
            .AddText("ChannelModule/ChannelInfo/ThreadCount", "en-US", "ThreadCount")
            .AddText("Emote/List/NoStatsOfUser", "en-US", "{0}")
            .AddText("Emote/List/NoStats", "en-US", "NoStats")
            .AddText("Emote/List/FieldData", "en-US", "{0}{1}{2}{3}")
            .Build();
    }
}

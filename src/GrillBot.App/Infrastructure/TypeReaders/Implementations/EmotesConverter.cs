﻿using Discord.Net;

namespace GrillBot.App.Infrastructure.TypeReaders.Implementations;

public class EmotesConverter : ConverterBase<IEmote>
{
    public EmotesConverter(IServiceProvider provider, IInteractionContext context) : base(provider, context)
    {
    }

    public override async Task<IEmote?> ConvertAsync(string value)
    {
        if (NeoSmart.Unicode.Emoji.IsEmoji(value)) return new Emoji(value);
        if (Emote.TryParse(value, out var emote)) return emote;

        if (Guild == null)
            return emote;

        if (ulong.TryParse(value, out var emoteId))
        {
            emote = await TryDownloadEmoteAsync(emoteId);

            if (emote != null)
                return emote;
        }

        emote = Guild.Emotes.FirstOrDefault(o => o.Name == value);
        return emote;
    }

    private async Task<Emote> TryDownloadEmoteAsync(ulong emoteId)
    {
        try
        {
            return await Guild.GetEmoteAsync(emoteId);
        }
        catch (HttpException ex) when (ex.DiscordCode == DiscordErrorCode.UnknownEmoji)
        {
            return null;
        }
    }
}

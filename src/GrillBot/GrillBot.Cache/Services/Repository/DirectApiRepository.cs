﻿using GrillBot.Cache.Entity;
using GrillBot.Common.Managers.Counters;
using Microsoft.EntityFrameworkCore;

namespace GrillBot.Cache.Services.Repository;

public class DirectApiRepository : RepositoryBase
{
    public DirectApiRepository(GrillBotCacheContext context, CounterManager counter) : base(context, counter)
    {
    }

    public IEnumerable<DirectApiMessage> GetAll() => Context.DirectApiMessages.ToList();

    private IQueryable<DirectApiMessage> GetBaseQuery(bool asNoTracking = false)
    {
        var query = Context.DirectApiMessages
            .Where(o => o.ExpireAt >= DateTime.UtcNow);

        if (asNoTracking)
            query = query.AsNoTracking();

        return query;
    }

    public async Task<DirectApiMessage?> FindMessageByIdAsync(ulong messageId)
    {
        using (Counter.Create("Cache"))
        {
            return await GetBaseQuery()
                .FirstOrDefaultAsync(o => o.Id == messageId.ToString());
        }
    }

    public async Task<List<DirectApiMessage>> FindExpiredMessagesAsync()
    {
        using (Counter.Create("Cache"))
        {
            return await GetBaseQuery().ToListAsync();
        }
    }
}

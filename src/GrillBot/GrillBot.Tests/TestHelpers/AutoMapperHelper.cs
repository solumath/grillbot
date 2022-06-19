﻿using AutoMapper;
using GrillBot.App;
using GrillBot.Database.Services;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using GrillBot.Cache.Services;
using GrillBot.Common;

namespace GrillBot.Tests.TestHelpers;

[ExcludeFromCodeCoverage]
public static class AutoMapperHelper
{
    public static IMapper CreateMapper()
    {
        var profiles = new[]
            {
                typeof(Startup).Assembly.GetTypes(),
                typeof(Emojis).Assembly.GetTypes(),
                typeof(GrillBotContext).Assembly.GetTypes(),
                typeof(GrillBotCacheContext).Assembly.GetTypes()
            }
            .SelectMany(o => o)
            .Where(o => !o.IsAbstract && typeof(Profile).IsAssignableFrom(o))
            .Select(o => Activator.CreateInstance(o) as Profile)
            .Where(o => o != null)
            .ToList();

        var conf = new MapperConfiguration(c => c.AddProfiles(profiles));
        return conf.CreateMapper();
    }
}

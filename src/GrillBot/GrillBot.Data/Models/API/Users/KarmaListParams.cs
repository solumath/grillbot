﻿using GrillBot.Data.Models.API.Common;

namespace GrillBot.Data.Models.API.Users;

public class KarmaListParams
{
    public SortParams Sort { get; set; } = new() { OrderBy = "Karma" };
    public PaginatedParams Pagination { get; set; } = new();
}
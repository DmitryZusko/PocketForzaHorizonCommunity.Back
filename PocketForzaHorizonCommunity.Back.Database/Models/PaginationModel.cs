﻿using PocketForzaHorizonCommunity.Back.Database.Entities;

namespace PocketForzaHorizonCommunity.Back.Database.Models;

public class PaginationModel<TEntity> where TEntity : EntityBase
{
    public int Total { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
    public IEnumerable<TEntity> Entities { get; set; } = new List<TEntity>();
}

﻿using PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities;

namespace PocketForzaHorizonCommunity.Back.Database.Repos.Interfaces;

public interface ICarRepository : IRepositoryBase<Car>
{
    public IQueryable<Car> GetByIdWithTunes(Guid id);

    public IQueryable<Car> GetByIdWithDesigns(Guid id);
}
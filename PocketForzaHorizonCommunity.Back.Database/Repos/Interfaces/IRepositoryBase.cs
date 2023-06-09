﻿using PocketForzaHorizonCommunity.Back.Database.Entities;

namespace PocketForzaHorizonCommunity.Back.Database.Repos.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        Task CreateAsync(TEntity newEntity);
        void Delete(TEntity entity);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetById(Guid id);
        Task<int> SaveAsync();
        IQueryable<Guid> GetAllIds();
    }
}
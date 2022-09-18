using Microsoft.EntityFrameworkCore;
using NewsProject.Core.DAL;
using NewsProject.Core.Entities;
using NewsProject.DAL.Concreate.EntityFramework.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.DAL.Concreate.EntityFramework
{
    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected readonly AppDbContext _appDbContext;
        private readonly DbSet<TEntity> _dbSet;

        public EntityRepositoryBase(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).SingleOrDefault();
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _dbSet.AsNoTracking().ToList() : _dbSet.Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}


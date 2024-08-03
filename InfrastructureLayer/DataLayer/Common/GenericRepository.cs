using ApplicationLayer.Interfaces.Common;
using InfrastructureLayer.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InfrastructureLayer.DataLayer.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationContext context;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
        }
        public async Task<T> GetSingleEntityAsync(params object[] values)
        {
            return await context.Set<T>().FindAsync(values);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await context.Set<T>().AddRangeAsync(entities);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public IQueryable<T> GetAllAsNonTracking()
        {
            return context.Set<T>().AsNoTracking();
        }

        public T GetById(params object?[]? values)
        {
            return context.Set<T>().Find(values);
        }

        public void Update(T entity)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}

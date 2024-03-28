using Microsoft.EntityFrameworkCore;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Core;

namespace Sales.Infraestructure.Dao
{
    public abstract class DaoBase<TEntity> : IDaoBase<TEntity> where TEntity : class
    {

        private readonly SalesContext context;
        private DbSet<TEntity> entities;

        public DaoBase(SalesContext context)
        {
            this.context = context;
            this.entities = context.Set<TEntity>();
        }


        public bool Exists(Func<TEntity, bool> filter)
        {
            return this.entities.Any(filter);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await this.entities.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await this.entities.FindAsync(id);
        }

        public async Task<List<TEntity>> GetEntitiesWithFilters(Func<TEntity, bool> filter)
        {
            return this.entities.Where(filter).ToList();
        }

        public async Task<DataResult> Save(TEntity entity)
        {
            DataResult result = new DataResult();

            this.entities.Add(entity);

            await this.Commit();

            result.Success = true;
            return result;
        }
        public async Task<int> Commit() => await this.context.SaveChangesAsync();

        public async Task<DataResult> Update(TEntity entity)
        {
            DataResult result = new DataResult();

            this.entities.Update(entity);

            await this.Commit();

            result.Success = true;
            return result;

        }
    }
}

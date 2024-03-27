namespace Sales.Infraestructure.Core
{
    public interface IDaoBase<TEntity> where TEntity : class
    {
        Task<int> Commit();
        Task<DataResult> Save(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<List<TEntity>> GetEntitiesWithFilters(Func<TEntity, bool> filter);
        Task<TEntity> GetById(int id);
        bool Exists(Func<TEntity, bool> filter);
        Task<DataResult> Update(TEntity entity);


    }
}
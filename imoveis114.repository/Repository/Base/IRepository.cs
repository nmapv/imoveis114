namespace imoveis114.repository.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task InsertAsync(TEntity entity);
        Task InsertListAsync(IEnumerable<TEntity> entities);
        Task DeleteAsync(TEntity entity);
        Task<TEntity> GetAsync(string id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity entity);
    }
}
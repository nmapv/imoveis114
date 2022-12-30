using Dapper.Contrib.Extensions;
using imoveis114.entity.Entity;

namespace imoveis114.repository.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected IDBContext _dbcontext;

        public Repository(IDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbcontext.connection.InsertAsync(entity);
        }

        public async Task InsertListAsync(IEnumerable<TEntity> entities)
        {
            await _dbcontext.connection.InsertAsync(entities);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await _dbcontext.connection.DeleteAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbcontext.connection.GetAllAsync<TEntity>();
        }

        public async Task<TEntity> GetAsync(string id)
        {
            return await _dbcontext.connection.GetAsync<TEntity>(id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _dbcontext.connection.UpdateAsync(entity);
        }
    }
}

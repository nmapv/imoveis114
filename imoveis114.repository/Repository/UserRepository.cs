using imoveis114.entity.Entity;

namespace imoveis114.repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}

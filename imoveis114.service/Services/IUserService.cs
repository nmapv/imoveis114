using imoveis114.entity.Entity;

namespace imoveis114.service.Services
{
    public interface IUserService
    {
        Task InsertAsync(User user);
        Task<User?> GetAsync(string id);
    }
}
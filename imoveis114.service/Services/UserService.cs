using imoveis114.entity.Entity;
using imoveis114.repository.Repository;

namespace imoveis114.service.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<User> InsertAsync(User user)
        {
            await this.unitOfWork.userRepository.InsertAsync(user);
            return user;
        }

        public async Task<User?> GetAsync(string id)
        {
            return await this.unitOfWork.userRepository.GetAsync(id);
        }
    }
}

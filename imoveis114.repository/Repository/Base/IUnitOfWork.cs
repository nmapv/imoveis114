namespace imoveis114.repository.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository userRepository { get; }
    }
}
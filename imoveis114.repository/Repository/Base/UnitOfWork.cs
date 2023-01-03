﻿namespace imoveis114.repository.Repository.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBContext _dbcontext;

        #pragma warning disable CS8618
        public UnitOfWork(IDBContext dbcontext) => _dbcontext = dbcontext;
        #pragma warning restore CS8618

        private IUserRepository _userRepository;
        public IUserRepository userRepository => this.GetInstance<IUserRepository, UserRepository>(ref _userRepository);

        public void Dispose() => _dbcontext.Dispose();

        private T GetInstance<T, U>(ref T repository)
        {
            if (repository == null)
            {
                var instance = Activator.CreateInstance(typeof(U), this._dbcontext);
                if (instance != null)
                    repository = (T)instance;
            }                

            return repository;
        }
    }
}
using System.Data;

namespace imoveis114.repository.Repository
{
    public interface IDBContext : IDisposable
    {
        IDbConnection connection { get; }
    }
}
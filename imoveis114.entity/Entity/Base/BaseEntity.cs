using Dapper.Contrib.Extensions;

namespace imoveis114.entity.Entity
{
    public abstract class BaseEntity
    {
        [ExplicitKey]
        public string id { get; protected set; }
        public DateTime created { get; protected set; }
    }
}

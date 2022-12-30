namespace imoveis114.entity.Entity
{
    public class Broker : BaseEntity
    {
        public string creci { get; private set; }
        public string user_id { get; private set; }

        public Broker(string id, string creci, string user_id, DateTime created)
        {
            this.id = id;
            this.creci = creci;
            this.user_id = user_id;
            this.created = created;
        }

        public Broker(string creci, string user_id)
        {
            this.id = Guid.NewGuid().ToString();
            this.creci = creci;
            this.user_id = user_id;
            this.created = DateTime.Now;
        }   
    }
}

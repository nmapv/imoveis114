using Dapper.Contrib.Extensions;

namespace imoveis114.entity.Entity
{
    [Table("User")]
    public class User : BaseEntity
    {
        public string email { get; private set; }
        public string password { get; private set; }
        public string first_name { get; private set; }
        public string last_name { get; private set; }
        public string code { get; private set; }
        public bool activated { get; private set; }

        public User(string id, string email, string password, string first_name, string last_name, string code, bool activated, DateTime created)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.first_name = first_name;
            this.last_name = last_name;
            this.code = code;
            this.activated = activated;
            this.created = created;
        }

        public User(string email, string password, string first_name, string last_name) 
        {
            this.id = Guid.NewGuid().ToString();
            this.email = email;
            this.password = password;
            this.first_name = first_name;
            this.last_name = last_name;
            this.activated = false;
            this.created = DateTime.Now;
            this.NewCode();
        }

        public void Activate(string code)
        {
            this.activated = this.code.Equals(code);
        }

        public void NewCode()
        {
            this.code = new Random().Next(0, 1000000).ToString("D6");
        }
    }
}

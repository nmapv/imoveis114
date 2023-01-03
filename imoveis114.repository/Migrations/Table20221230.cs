using FluentMigrator;

namespace imoveis114.repository.Migrations
{
    [Migration(1)]
    public class Table20221230 : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Create.Table("User")
               .WithColumn("id").AsString().NotNullable().PrimaryKey().Unique()
               .WithColumn("email").AsString().NotNullable().Unique()
               .WithColumn("password").AsString().NotNullable()
               .WithColumn("first_name").AsString().NotNullable()
               .WithColumn("last_name").AsString().NotNullable()
               .WithColumn("code").AsString().NotNullable()
               .WithColumn("activated").AsBoolean().NotNullable()
               .WithColumn("created").AsDateTime().Nullable();
        }
    }
}

using imoveis114.repository.Repository;
using imoveis114.repository.Repository.Base;
using imoveis114.service.Services;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace imoveis114.tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var serviceProvider = services
                .AddSingleton<IDBContext, DBContext>()
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddScoped<IUserService, UserService>()
                .AddFluentMigratorCore()
                .ConfigureRunner(c => c
                    .AddSQLite()
                    .WithGlobalConnectionString("DataSource=file::memory:?cache=shared")
                    .ScanIn(AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.Contains("imoveis114.repository")).ToArray()).For.Migrations())
                .AddLogging(c => c.AddFluentMigratorConsole())
                .BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
    }
}

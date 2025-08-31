namespace QuanLyDaiLyHD.DI;
using QuanLyDaiLyHD.Data;
using QuanLyDaiLyHD.Services;
using QuanLyDaiLyHD.ServiceImpls;
using Microsoft.EntityFrameworkCore;
public static class AppModule
{
    //IServiceProvider : Dung de lay service da dang ky
    public static IServiceCollection RegisterDependency(this IServiceCollection services)
    {
        // Register 
        services.AddSingleton<Configs.DatabaseConfig>();
        // Register DbContext ( for SQlite)
        services.AddDbContext<Data.DataContext>(static (serviceProvider, options) =>
        {
            var dbPath = Configs.DatabaseConfig.GetResourcePath();
            options.UseSqlite($"Data Source={dbPath}");
        });
        services.AddScoped<DatabaseService,DatabaseServiceImpl>();
        return services;
    }
}
//SingleTon : Tao 1 lan, dung ca app
//Transient : Can thi moi tao
// Scoped :Tuong tu singleton, nhung chi Tao 1 lan trong 1 scope (vd: 1 request)
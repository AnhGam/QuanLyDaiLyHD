using QuanLyDaiLyHD.Services;
using QuanLyDaiLyHD.Configs;
namespace QuanLyDaiLyHD.ServiceImpls;

public class DatabaseServiceImpl : DatabaseService
{
    private readonly DatabaseConfig databaseConfig;
    public DatabaseServiceImpl(DatabaseConfig databaseConfig)
    {
        this.databaseConfig = databaseConfig;
    }
    public  async Task InitializeAsync()
    {
        await databaseConfig.Initialize();


    }
    private async Task SeedData()
    {
        await Task.CompletedTask;
    }


}
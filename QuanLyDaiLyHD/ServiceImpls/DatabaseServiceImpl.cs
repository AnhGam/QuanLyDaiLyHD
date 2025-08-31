using QuanLyDaiLyHD.Services;
namespace QuanLyDaiLyHD.ServiceImpls;

public class DatabaseServiceImpl : DatabaseService
{
    private readonly Configs.DatabaseConfig _databaseConfig;
    public DatabaseServiceImpl(Configs.DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
    }
    public  async Task InitializeAsync()
    {
        await _databaseConfig.InitializeAsync();

    }
}
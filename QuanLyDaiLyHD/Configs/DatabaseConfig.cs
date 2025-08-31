using QuanLyDaiLyHD.Data;
using System.Reflection;
namespace QuanLyDaiLyHD.Configs;

public class DatabaseConfig
{
    private readonly DataContext _dataContext;

    public DatabaseConfig(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public DataContext DataContext => _dataContext ?? throw new Exception("DataBase not initialized");

    public static string GetResourcePath()
    {
        string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? AppDomain.CurrentDomain.BaseDirectory;
        string relativePath = Path.Combine(appDirectory, @"C:\Users\Admin\source\repos\QuanLyDaiLyHD\QuanLyDaiLyHD\Resources\Database");
        string databaseDirectory = Path.GetFullPath(relativePath);
        Directory.CreateDirectory(databaseDirectory);
        return Path.Combine(databaseDirectory, $"QuanLyDaiLy.db");
    }
    
    public async Task InitializeAsync()
    {
        await _dataContext.Database.EnsureCreatedAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using QuanLyDaiLyHD.Configs;
using QuanLyDaiLyHD.Data;
using QuanLyDaiLyHD.Interfaces;
using QuanLyDaiLyHD.Repositories;
using QuanLyDaiLyHD.ServiceImpls;
using QuanLyDaiLyHD.Services;
using QuanLyDaiLyHD.ViewModels.DaiLyViewModels;
using QuanLyDaiLyHD.Views.DaiLyViews;

namespace QuanLyDaiLyHD.DI;

public static class AppModule
{
    // IServiceProvider: Dung de lay ra cac service da duoc dang ky
    public static IServiceCollection RegisterDependency(this IServiceCollection services)
    {
        // Đăng ký ở chỗ này
        services.AddSingleton<DatabaseConfig>();

        // Đăng ký cho SQLite 
        services.AddDbContext<DataContext>((serviceProvider, options) =>
        {
            var databasePath = DatabaseConfig.GetResourcePath();
            options.UseSqlite($"Data Source={databasePath}");
        });

        // Đăng ký các service khác ở đây
        services.AddTransient<DatabaseService, DatabaseServiceImpl>();
        services.AddScoped<IDaiLyService, DaiLyServiceImpl>();
        services.AddScoped<ILoaiDaiLyService, LoaiDaiLyServiceImpl>();
        services.AddScoped<IQuanService, QuanServiceImpl>();
        services.AddScoped<IThamSoService, ThamSoServiceImpl>();

        // Đăng ký Repository
        services.AddScoped<IDaiLyRepository, DaiLyRepository>();
        services.AddScoped<ILoaiDaiLyRepository, LoaiDaiLyRepository>();
        services.AddScoped<IQuanRepository, QuanRepository>();
        services.AddScoped<IThamSoRepository, ThamSoRepository>();

        // Đăng ký Views 
        services.AddTransient<DanhSachDaiLyPage>();
        services.AddTransient<ThemDaiLyWindow>();

        // Đăng ký ViewModels
        services.AddTransient<DanhSachDaiLyPageViewModel>();
        services.AddTransient<ThemDaiLyWindowViewModel>();

        return services;
    }
}
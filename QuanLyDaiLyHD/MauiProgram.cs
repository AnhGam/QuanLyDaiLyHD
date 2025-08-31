using Microsoft.Extensions.Logging;
using QuanLyDaiLyHD.DI;
using System.Data.SqlTypes;

namespace QuanLyDaiLyHD
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.RegisterDependency();
            // Tự config -> IServiceProvider
            // IServiceCollection
            var appBuilder = builder.Build();
            _ = Task.Run(async () =>
            { 
                using var scope = appBuilder.Services.CreateScope();
                await scope.ServiceProvider.GetRequiredService<Services.DatabaseService>().InitializeAsync();
            });
            return appBuilder;
        }
    }
}

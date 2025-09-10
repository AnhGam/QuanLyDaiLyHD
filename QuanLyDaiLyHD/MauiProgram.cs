using Microsoft.Extensions.Logging;
using QuanLyDaiLyHD.DI;
using System.Data.SqlTypes;
using CommunityToolkit.Maui;
using QuanLyDaiLyHD.Services;

namespace QuanLyDaiLyHD
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fontello.ttf","MyIcons");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.RegisterDependency();

            var appBuilder = builder.Build();

            appBuilder.Services.GetRequiredService<DatabaseService>().InitializeAsync();

            return appBuilder;
        }
    }
}
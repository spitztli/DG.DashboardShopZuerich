using DG.DashboardShopZuerich.Services;
using Microsoft.Extensions.Logging;

namespace DG.DashboardShopZuerich
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            //builder.Services.AddBlazorWebViewDeveloperTools();
            //builder.Logging.AddDebug();

            // JsonDataService als Singleton registrieren
            builder.Services.AddSingleton<JsonDataService>(provider => new JsonDataService("C:\\Users\\samvo\\source\\repos\\DG.DashboardShopZuerich\\DG.DashboardShopZuerich\\wwwroot\\employee.json"));
#endif

            return builder.Build();
        }
    }
}

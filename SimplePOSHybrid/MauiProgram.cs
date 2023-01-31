using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using SimplePOSHybrid.Data;
using SimplePOSHybrid.Models.PartnerMenu;

namespace SimplePOSHybrid;

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
        builder.Services.AddMudServices();
        builder.Services.AddSingleton<LoginMethods>();
        builder.Services.AddSingleton<Rootobject>();
        builder.Services.AddSingleton<DashboardView>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }
}

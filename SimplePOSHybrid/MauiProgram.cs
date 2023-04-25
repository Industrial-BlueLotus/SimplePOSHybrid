using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using SimplePOSHybrid.Data;
using SimplePOSHybrid.Models.PartnerMenu;
using SimplePOSHybrid.Models;
using SimplePOSHybrid.Pages;
using SimplePOSHybrid.Models.GetCustomer;

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
        builder.Services.AddSingleton<ItemModel>();
        //builder.Services.AddSingleton<GetCustomerModel>();
        builder.Services.AddSingleton<LoginResModel>();
        builder.Services.AddSingleton<DashboardView>();
        builder.Services.AddSingleton<CustomerView>();
        builder.Services.AddSingleton<OrderStateService>();
        builder.Services.AddSingleton<LoginStateService>();
        builder.Services.AddScoped<BrowserService>();
        builder.Services.AddScoped<LoginMethods>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }
}

using Material.Components.Maui.Extensions;
using Microsoft.Extensions.Logging;

namespace MauiMaterialApp;

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

        //material
        builder.UseMaterialComponents(new List<string>
        {
            //generally, we needs add 6 types of font families
            //"SourceHanSansCN-Regular.otf",
            //"SourceHanSansCN-Medium.otf",
            //"SourceHanSansCN-Bold.otf",
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
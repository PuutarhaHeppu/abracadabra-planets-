namespace abracadabra__planeta_;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("times new roman bold italic.ttf", "OpenSansRegular");
				fonts.AddFont("times new roman bold.ttf", "timesnewromanbold");
                fonts.AddFont("times new roman italic.ttf", "timesnewromanitalic");
                fonts.AddFont("times new roman.ttf", "RegularFont");
            });

		return builder.Build();
	}
}

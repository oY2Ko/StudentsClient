using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Server.Models;
using StudentsClient.Models;
using StudentsClient.Pages;
using StudentsClient.ViewModels;
using StudentsClient.Views;

namespace StudentsClient;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<FillingInTest>();
		builder.Services.AddScoped<MainPage>();
		builder.Services.AddScoped<QuestionWithTextAnswerPage>();
		builder.Services.AddScoped<TestsPage>();
#if DEBUG
		builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}

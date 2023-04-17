using CommunityToolkit.Maui.Views;
using Server.Models;
using StudentsClient.Models;
using StudentsClient.Views;

namespace StudentsClient;

public partial class MainPage : ContentPage
{
	private FillingInTest _fillingInTest;

	public MainPage(FillingInTest fillingInTest)
	{
		InitializeComponent();
		_fillingInTest = fillingInTest;
	}

	private void Start(object sender, EventArgs e)
	{
		Navigation.PushAsync(new TestsPage(_fillingInTest));
    }
}


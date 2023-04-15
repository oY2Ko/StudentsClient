using StudentsClient.Views;

namespace StudentsClient;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Start(object sender, EventArgs e)
	{
		Navigation.PushAsync(new TestsPage());
	}
}


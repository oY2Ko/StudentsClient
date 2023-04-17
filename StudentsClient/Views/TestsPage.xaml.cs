using Server.Models;
using StudentsClient.Models;
using StudentsClient.ViewModels;

namespace StudentsClient.Views;

public partial class TestsPage : ContentPage
{
	public TestsPage(FillingInTest _fillingInTest)
	{
		InitializeComponent();
		BindingContext = new TestsPageViewModel(_fillingInTest);
	}
}
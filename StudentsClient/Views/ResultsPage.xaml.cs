using StudentsClient.Models;
using StudentsClient.ViewModels;

namespace StudentsClient.Views;

public partial class ResultsPage : ContentPage
{
	public ResultsPage(FillingInTest test)
	{
		InitializeComponent();
		BindingContext = new ResultsPageViewModel(test);
	}
}
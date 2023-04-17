using Server.Models;
using StudentsClient.Models;
using StudentsClient.ViewModels;

namespace StudentsClient.Pages;

public partial class QuestionWithTextAnswerPage : ContentPage
{
	public QuestionWithTextAnswerPage(FillingInTest fillingInTest)
	{
		InitializeComponent();
		BindingContext = new QuestionWithTextAnswerViewModel(fillingInTest);
	}
}
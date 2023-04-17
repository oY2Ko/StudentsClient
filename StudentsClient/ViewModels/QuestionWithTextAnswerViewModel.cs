using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Server.Models;
using StudentsClient.Models;
using StudentsClient.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClient.ViewModels
{
    internal partial class QuestionWithTextAnswerViewModel : ObservableObject
    {
        private FillingInTest _fillingInTest;
        [ObservableProperty]
        private string _questionNumber;
        [ObservableProperty]
        private string _questionText;
        [ObservableProperty]
        private string _answer;
        [ObservableProperty]
        private string _buttonText;
        public QuestionWithTextAnswerViewModel(FillingInTest fillingInTest)
        {
            _fillingInTest = fillingInTest;
            _questionNumber = "Вопрос номер "+ _fillingInTest.CurrentQuestion;
            _questionText = _fillingInTest.CorrectTest.Questions[_fillingInTest.CurrentQuestion].Text;
            if (_fillingInTest.CurrentQuestion == _fillingInTest.CorrectTest.Questions.Count - 1)
            {
                _buttonText = "Закончить тест";
            }
            else
            {
                _buttonText = "Далее";
            }
        }
        [RelayCommand]
        public void Next()
        {
            if (_answer == _fillingInTest.CorrectTest.Questions[_fillingInTest.CurrentQuestion].Answer)
            {
                _fillingInTest.AddScore(_fillingInTest.CorrectTest.Questions[_fillingInTest.CurrentQuestion].Mark);
            }
            if (_fillingInTest.CurrentQuestion == _fillingInTest.CorrectTest.Questions.Count - 1)
            {
                //TODO: Страница результатов
            }
            _fillingInTest.CurrentQuestion++;
            Shell.Current.Navigation.PushAsync(new QuestionWithTextAnswerPage(_fillingInTest));
        }
    }
}

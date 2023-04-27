using CommunityToolkit.Mvvm.ComponentModel;
using StudentsClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClient.ViewModels
{
    internal partial class ResultsPageViewModel : ObservableObject
    {
        
        private double _maxScore;
        private double _currentScore;
        [ObservableProperty]
        private string _scoreResult;
        public ResultsPageViewModel(FillingInTest fillingInTest)
        {
            _maxScore = fillingInTest.CorrectTest.Questions.Sum(x => x.Mark);
            _currentScore = fillingInTest.Score;
            _scoreResult = $"{_currentScore} баллов из {_maxScore}";
        }
    }
}

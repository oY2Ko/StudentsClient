using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Server.Models;
using StudentsClient.Models;
using StudentsClient.Pages;
using StudentsClient.Views;

namespace StudentsClient.ViewModels
{
    internal partial class TestsPageViewModel : ObservableObject
    {
        //[ObservableProperty]
        //public ObservableCollection<Test> _tests = new();
        public ObservableCollection<Test> _tests { get; set; }
        [ObservableProperty]
        string label = "Тесты";
        [ObservableProperty]
        private Test _selectedTest;
        [ObservableProperty]
        private string _buttonText = "Приступить к тесту";
        private readonly TestsPage _testsPage;
        private FillingInTest _fillingInTest;

        public TestsPageViewModel(FillingInTest _fillingInTest)
        {
            _tests = new ObservableCollection<Test>();
            try
            {
                var client = new HttpClient();
                var res = client.GetFromJsonAsync<List<Test>>("https://localhost:7232/Tests/tests").Result;
                foreach (var item in res)
                {
                    _tests.Add(item);

                }

            }
            catch (Exception)
            {

                label = "Ошибка сервера";
            }
            this._fillingInTest = _fillingInTest;
        }
        [RelayCommand]
        private void StartTest()
        {
            if (_selectedTest is null)
            {
                Shell.Current.DisplayAlert("Ошибка", "Тест не выбран", "Ok");
            }
            else
            {

                _fillingInTest.CorrectTest = _selectedTest;
                Shell.Current.Navigation.PushAsync(new QuestionWithTextAnswerPage(_fillingInTest));
            }
        }
    }
}

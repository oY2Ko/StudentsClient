using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Server.Models;

namespace StudentsClient.ViewModels
{
    internal partial class TestsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string label = "Тесты";
        public TestsPageViewModel()
        {
            try
            {
                var client = new HttpClient();
                _tests = client.GetFromJsonAsync<List<Test>>("https://localhost:7232/Tests/tests").Result;

            }
            catch (Exception)
            {

                label = "Ошибка сервера";
            }
        }
        [ObservableProperty]
        public List<Test> _tests;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
using MathAppApi.Models;

namespace MathApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnPage : ContentPage
    {
        public LearnPage()
        {
            InitializeComponent();
            GetLessons();
        }

        public async void GetLessons()
        {
            HttpClient _http = new HttpClient();
            var response = await _http.GetStringAsync("http://localhost:62338/api/lessons/");
            List<Lesson> lessons = JsonConvert.DeserializeObject<List<Lesson>>(response);
            LessonsListView.ItemsSource = lessons;
        }
    }
}
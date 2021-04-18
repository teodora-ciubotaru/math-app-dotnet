using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MathApp.Common;
using MathAppApi.Models;
using Newtonsoft.Json;
using MathApp.Views;

namespace MathApp.Services
{
    public class RestService : IRestService
    {
        private readonly HttpClient _http;
        private object serializerOptions;

        public RestService()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            _http = new HttpClient();
        }

        //public async void GetLessons()
        //{
        //     var response = await _http.GetStringAsync("http://localhost:62338/api/lessons/");
        //    List<Lesson> lessons = JsonConvert.DeserializeObject<List<Lesson>>(response);
        //    //LessonsListView.ItemSource = lessons;
        //    LearnPage.LessonsListView.ItemsSource = lessons;
        //}
       
        //public async Task<string> Test()
        //{
        //    Uri uri = new Uri(Requests.Test);

        //    HttpResponseMessage response = await _http.GetAsync(uri);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        string content = await response.Content.ReadAsStringAsync();
        //        //Items = JsonSerializer.Deserialize<List<TodoItem>>(content, serializerOptions);
        //    }

        //    return "";
        //}

        //public async Task<List<Lesson>> Lesson()
        //{
        //    Uri uri = new Uri("http://localhost:62338/api/lessons/");
        //    Lessons = new List<Lesson>();

        //    HttpResponseMessage response = await _http.GetAsync(uri);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        string content = await response.Content.ReadAsStringAsync();
        //        //Lessons = JsonSerializer.Deserialize<List<Lesson>>(content, serializerOptions);
        //    }

        //    return Lessons;
        //}




    }
}

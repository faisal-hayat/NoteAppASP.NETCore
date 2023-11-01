using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NotesAPI.Models;
using System.Text.Json.Serialization;

namespace NotesAPI.Controllers
{
    public class HomeController : Controller
    {
        public string url = "https://www.facebook.com/api";
        public async IActionResult Index()
        {
            List<Note> notes = new List<Note>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage httpResponse = await client.GetAsync("Employee/GetAllEmployees");
                if (httpResponse.IsSuccessStatusCode)
                {
                    var employeesResponse = httpResponse.Content.ReadAsStreamAsync().Result;
                    notes = JsonConvert.DeserializeObject<List<Note>>(employeesResponse.ToString());
                }
            }
            
            return View(notes);
        }
    }
}

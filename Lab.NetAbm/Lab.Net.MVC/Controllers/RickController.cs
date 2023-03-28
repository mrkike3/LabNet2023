using Lab.Net.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Lab.Net.MVC.Controllers
{
    public class RickController : Controller
    {
        private readonly HttpClient _httpClient;
        // GET: Rick

        public RickController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://rickandmortyapi.com/api/character");
        }
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ResponseRick>(json);
                return View(data.results);
            }
            else
            {
                return View("Error");
            }
        }
    }
}
    
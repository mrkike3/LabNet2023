using Lab.Net.MVC.Models;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static Lab.Net.MVC.Models.RickView;

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
    
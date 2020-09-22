using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieProject.Models;

namespace MovieProject.Controllers
{
    public class AdminController : Controller
    {
        public IHttpClientFactory _clientFactory { get; set; }
        public AdminController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<ActionResult> Index()
        {
            var client = _clientFactory.CreateClient("MovieProject");
            List<Movie> movies = await client.GetFromJsonAsync<List<Movie>>("Movie");
            return View(movies);
        }
    }
}

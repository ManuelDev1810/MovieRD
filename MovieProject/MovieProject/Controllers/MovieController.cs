using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieProject.Models;

namespace MovieProject.Controllers
{
    public class MovieController : Controller
    {
        public IHttpClientFactory _clientFactory { get; set; }
        public MovieController(IHttpClientFactory clientFactory)
       {
            _clientFactory = clientFactory;
       }

       public async Task<ActionResult> Index()
        {
            List<Movie> movies;
            try
            {
                //Use the factory to create a client for us
                //Either call from an existing client or it will create a new client depending on its rules
                //It has a pool of clients and it managed it without causing an socket exhaustion
                //It does a lot of things for us
                var client = _clientFactory.CreateClient("MovieProject");
                movies = await client.GetFromJsonAsync<List<Movie>>("Movie");
            }
            catch (Exception)
            {
                ModelState.AddModelError("error", "Ocurrio un problema guardando el archivo.");
                return BadRequest();
            }

            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }
 
        [HttpPost]
        public async Task<ActionResult> Create(Movie movie)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var client = _clientFactory.CreateClient("MovieProject");
                    var response = await client.PostAsJsonAsync("Movie", movie);
                }
                catch(Exception)
                {
                    ModelState.AddModelError("error", "Ocurrio un problema guardando el archivo.");
                    return BadRequest(); 
                }
            } else
            {
                return Ok(movie);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var client = _clientFactory.CreateClient("MovieProject");
            Movie movie = await client.GetFromJsonAsync<Movie>("Movie/GetByID/" + id);
            if (movie != null)
            {
                return View(movie);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var client = _clientFactory.CreateClient("MovieProject");
                    var response = await client.PutAsJsonAsync("Movie", movie);
                }
                catch (Exception)
                {
                    ModelState.AddModelError("error", "Ocurrio un problema editando la pelicula.");
                    return BadRequest();
                }
            }
            else
            {
                return Ok(movie);
            }

            return RedirectToAction("Edit", new { id = movie.ID });
        }

        public async Task<IActionResult> Movie(string id)
        {
            var client = _clientFactory.CreateClient("MovieProject");
            Movie movie = await client.GetFromJsonAsync<Movie>("Movie/GetByID/" + id);

            if (movie != null)
                return View(movie);
            else
                return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var client = _clientFactory.CreateClient("MovieProject");
                Movie movie = await client.GetFromJsonAsync<Movie>("Movie/Delete/" + id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("error", "Ocurrio un problema eliminando la pelicula." + e.Message);
                return RedirectToAction("Index", "Admin");
            }

            return RedirectToAction("Index", "Admin");
        }
    }
}

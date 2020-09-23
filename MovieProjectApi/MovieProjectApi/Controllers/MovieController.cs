using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieProjectApi.Models;
using MovieProjectApi.Services.Interfaces;

namespace MovieProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IEnumerable<Movie> Get() 
        {
            return _movieRepository.GetAllWithComments();
        }

        [HttpGet("GetByID/{id}")]
        public async Task<Movie> GetByID(string id)
        {
            return await _movieRepository.GetByID(id);
        }

        [HttpPost]
        public ActionResult Post(Movie movie)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _movieRepository.Add(movie);
                } catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            } else
            {
                string errorMessages = string.Join("; ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
                return BadRequest(errorMessages);
            }

            return Ok();
        }

        [HttpPut]
        public ActionResult Update(Movie movie)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _movieRepository.Update(movie);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            else
            {
                string errorMessages = string.Join("; ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
                return BadRequest(errorMessages);
            }

            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _movieRepository.Remove(await GetByID(id));
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            else
            {
                string errorMessages = string.Join("; ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
                return BadRequest(errorMessages);
            }

            return Ok();
        }
    }
}

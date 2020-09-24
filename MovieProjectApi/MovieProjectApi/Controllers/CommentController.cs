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
    public class CommentController : ControllerBase
    {
        public ICommentRepository _commentRepository { get; set; }
        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Comment>> Get()
        {
            return Ok(_commentRepository.GetAllWithMovie());
        }

        [HttpGet("GetByID/{id}")]
        public async Task<Comment> GetByID(string id)
        {
            return await _commentRepository.GetByID(id);
        }

        [HttpGet("GetAllByMovieID/{id}")]
        public IEnumerable<Comment> GetAllByMovieID(string id)
        {
            return _commentRepository.GetAllByMovieID(id);
        }

        [HttpPost]
        public ActionResult Post(Comment comment)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _commentRepository.Add(comment);
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

        [HttpPatch]
        public ActionResult Update(Comment comment)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _commentRepository.Update(comment);
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

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _commentRepository.Remove(await GetByID(id));
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

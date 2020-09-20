using System.Collections.Generic;
using System.Linq;
using ApiPruebaSQlITE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaSQlITE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        private readonly HeroDbContext heroDbContext;

        public HeroController(HeroDbContext heroDb)
        {
            heroDbContext = heroDb;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hero>> Get()
        {
            return Ok(heroDbContext.Heroes.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Hero hero)
        {
            heroDbContext.Heroes.Add(hero);
            heroDbContext.SaveChanges();
            return Ok();
        }
    }
}

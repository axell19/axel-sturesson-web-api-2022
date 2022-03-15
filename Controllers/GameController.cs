using System.Collections.Generic;
using System.Linq;
using axel_sturesson_web_api_2022.models;
using Microsoft.AspNetCore.Mvc;

namespace axel_sturesson_web_api_2022.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game> {
            new Game(), 
            new Game{ Id = 1, Name = "Splitgate"}

        };

        [HttpGet("GetAll")]
        public ActionResult<List<Game>> Get()
        {
            return Ok(games);
        }
        [HttpGet("{id}")]
        public ActionResult<Game> GetSingle(int id)
        {
            return Ok(games.FirstOrDefault(c => c.Id == id));
        }
        
        [HttpPost]
        public ActionResult<List<Game>> AddGame(Game newGame)
        {
            games.Add(newGame);
            return Ok (games);
        }
        
    }
}
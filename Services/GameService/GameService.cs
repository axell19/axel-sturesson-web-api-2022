using System.Collections.Generic;
using System.Linq;
using axel_sturesson_web_api_2022.models;

namespace axel_sturesson_web_api_2022.Services.GameService
{
    public class GameService : IGameService
    {

         private static List<Game> games = new List<Game> {
            new Game(), 
            new Game{ Id = 1, Name = "Splitgate"}

        };
        public List<Game> AddGame(Game newGame)
        {
            games.Add(newGame);
            return games;
        }

        public List<Game> GetAllGames()
        {
            return games;
        }

        public Game GetGameById(int id)
        {
            return games.FirstOrDefault(c => c.Id == id);
        }
    }
}
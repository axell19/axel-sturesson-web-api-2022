using System.Collections.Generic;
using System.Linq;
using axel_sturesson_web_api_2022.models;
using Microsoft.EntityFrameworkCore;

namespace axel_sturesson_web_api_2022.Services.GameService
{
    public class GameService : IGameService
    {

         private static List<Game> games = new List<Game> {
            new Game(), 
            new Game{ Id = 1, Name = "Splitgate"}

        };
        private readonly DataContext _context;
        private Game newGame;

        public GameService(DataContext context)
        {
            _context = context;
        }
        public List<Game> AddGame(Game newGame)
        {
            games.Add(newGame);
            return _context.games.ToList();
        }

        public List<Game> GetAllGames()
        {
            _context.games.Add(newGame);
            _context.SaveChanges();
            return _context.games.ToList();
        }

        public List<Game> DeleteGame(int id){
            var hittadGame = _context.games.FirstOrDefault(game => game.Id == id);
            _context.games.Remove(hittadGame);
            _context.SaveChanges();

            return _context.games.ToList();
        }

        public Game GetGameById(int id)
        {
            return games.FirstOrDefault(c => c.Id == id);
        }
    }
}
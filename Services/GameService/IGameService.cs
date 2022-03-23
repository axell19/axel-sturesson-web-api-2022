using System.Collections.Generic;
using axel_sturesson_web_api_2022.models;

namespace axel_sturesson_web_api_2022.Services.GameService
{
    public interface IGameService
    {
        List<Game> GetAllGames();
        Game GetGameById(int id);
        List<Game> AddGame(Game newGame);
        List<Game> DeleteGame(int id);
    }
}
namespace axel_sturesson_web_api_2022.models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Polytopia";
        public int Price { get; set; } = 35;
        public string Type { get; set; } = "Strategy";

        public GameClass Class { get; set; } = GameClass.Game;

    }
}
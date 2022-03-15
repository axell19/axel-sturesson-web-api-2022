using System.Text.Json.Serialization;

namespace axel_sturesson_web_api_2022.models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GameClass
    {
        Game,

        Demo,

        Trailer
    }
}
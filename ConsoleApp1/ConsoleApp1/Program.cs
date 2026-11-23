
using System.Text.Json;


JsonSerializerOptions options = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true
};

string json = """
              {
              "title": "Dark Souls",
              "Year": 2011,
              "Rating": 9.5,
              "Genres": ["RPG", "Action"],
              "IsMultiplayer": true
              }
              """;
// Необходимо с помощью настроек сериализотора выставить невосприимчиваость к регистру в именах
Game loadGame = JsonSerializer.Deserialize<Game>(json,options);
Console.WriteLine(loadGame.Title);

              
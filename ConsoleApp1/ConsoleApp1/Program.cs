
using System.Text.Json;

// //Задача 2
// JsonSerializerOptions options = new JsonSerializerOptions()
// {
//     PropertyNameCaseInsensitive = true
// };
//
// string json = """
//               {
//               "title": "Dark Souls",
//               "Year": 2011,
//               "Rating": 9.5,
//               "Genres": ["RPG", "Action"],
//               "IsMultiplayer": true
//               }
//               """;
// // Необходимо с помощью настроек сериализотора выставить невосприимчиваость к регистру в именах
// Game loadGame = JsonSerializer.Deserialize<Game>(json,options);
// Console.WriteLine(loadGame.Title);


//------------------------------------------------------

// Задача 4
class Program
{
    static void Main(string[] args)
    {
        GameCharacter Player = new GameCharacter("Bob Clarkson", 2, 100, ["pen","socks","Manual C#"]);
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };
        string json = JsonSerializer.Serialize(Player, options);
        Console.WriteLine(json);
        GameCharacter? Player2 = JsonSerializer.Deserialize<GameCharacter>(json, options);
        // Console.WriteLine(Player2.Name);
        // Console.WriteLine(Player2.Health);
        // Console.WriteLine(Player2.Level);
        // foreach (string item in Player2.inventory)
        // {
        //     Console.WriteLine(item);
        // }
        Console.WriteLine(Player2.Name);
        Console.WriteLine(Player2.inventory.Length);
    }
}
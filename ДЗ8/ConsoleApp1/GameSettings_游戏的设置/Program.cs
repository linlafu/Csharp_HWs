

using System.Text.Json;

class Program
{
    static void Main()
    {
        string path = Path.Combine(
            AppContext.BaseDirectory,
            "settings.json"
        );
        JsonSerializerOptions options = new JsonSerializerOptions(){ WriteIndented = true, PropertyNameCaseInsensitive = true};
        if (File.Exists(path))
        {
                string json = File.ReadAllText(path);
                GameSetting? gameSetting = JsonSerializer.Deserialize<GameSetting>(json,options);
                if (gameSetting != null)
                {
                    Console.WriteLine("=== Текущие настроки ===");
                    Console.WriteLine($"Имя игрока: {gameSetting.PlayerName}");
                    Console.WriteLine($"Сложность: {gameSetting.Difficulty}");
                    Console.WriteLine($"Громкость: {gameSetting.MusicVolume}");
                }
        }
        else
        {
            Console.WriteLine("Файл настроек не найден. Создаём новые настройки.");
            Console.Write("Введите имя игрока: ");
            string playerName = Console.ReadLine() ?? "";
            Console.Write("Выберите сложность (1-3): ");
            int difficulty = int.Parse(Console.ReadLine()!);

            Console.Write("Введите громкость (0-100): ");
            int musicVolume = int.Parse(Console.ReadLine()!);
            GameSetting gameSetting = new GameSetting(playerName, difficulty, musicVolume);
            string json = JsonSerializer.Serialize(gameSetting, options);
            File.WriteAllText(path, json);
        }
    }
}
class Program
{
    static void Main()
    {
        Player player = new Player("Arthur", 100, 20);
        

        List<IUsableItem> items = new List<IUsableItem>
        {
            new HealthPotion(),
            new Sword(),
            new AncientScroll()
        };
        Console.WriteLine("--- Начальные характеристики ---");
        Console.WriteLine($"Имя: {player.Name}");
        Console.WriteLine($"HP: {player.HP}");
        Console.WriteLine($"Damage: {player.Damage}");
        foreach (IUsableItem item in items)
        {
            item.Use(player);
        }
        Console.WriteLine("--- Итоговые характеристики ---");
        Console.WriteLine($"Имя: {player.Name}");
        Console.WriteLine($"HP: {player.HP}");
        Console.WriteLine($"Damage: {player.Damage}");
        Console.WriteLine(player.HP > 0 ? "Игрок жив" : "Игрок мёртв");
    }
}
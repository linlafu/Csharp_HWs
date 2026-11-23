public enum Rarity
{
    Common,
    Rare,
    Legendary
}

public interface IUsableItem
{
    string Name { get; }
    string Description { get; }
    Rarity Rarity { get; }
    void Use(Player player);
}

public class Player
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Damage { get; set; }

    public Player(string name, int hp, int damage)
    {
        Name = name;
        HP = hp;
        Damage = damage;
    }

    public void Heal(int amount)
    {
        HP += amount;
    }

    public void IncreaseDamage(int amount)
    {
        Damage += amount;
    }
}

public class HealthPotion : IUsableItem
{
    public string Name { get; } = "Health Potion";
    public string Description { get; } = "Восстанавливает 50 HP";
    public Rarity Rarity { get; } = Rarity.Common;

    public void Use(Player player)
    {
        player.Heal(50);
        Console.WriteLine($"Вы использовали зелье и восстановили 50 HP");
    }
}

public class AncientScroll : IUsableItem
{
    public string Name { get; } = "Ancient Scroll";
    public string Description { get; } = "Наносит 20 урона, но увеличивает Damage на 30";
    public Rarity Rarity { get; } = Rarity.Legendary;

    public void Use(Player player)
    {
        player.HP -= 20;
        player.IncreaseDamage(30);

        Console.WriteLine("Вы использовали древний свиток: получили 20 урона, но увеличили Damage на 30!");
    }
}

public class Sword : IUsableItem
{
    public string Name { get; } = "Sword";
    public string Description { get; } = "Увеличивает урон игрока на 10";
    public Rarity Rarity { get; } = Rarity.Rare;

    public void Use(Player player)
    {
        player.IncreaseDamage(10);
        Console.WriteLine("Вы использовали меч и увеличили урон на 10!");
    }
}
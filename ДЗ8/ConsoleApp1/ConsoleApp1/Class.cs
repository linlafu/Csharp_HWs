public class GameCharacter
{
    public string Name { get; set; }
    public int Level { get; set; }
    public double Health { get; set; }
    public string[] inventory { get; set; }

    public GameCharacter(string name, int level, double health, string[] inventory )
    {
        Name = name;
        Level = level;
        Health = health;
        this.inventory = inventory;
    }
    public GameCharacter()
    {
        Name = string.Empty;
        Level = 0;
        Health = 0;
        inventory = [];
    }
}
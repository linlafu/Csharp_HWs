
class Program
{
    static void Main()
    {
        Knight knight = new Knight();
        Mage mage = new Mage();

        while (!knight.IsDead && !mage.IsDead)
        {
            knight.Attack(mage);

            if (!mage.IsDead)
            {
                mage.Attack(knight);
            }
        }

        Console.WriteLine(knight.IsDead
            ? $"Победил {mage.Name}!"
            : $"Победил {knight.Name}!");
    }
}
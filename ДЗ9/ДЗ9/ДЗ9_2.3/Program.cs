class Program
{
    static void Main()
    {
        Unit unit = new Unit("Goblin", 200, 20);

        DamageSystem physical = new DamageSystem(new PhysicalDamageCalculator());
        DamageSystem magic = new DamageSystem(new MagicDamageCalculator());
        DamageSystem fire = new DamageSystem(new FireDamageCalculator());

        physical.ApplyDamage(unit, 60);
        magic.ApplyDamage(unit, 60);
        fire.ApplyDamage(unit, 60);
    }
}
public interface ICombatant
{
    public string Name { get; }
    public int HP{ get; set;  }
    public bool IsDead { get; }
    public int Damage { get; }
    public void Attack(ICombatant target);
    public void TakeDamage(int amount);
}


public class Knight : ICombatant
{
    public string Name { get; }
    public int HP { get; set; }
    public bool IsDead { get =>  HP <= 0; }
    public int Damage { get; }
    public void Attack(ICombatant target)
    {
        if (IsDead)
        {
            Console.WriteLine($"{Name} is dead");
            return;
        }

        if (target.IsDead)
        {
            Console.WriteLine($"{target.Name} is dead");
            
            return;
        }
        Console.WriteLine($"{Name} is attacking");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int amount)
    {
        if (HP - amount >= 0)
        {
            HP -= amount;
            Console.WriteLine($"{Name} has been hit for {amount} HP, {Name} have {HP} HP");
        }
        else
        {
            HP = 0;
            Console.WriteLine($"{Name} has been hit for {amount} HP, {Name} have {HP} HP");
        }
    }

    public Knight()
    {
        Name = "Arture";
        HP = 150;
        Damage = 25;
    }

    public Knight(string name, int hp, int damage)
    {
        Name = name;
        HP = hp;
        Damage = damage;
    }
}

public class Mage : ICombatant{
    public string Name { get; }
    public int HP { get; set; }
    public bool IsDead { get; }
    public int Damage { get; }
    public void Attack(ICombatant target)
    {
        if (IsDead)
        {
            Console.WriteLine($"{Name} is dead");
            return;
        }

        if (target.IsDead)
        {
            Console.WriteLine($"{target.Name} is dead");
            return;
        }
        Console.WriteLine($"{Name} is attacking");
        target.TakeDamage(Damage);
        Console.WriteLine($"{Name} is attacking one more time");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int amount)
    {
        if (HP - amount >= 0)
        {
            HP -= amount;
            Console.WriteLine($"{Name} has been hit for {amount} HP, {Name} have {HP} HP");
        }
        else
        {
            HP = 0;
            Console.WriteLine($"{Name} has been hit for {amount} HP, {Name} have {HP} HP");
        }
    }

    public Mage(string name, int hp, int damage)
    {
        Name = name;
        HP = hp;
        Damage = damage;
    }

    public Mage()
    {
        Name = "Merlin";
        HP = 80;
        Damage = 40;
    }
}

class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }

    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }

    public virtual int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
}

class Wizard : Human
{
    public Wizard(string name, int str, int intel, int dex) : base(name, str, intel, dex, 50)
    {
        Intelligence = intel;
    }

    public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and healed for {dmg}!");
        return target.Health;
    }

    public void Heal(Human target)
    {
        int amt = Intelligence * 3;
        target.Health += amt;
        Console.WriteLine($"{Name} healed {target.Name} for {amt} health!");
    }
}

class Ninja : Human
{
    public Ninja(string name, int str, int intel, int dex) : base(name, str, intel, dex, 100)
    {
        Dexterity = dex;
    }

    public override int Attack(Human target)
    {
        int dmg = Dexterity;
        if (new Random().Next(100) < 20)
        {
            dmg += 10;
        }
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }

    public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
        Console.WriteLine($"{Name} stole 5 health from {target.Name} and added it to their own health!");
    }
}

class Samurai : Human
{
    public Samurai(string name, int str, int intel, int dex) : base(name, str, intel, dex, 200)
    {
    }

    public override int Attack(Human target)
    {
        int remainingHealth = target.Health;
        base.Attack(target);
        if (remainingHealth > 0 && target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine($"{Name} finished off {target.Name}!");
        }
        return target.Health;
    }

    public void Meditate()
    {
        Health = 200;
        Console.WriteLine($"{Name} meditated and healed back to full health!");
    }
}

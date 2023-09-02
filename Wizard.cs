public class Wizard : Enemy
{
    public Wizard(string name) : base(name, 80)
    {
        AttackList.Add(new Attack("Fireball", 25));
        AttackList.Add(new Attack("Lighting Bolt", 20));
        AttackList.Add(new Attack("Staff Strike", 10));
    }

    public void Heal(Enemy Target)
    {
        Target.Health += 40;
        Console.WriteLine($"You have healed {Target.Name} and is at {Target.Health} health.");

    }
}
public class Enemy
{
    public string Name;
    public int Health = 100;
    public List<Attack> AttackList;

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
    }


    //methods

    public Attack RandomAttack()
    {
        Random rand = new Random();
        return AttackList[rand.Next(0, AttackList.Count)];
    }

    // Inside of the Enemy class
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health = Target.Health - ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }


}
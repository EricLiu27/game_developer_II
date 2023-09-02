public class Fighter : Enemy
{
    public Fighter(string name) : base(name, 120)
    {
        AttackList.Add(new Attack("Punch", 20));
        AttackList.Add(new Attack("Kick", 15));
        AttackList.Add(new Attack("Tackle", 25));
    }
    public void Rage(Enemy Target)
    {
        Target.Health = Target.Health - base.RandomAttack().DamageAmount + 10;
    }

}
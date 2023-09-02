public class Ranger : Enemy
{
    public int Distance = 5;
    public Ranger(string name) : base(name, 100)
    {
        AttackList.Add(new Attack("Shoot an Arrow", 20));
        AttackList.Add(new Attack("Throw a Knife", 15));
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance < 10)
        {
            Console.WriteLine("Can not attack enemies within 10 meters.");
        }
        else
        {

            base.PerformAttack(Target, ChosenAttack);
        }
    }

    public void Dash()
    {
        Distance = 20;
    }

}
class Goblin : Enemy
{

    public Goblin(string name, int dmg) : base(name, 30, dmg)
    {
        
    }

    public override void AttackMessage(string enemy)
    {
        Console.WriteLine($"{_name} stabs {enemy} quickly");
    }
}
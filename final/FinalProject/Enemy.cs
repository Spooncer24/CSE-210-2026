using System.Runtime.InteropServices.Marshalling;

abstract class Enemy : Character
{
    protected int _dmg;
    public Enemy(string name, int health, int dmg) : base(name, health)
    {
        _dmg = dmg;
    }

    override public void AttackMessage(string enemy)
    { 
        Console.WriteLine($"{_name} slashes with weopon");
    }

    public int GetDMG()
    {
        return _dmg;
    }
}
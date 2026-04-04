abstract class Character
{
    protected string _name;
    protected int _hp;
    // protected bool _isalive;

    public Character(string name, int health)
    {
        _name = name;
        _hp = health;
    }

    public void AttackMessage()
    {
        Console.WriteLine($"{_name} flails fists");
    }

    public void TakeDamage(int damage)
    {
        _hp =- damage;
    }

    abstract public bool CheckLife();
}
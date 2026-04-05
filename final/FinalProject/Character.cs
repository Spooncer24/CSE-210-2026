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

    public void TakeDamage(int damage)
    {
        _hp -= damage;
    }

    public bool CheckLife()
    {
        //If player hp is equal or less than 0 return false because the player is dead
        if (_hp <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    virtual public void AttackMessage(string enemy)
    {
        Console.WriteLine($"{_name} flails arms");
    }

    public string GetName()
    {
        return _name;
    }

    public int GetHP()
    {
        return _hp;
    }
}
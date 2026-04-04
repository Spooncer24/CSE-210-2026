class Player : Character
{
    private List<Items> _inventory;
    private int _maxhp;

    public Player(string name, int health, int maxhp, List<Items> inventory) : base(name, health)
    {
        _maxhp = maxhp;
        _inventory = inventory;
    }

    
}
using System.Data;

class Player : Character
{
    private Inventory _inventory;
    private int _maxhp;

    public Player(string name, int health, int maxhp) : base(name, health)
    {
        _maxhp = maxhp;
        _inventory = new Inventory();
    }

    public void Heal(int amount)
    {
        //hear character
        _hp += amount;

        //if character _hp higher then _maxhp set _hp = _maxhp
        if(_hp > _maxhp)
        {
            _hp = _maxhp;
        }

        Console.WriteLine($"{_name} healed {amount} HP!");
    }

    //add item to inventory
    public void AddItem(string name, int amount)
    {
        _inventory.AddItem(name, amount);
    }

    //display inventory
    public void ShowInventory()
    {
        _inventory.DisplayInventory();
    }

    public override void AttackMessage(string enemy)
    {
        Console.WriteLine($"{_name} Slashes at {enemy}");
    }

    public void UsePotion()
    {
        bool used = _inventory.UseItem("Health Potion");

        if (used)
        {
            Heal(50); // matches your potion description
        }
        else
        {
            Console.WriteLine("No Health Potions left!");
        }
    }
}
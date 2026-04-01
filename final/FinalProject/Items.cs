using System.ComponentModel;
using System.Security.Cryptography;

class Items
{
    private string _name;
    private string _description;
    private int _type; //types include 0; weapon, 1; potion.
    private int _amount; //If weapon then this is damage 

    public Items(string name, string description, int type, int amount)
    {
        _name = name;
        _description = description;
        _type = type;
        _amount = amount;
    }

    // If player gets more of an item add to it
    public void AddToItem(int addAmount)
    {
        _amount = _amount + addAmount;
    }

    //Display info on a item
    public void DisplayInfo()
    {
        if (_type == 0)
        {
            Console.WriteLine($"{_name}, DMG: {_amount}");
            Console.WriteLine($"Desc: {_description}");
        }
        else
        {
            Console.WriteLine($"{_name}, amt: {_amount}");
            Console.WriteLine($"Desc: {_description}");
        }
    }
}
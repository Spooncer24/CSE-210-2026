using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

class Inventory
{
    private List<Items> myInventory = new List<Items>();
    
    //Initialize items into inventory
    public Inventory()
    {
        myInventory.Add(new Items("Dagger","Deals 10 DMG", 0, 10));
        myInventory.Add(new Items("Sword", "Deals 35 DMG", 0, 0));
        myInventory.Add(new Items("Health Potion","Restores 50 HP", 2, 2));
    }

    public void DisplayInventory()
    {
        foreach (Items item in myInventory)
        {
            item.DisplayInfo();
        }
    }

    public void AddItem(string name, int amount)
    {
        //Search items using name and if name matches add to items
        foreach(Items item in myInventory)
        {
            if(item.GetName() == name)
            {
                item.AddToItem(amount);
            }
        }
        //Console.WriteLine("Item not found");
    }

    public bool UseItem(string name)
{
    foreach (Items item in myInventory)
        {
            if (item.GetName() == name && item.GetAmount() > 0)
            {
                item.AddToItem(-1); // remove one
                return true;
            }
        }   

        return false;
    }
}
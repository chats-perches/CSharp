using System.Collections.Generic;

public class Inventory
{
    public List<Item> Items { get; set; }
    public int Size { get; set; }

    public Inventory()
    {
        Items = new List<Item>();
        Size = 4;
    }


}
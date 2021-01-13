public class Hero
{
    private static int NextId = 1;

    public int Id { get; private set; }
    public Inventory Inventory { get; set; }

    public int InventoryCapacity {get; set;}

    public string Name { get; set; }
    public double Health { get; set; }

    public double RemainingHealth { get; set; }

    public double Strength { get;  set; }
    
    public double Magic { get;  set; }

    public double Mana { get;  set; }

    public double RemainingMana { get; set; }

    public int Gold { get; set; }

    public double Experience { get; set; }

    public int Level { get;  set; }

    public Hero()
    {
        Id = NextId;
        NextId++;
    }

    public Hero(string name, double strength, double magic) : this()
    {
        
        Name = name;
        Strength = strength;
        Magic = magic;
        Inventory = new Inventory();
        InventoryCapacity = 4;
        Health = 5.0 + strength / 2;
        Mana = 5.0 + magic / 2;
        Experience = 0;
        Level = 0;
        Gold = 10;
    }

    public void Acquire(Item item)
    {
        if( item.Space + Inventory.Items.Count <= Inventory.Size) {
            Inventory.Items.Add(item);
        }
    }
    
    public void Toss(Item item)
    {
        Inventory.Items.Remove(item);
    }
}
using System;

public abstract class Item
{
    public string Name { get; set; }

    public bool Portable { get; set; }

    public bool Usable { get; set; }
    public int NumUses { get; set; }

    public int Space { get; set; }

}
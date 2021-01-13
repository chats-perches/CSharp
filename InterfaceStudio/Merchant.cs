using System.Collections.Generic;

public class Merchant
{
    public string Name { get; set; }

    public string LookingFor { get; set; }

    public bool IsSkinflint { get; set; }

    public List<Item> Stock { get; set; }

    public Merchant(string name, string lookingFor, bool isSkinflint, List<Item> stock)
    {
        Name = name;
        LookingFor = lookingFor;
        IsSkinflint = isSkinflint;
        Stock = stock;
    }

    public void Purchase(Hero hero, int price, Item item)
    {
        hero.Gold += price;
        hero.Toss(item);
        Stock.Add(item);
    }

    public void Sell(Hero hero, int price, Item item)
    {
        if(hero.Gold >= price)
        {
            hero.Gold -= price;
            hero.Acquire(item);
            Stock.Remove(item);
        }
    }
}
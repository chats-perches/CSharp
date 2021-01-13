public class Potion : Item, IConsumable
{
    double BoonOrIll { get; set; }
    public Potion(string name, double boonOrIll, int numUses)
    {
        Portable = true;
        Usable = true;
        Name = name;
        NumUses = numUses;
        BoonOrIll = boonOrIll;
    }

    public void EatOrDrink(Hero hero)
    {
        double effect = hero.RemainingHealth + BoonOrIll;

        if (NumUses>0) { 
            if(effect > 0 && effect < hero.Mana) { 
                hero.RemainingMana += BoonOrIll;
            } else if (effect < 0){
                hero.RemainingMana = 0;
            } else {
                hero.RemainingMana = hero.Mana;
            }
            NumUses--;
        }
    }
}

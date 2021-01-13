public class Food: Item, IConsumable
{
    double BoonOrIll { get; set; }
    public Food(string name, double boonOrIll, int numUses)
    {
        Portable = true;
        Usable = true;
        Space = 1;
        Name = name;
        NumUses = numUses;
        BoonOrIll = boonOrIll;
    }

    public void EatOrDrink(Hero hero)
    {
        double effect = hero.RemainingHealth + BoonOrIll;
        if (NumUses > 0) {
            if( effect > 0 && effect < hero.Health ) { 
            hero.RemainingHealth += BoonOrIll;
            } 
            else if( effect < 0) {
                hero.RemainingHealth = 0;
            }
            else {
                hero.RemainingHealth = hero.Health;
            }
            NumUses--;
        }
    }

}
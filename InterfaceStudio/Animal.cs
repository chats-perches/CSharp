public class Animal : NPC, IConsumable
{
    public bool Dead { get; set; }
    public int NumUses { get; set; }

    public double Health { get; set; }
    Animal(int numUses, double health)
    {
        NumUses = numUses;
        Health = health;
        Dead = false;
    }

    public void EatOrDrink(Hero hero)
    {
        if (Dead) {
            return;
        }
    }
}
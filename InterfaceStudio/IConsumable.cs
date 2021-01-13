public interface IConsumable
{

    public int NumUses { get; set; }

    // What methods
    public void EatOrDrink(Hero hero);
}

public class Weapon : Item, ICommodity, IDestructable
{
    public int Worth { get; set; }

    public double State { get; set; }

    public double Power { get; set; }
    public double RequiredStrength { get; set; }

    public bool ReadyToHand { get; set; }

    public Weapon(int worth, double state, double power, double requiredStrenth, bool usable, int numUses, int space)
    {
        Worth = worth;
        State = state;
        Power = power;
        RequiredStrength = requiredStrenth;
        Usable = usable;
        NumUses = numUses;
        Space = space;
        Portable = true;
        ReadyToHand = false;
    }

    public int Assay(Merchant merchant)
    {
        int liberality;
        if ( !merchant.IsSkinflint && merchant.LookingFor == "weapon") {
            liberality = 4;
        }
        else if( !merchant.IsSkinflint || merchant.LookingFor == "weapon") {
            liberality = 2;
        }
        else {
            liberality = 1;
        }

        return (int)(liberality *((Worth + Power)/(4 + NumUses/100)));
    }

    public void Appreciate(int value)
    {
        Worth += value;
    }

    public void Depreciate(int value)
    {
        Worth -= value;
    }
}
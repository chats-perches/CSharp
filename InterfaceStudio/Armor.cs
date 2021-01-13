public class Armor : Item, ICommodity
{
    public int Worth { get; set; }
    public double Protection { get; set; }
    public bool Schick { get; set; }

    public double RequiredStrength { get; set; }

    public Armor(string name, int space, bool usable, int worth, double protection, 
        bool schick, double requiredStrength, int numUses)
    {
        Name = name;
        Usable = usable;
        Space = space;
        Worth = worth;
        Protection = protection;
        Schick = schick;
        RequiredStrength = requiredStrength;
        NumUses = numUses;
        Portable = true;
    }

    public int Assay(Merchant merchant)
    {
        int priceFactor = 1;

        if (Schick)
        {
            priceFactor++;
        }

        if (!merchant.IsSkinflint)
        {
            priceFactor++;
        }

        if (merchant.LookingFor.contains("armor"))
        {
            priceFactor++;
        }
        return (int) (priceFactor * (Worth + Protection) / (1 + NumUses / 100));
    }
    public void Appreciate(int value)
    {
        int marketValue = 1;
        if (Schick)
        {
            marketValue *= 2;
        }
        Worth += marketValue * value;
    }

    public void Depreciate(int value)
    {
        int marketValue = 1;
        if (!Schick)
        {
            Appreciate(-2 * value);
        }
        else
        {
            Worth -= value;
        }
    }
}
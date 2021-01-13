public interface ICommodity
{
    public int Worth { get; set; }

    public int Assay(Merchant merchant);

    public void Appreciate(int value);

    public void Depreciate(int value);
}
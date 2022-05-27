namespace ex._6;

public class Bill
{
    public int Nominal { get; private set; }
    public string Currency { get; private set; }

    public Bill(int nominal, string currency)
    {
        Nominal = nominal;
        Currency = currency;
    }

    public override string ToString()
    {
        return $"{Nominal} {Currency}";
    }
}
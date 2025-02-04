Console.WriteLine("Immutable Struct");


public enum CurrencyEnum
{
    PLN,
    EUR,
    USD
}
public readonly struct Price
{
    public readonly decimal Amount {get; init;}
    public readonly CurrencyEnum Currency {get;init;}
    public override string ToString()
    {
        return $"{Amount} {Currency}";
    }
    public Price(decimal amount, CurrencyEnum currency)
    {
        Amount = amount;
        Currency = currency;
    }
}

class Converter
{
    private decimal evro;
    private decimal dolar;

    public Converter(decimal evro, decimal dollar)
    {
        this.evro = evro;
        this.dolar = dollar;
    }
    public decimal grivnaToEvro(decimal grivna)
    {
        return grivna / evro;
    }
    public decimal grivnaToDollar(decimal grivna)
    {
        return grivna / dolar;
    }
    public decimal evroToGrivna(decimal grivna)
    {
        return grivna * evro;
    }
    public decimal dollarToGrivna(decimal grivna)
    {
        return grivna * dolar;
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter grivnas: ");
        decimal currency = Convert.ToDecimal(Console.ReadLine());
        Converter converter = new Converter(45, 42);

        Console.WriteLine($"In dollars: {converter.grivnaToDollar(currency)} In evros {converter.grivnaToEvro(currency)}");
        
        Console.WriteLine("Enter dollrs: ");
        currency = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"In grivna: {converter.dollarToGrivna(currency)} ");

        Console.WriteLine("Enter evros: ");
        currency = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"In grivna: {converter.evroToGrivna(currency)} ");
    }
}
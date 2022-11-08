namespace _007_Association;


public class Product
{
    public Product()
    {
        Console.WriteLine($"Create an example of class {nameof(Product)}");
    }
}

public class Factory
{
    public Product FactoryMethod() => new Product();
}

public static class Program
{
    private static void Main()
    {
        var factory = new Factory();
        var product = factory.FactoryMethod();
    }
}

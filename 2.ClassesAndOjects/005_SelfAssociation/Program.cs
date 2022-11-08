using Console = System.Console;

namespace _005_SelfAssociation;

public class Program
{
    public void Method()
    {
        Console.WriteLine("Hello World");
    }

    private static void Main()
    {
        var program = new Program();
        program.Method();
    }
}

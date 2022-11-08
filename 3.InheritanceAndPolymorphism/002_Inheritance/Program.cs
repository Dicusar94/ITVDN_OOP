namespace _002_Inheritance;

static class Program
{
    static void Main()
    {
        var instance = new DerivedClass();
        System.Console.WriteLine(instance.publicField);

        instance.Show();
    }
}
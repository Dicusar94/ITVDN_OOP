namespace _004_Constructors;

static class Program
{
    static void Main()
    {
        var derivedClass = new DerivedClass(20, 15);
        var sumOfNumbers = derivedClass.GetNumberSum();
        System.Console.WriteLine(sumOfNumbers);
    }
}
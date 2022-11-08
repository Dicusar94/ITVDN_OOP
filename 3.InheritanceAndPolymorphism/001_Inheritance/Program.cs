namespace _001_Inheritance;


class Program
{
    static void Main()
    {
        var baseClass = new BaseClass();
        var derivedClass = new DerivedClass();

        Execute(derivedClass);
    }

    static void Execute(BaseClass obj)
    {
        System.Console.WriteLine($"{obj.ClassName}");
    }
}

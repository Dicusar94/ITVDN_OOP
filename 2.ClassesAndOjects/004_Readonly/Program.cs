namespace _004_Readonly;

public class Program
{
    private static readonly string _firstField = "hello";
    private const string _secondNonstatic = "hello";
    private static readonly string _thirdField;
    private readonly string _readOnlyNonStatic;

    public Program(string readOnlyNonStatic)
    {
        _readOnlyNonStatic = readOnlyNonStatic;
    }
    static Program()
    {
        _thirdField = "some string";
    }

    public void SomeMethod()
    {
        // _readOnlyNonStatic = "change name"; //error
        Console.WriteLine(_readOnlyNonStatic);
    }

    private static void Main()
    {
        Console.WriteLine(_firstField);
        Console.WriteLine(_secondNonstatic);
        Console.WriteLine(_thirdField);

        var program = new Program("some non static field");
        program.SomeMethod();
    }
}

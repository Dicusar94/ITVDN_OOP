namespace _008_Association;

public class MyClass1
{
    public MyClass1()
    {
        Console.WriteLine($"Created an example of {nameof(MyClass1)}");
    }
}

public class MyClass2
{
    private MyClass1? _myClass1;

    public void MyMethod()
    {
        _myClass1 = new MyClass1();
    }
}

public static class Program
{
    private static void Main()
    {
        var myClass2 = new MyClass2();
        myClass2.MyMethod();
    }
}
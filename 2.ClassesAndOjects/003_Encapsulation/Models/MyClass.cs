namespace _003_Encapsulation.Models;

public class MyClass
{
    private MyClass? _myClass;

    private void Method()
    {
        Console.WriteLine("Hello");
    }

    public void CallMethod()
    {
        _myClass = new MyClass();
        _myClass.Method();
    }
}
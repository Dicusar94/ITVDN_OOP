using _003_Encapsulation.Models;

namespace _003_Encapsulation;
public static class Program
{
    private static void Main()
    {
        var myClass = new MyClass();
        myClass.CallMethod();
        //myClass.Method(); - doesn't compile private
    }
}
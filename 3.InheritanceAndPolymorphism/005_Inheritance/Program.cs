using _005_Inheritance.Extensions;
namespace _005_Inheritance;

static class Program
{
    static void Main()
    {
        DerivedClass instance = new DerivedClass();

        SetInstanceFields(instance);

        Console.WriteLine($"Print fields from {nameof(DerivedClass)}");
        instance.PrintValueFields();

        var newInstance = (BaseClass)instance;

        Console.WriteLine($"Print fields from {nameof(BaseClass)}");
        Console.WriteLine(newInstance.field1);
        Console.WriteLine(newInstance.field2);
        Console.WriteLine(newInstance.field3);
    }

    private static void SetInstanceFields(object instance)
    {
        var fieldList = instance.GetType().GetFields();
        int iterator = default;
        foreach (var field in fieldList)
        {
            field.SetValue(instance, iterator++);
        }
    }
}
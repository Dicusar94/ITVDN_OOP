using _005_Inheritance.Extensions;
namespace _005_Inheritance;

static class Program
{
    static void Main()
    {
        DerivedClass instance = new DerivedClass();
        SetInstanceFields(instance);
        instance.PrintValueFields();
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
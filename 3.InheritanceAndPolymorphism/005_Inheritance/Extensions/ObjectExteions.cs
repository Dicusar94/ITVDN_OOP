namespace _005_Inheritance.Extensions;

public static class ObjectExtensions
{
    public static void PrintValueFields(this object instance)
    {
        var list = GetInstanceValues(instance);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static IEnumerable<object?> GetInstanceValues(object instance)
    {
        var fieldList = instance.GetType().GetFields();
        var list = fieldList.Select(x => x.GetValue(instance));
        return list;
    }
}
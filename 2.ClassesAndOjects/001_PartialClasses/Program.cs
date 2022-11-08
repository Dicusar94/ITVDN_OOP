using _001_PartialClasses.PartialClasses;

namespace _001_PartialClasses;

public static class Program
{
    private static void Main()
    {
        var partialClass = new PartialClass_1();
        PartialClass_1.MethodFromPart1();
        PartialClass_1.MethodFromPart2();
    }
}
namespace _002_PartialMethods.PartialMethods;

public partial class PartialClass_1
{
    public partial void PartialMethod()
    {
        Console.WriteLine($"Calling {nameof(PartialMethod)}");
    }
}
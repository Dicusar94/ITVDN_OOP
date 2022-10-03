using _12_Document.Document.Parts.Base;

namespace _12_Document.Document.Parts;

public class Body : BasePart
{
    public Body(string partName = nameof(Body)) : base(partName)
    {
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Show();
    }
}
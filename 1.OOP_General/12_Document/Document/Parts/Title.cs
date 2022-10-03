using _12_Document.Document.Parts.Base;

namespace _12_Document.Document.Parts;

public class Title : BasePart
{
    public Title(string partName = nameof(Title)) : base(partName)
    {
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.Show();
    }
}
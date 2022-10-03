using _12_Document.Document.Parts.Base;

namespace _12_Document.Document.Parts;

public class Footer : BasePart
{
    public Footer(string partName = nameof(Footer)) : base(partName)
    {
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.Show();
    }
}
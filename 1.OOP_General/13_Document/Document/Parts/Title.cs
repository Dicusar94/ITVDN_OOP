using _13_Document.Document.Parts.Base;

namespace _13_Document.Document.Parts;

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
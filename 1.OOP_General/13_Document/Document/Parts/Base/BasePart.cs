using _13_Document.Document.Parts.Interfaces;

namespace _13_Document.Document.Parts.Base;

public abstract class BasePart : IPart
{
    private string _content = null!;
    protected readonly string _errorMessage = null!;

    protected BasePart(string partName)
    {
        _errorMessage = $"The {partName} content is missing";
    }

    public string Content
    {
         get => _content ?? _errorMessage;
         set => _content = value;
    }

    public virtual void Show()
    {
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

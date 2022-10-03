using _12_Document.Document.Parts;
using _12_Document.Document.Parts.Interfaces;

namespace _12_Document.Document;

public class Document
{
    private readonly IList<IPart> _parts;

    public Document(Title title, Body body, Footer footer)
    {
        _parts = new List<IPart>
        {
            title,
            body,
            footer
        };
    }

    public void Show()
    {
        foreach (var item in _parts)
        {
            item.Show();
        }
    }
}
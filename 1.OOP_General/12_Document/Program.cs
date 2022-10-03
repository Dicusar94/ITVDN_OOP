using _12_Document.Document.Parts;

namespace _12_Document;

static class Program
{
    static void Main()
    {
        var title = new Title
        {
            Content = "Contract title"
        };

        var body = new Body
        {
            Content = "Contract body ..."
        };

        var footer = new Footer
        {
            Content = "Director : Dicusar Denis"
        };

        var document = new Document.Document(title, body, footer);
        document.Show();
    }
}
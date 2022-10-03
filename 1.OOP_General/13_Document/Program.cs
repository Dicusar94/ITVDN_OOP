namespace _13_Document;

static class Program
{
    static void Main()
    {
        var document = new Document.Document("Content Title")
        {
            Body = "Content Body ... ",
            Footer = "Author : Dicusar Denis"
        };

        document.Show();

        var document2 = new Document.Document("No title");
        document2.Show();
    }
}
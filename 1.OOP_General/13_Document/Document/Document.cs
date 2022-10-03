using _13_Document.Document.Parts;
using _13_Document.Document.Parts.Interfaces;

namespace _13_Document.Document;

public class Document
{
    #region fields
    private Title _title = null!;
    private Body _body = null!;
    private Footer _footer = null!;
    #endregion

    #region props
    public string Body { set => _body.Content = value; }
    public string Footer { set => _footer.Content = value; }
    #endregion

    #region ctors
    public Document(string title)
    {
        InitializeDocument();
        _title.Content = title;
    }

    private void InitializeDocument()
    {
        _title = new Title();
        _body = new Body();
        _footer = new Footer();
    }
    #endregion

    #region methods
    public void Show()
    {
        _title.Show();
        _body.Show();
        _footer.Show();
    }
    #endregion
}
namespace _001_Inheritance;

class BaseClass
{
    private string? _className;

    public string publicField = "BaseClass.publicField";
    private readonly string privateField = "BaseClass.privateField";
    protected string protectedField = "BaseClass.protectedField";

    public virtual string ClassName
    {
        get => nameof(BaseClass);
        set => _className = value;
    }
}
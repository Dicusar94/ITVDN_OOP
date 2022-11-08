namespace _001_Inheritance;

class DerivedClass : BaseClass
{
    public DerivedClass()
    {
        publicField = $"{nameof(DerivedClass)}.{nameof(publicField)}";
        protectedField = $"{nameof(DerivedClass)}.{nameof(protectedField)}";
    }

    public override string ClassName { get => nameof(DerivedClass); set => base.ClassName = value; }
}
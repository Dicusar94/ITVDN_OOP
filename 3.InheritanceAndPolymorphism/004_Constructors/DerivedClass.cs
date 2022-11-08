namespace _004_Constructors;

class DerivedClass : BaseClass
{
    public int derivedNumber;

    public DerivedClass(int derivedNumber)
    {
        this.derivedNumber = derivedNumber;
    }

    public DerivedClass(int derivedNumber, int baseNumber) : base(baseNumber)
    {
    }

    public int GetNumberSum()
    {
        return derivedNumber + baseNumber;
    }
}
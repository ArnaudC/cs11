namespace CS11;

class ClassWithTypeGenericAttribute {
    [TypeGenericAttribute(typeof(int))] // old in C# 10
    [GenericAttributeCS11<int>()] // new in C# 11
    public int Method(int i) => 2 * i;
}

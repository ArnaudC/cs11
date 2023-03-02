namespace CS11;

class ClassWithTypeGenericAttribute {
    [TypeGenericAttribute(typeof(int))]
    public int Method(int i) => 2 * i;
}

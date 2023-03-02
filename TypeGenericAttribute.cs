namespace CS11;

class TypeGenericAttribute : Attribute {
    public TypeGenericAttribute(Type type) {
        ParamType = type;
    }

    public Type ParamType { get; }
}

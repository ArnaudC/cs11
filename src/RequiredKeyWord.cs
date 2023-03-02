namespace CS11;

class RequiredKeyWord {
    private int x;
    public required int XProperty { get => x; set => x = value; }
}


class NotRequiredKeyWord {
    public int x;
}

namespace CS11;


file class FileLocalTypes {
    private int x;
    public required int XProperty { get => x; set => x = value; }
}


file class CustomClass : FileLocalTypes {
    public CustomClass() {
        XProperty = 1;
    }
}


file interface IWidget
{
    int ProvideAnswer();
}

file class HiddenWidget
{
    public int Work() => 42;
}

public class Widget : IWidget
{
    public int ProvideAnswer()
    {
        var worker = new HiddenWidget();
        return worker.Work();
    }
}

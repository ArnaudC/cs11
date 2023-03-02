namespace CS11;

class RefOnFieldsAndScopedVariables
{
    private int x = 1;

    // field
    public ref int XProperty { get => ref x; }

    public void RandomizeX()
    {
        x = new System.Random().Next();
    }
}

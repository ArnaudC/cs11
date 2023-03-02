namespace CS11;


interface GenericMathSupportInterface {
    public abstract int Add(int a, int b);

    public static virtual int Subtract(int a, int b) => a - b;
}

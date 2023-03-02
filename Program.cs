using System.Text;
using CS11;


// Generic attributes
var classWithTypeGenericAttribute = new ClassWithTypeGenericAttribute();
Console.WriteLine("test");
Console.WriteLine(classWithTypeGenericAttribute.Method(2));

// Generic math support
var mathSupportClass = new MathSupportClass();
int res1 = mathSupportClass.Add(1, 2);
Console.WriteLine($"methSupportClass .Add: {res1}");

// unsigned shift operator
Console.WriteLine($"11 >>> 2: {11 >>> 2}");

// Newlines in string interpolations
int i = -1;
string s = $"i is {
    i switch
    {
        >= 1 => "positive",
        <= -1 => "negative",
        _ => "zero",
    }
}";
Console.WriteLine(s);


// Raw string literals
string s2 = """
    Raw string literals
""";
Console.WriteLine(s2);
int Longitude = 10, Latitude = 20;
var location = $$"""
   You are at {{{Longitude}}, {{Latitude}}}
""";
Console.WriteLine(location);

// List patterns
var sequence = new List<int> { 1, 2, 3, 7, 8};
bool isSequenceEquals1 = sequence is [1, 2, 3];
bool isSequenceEquals2 = sequence is [1, 2, 3, 7, 8];
bool isSequenceEquals3 = sequence is [1, .., 8]; // .. matches any sequence of zero or more elements
bool isSequenceEquals4 = sequence is [1, 2, 3, _, 8]; // _ matches any single element
Console.WriteLine($"isSequenceEquals1: {isSequenceEquals1}, isSequenceEquals2: {isSequenceEquals2}, isSequenceEquals3: {isSequenceEquals3}, isSequenceEquals4: {isSequenceEquals4}");

// Improved method group conversion to delegate

// Auto-default struct
var m1 = new Measurement(5);
Console.WriteLine(m1);  // output: 5 (Ordinary measurement)
var m2 = new Measurement();
Console.WriteLine(m2);  // output: 0 ()
var m3 = default(Measurement);
Console.WriteLine(m3);  // output: 0 ()

// Pattern match Span<char> or ReadOnlySpan<char> on a constant string
static bool Is123(ReadOnlySpan<char> s)
{
    return s is "123";
}
static bool IsABC(Span<char> s)
{
    return s switch { "ABC" => true, _ => false };
}
Console.WriteLine("Is123(\"123\"): {0}", Is123("123"));
char[] sa = "ABC".ToCharArray();
var sp = sa.AsSpan();
Console.WriteLine("IsABC(\"ABC\"): {0}", IsABC(sp));

// UTF-8 string literals
var utf8string = "hello"u8;
var bytes = utf8string.ToArray();
string myString = Encoding.UTF8.GetString(bytes);
Console.WriteLine(myString);

// required keyword
var requiredKeyWord = new RequiredKeyWord() { XProperty = 1 };
var notRequiredKeyWord = new NotRequiredKeyWord();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// unsigned integer means positive whole number including 0
uint naturalNumber = 23;

// integer means negative or positive whole number including 0
int integerNumber = -23;

// float means single-precision floating point 
// F suffix makes it a float literal
float realNumber = 2.3F;

// double means double-precision floating point number
double anotherRealNumber = 2.3;     // double literal

Console.WriteLine($"{nameof(naturalNumber)} = {naturalNumber}");
Console.WriteLine($"{nameof(integerNumber)} = {integerNumber}");
Console.WriteLine($"{nameof(realNumber)} = {realNumber}");
Console.WriteLine($"{nameof(anotherRealNumber)} = {anotherRealNumber}");
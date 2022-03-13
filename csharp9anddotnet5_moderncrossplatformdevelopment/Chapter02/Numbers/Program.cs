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

Console.WriteLine($"sbyte uses {sizeof(sbyte)} bytes and can store numbers in the range {sbyte.MinValue:N0} to {sbyte.MaxValue:N0}");
Console.WriteLine($"byte uses {sizeof(byte)} bytes and can store numbers in the range {byte.MinValue:N0} to {byte.MaxValue:N0}");
Console.WriteLine($"short uses {sizeof(short)} bytes and can store numbers in the range {short.MinValue:N0} to {short.MaxValue:N0}");
Console.WriteLine($"ushort uses {sizeof(ushort)} bytes and can store numbers in the range {ushort.MinValue:N0} to {ushort.MaxValue:N0}");
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers in the range {uint.MinValue:N0} to {uint.MaxValue:N0}");
Console.WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range {long.MinValue:N0} to {long.MaxValue:N0}");
Console.WriteLine($"ulong uses {sizeof(ulong)} bytes and can store numbers in the range {ulong.MinValue:N0} to {ulong.MaxValue:N0}");
Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range {float.MinValue:E} to {float.MaxValue:E}");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:E} to {double.MaxValue:E}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

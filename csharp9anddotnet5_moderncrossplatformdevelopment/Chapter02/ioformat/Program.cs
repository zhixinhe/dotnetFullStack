// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Type your first name and press ENTER: ");
string firstName = Console.ReadLine();
Console.Write("Type your age and press ENTER: ");
string age = Console.ReadLine();

Console.WriteLine(
    format: "{0:-10} {1:6}",
    arg0: "First Name",
    arg1: "Age"
);
Console.WriteLine(
    format: "{0:-10} {1:6}",
    arg0: firstName,
    arg1: age
);

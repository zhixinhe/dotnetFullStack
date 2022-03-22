using Hzx.Shared;
using static System.Console;

namespace Program
{
    class Program 
    {
        public static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 12);
            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Man { Name = "Zoe" });
            WriteLine(bob.ToString());
            WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
                      arg0: bob.Name,
                      arg1: bob.DateOfBirth);
            WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            //for (int child = 0; child < bob.Children.Count; child++)
            foreach ( Person child in bob.Children )
            {
                WriteLine($"    {child.Name}");
                child.Introduce();
            }
        }
    }
}


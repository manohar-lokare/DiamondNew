
using DiamondKataNew;

Console.WriteLine("Please enter a Character from A to Z");
while (true)
{
    var input = Console.ReadLine();
    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    else
    {
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");

        var diamond = Diamond.Create(inputChar);
        Console.WriteLine(diamond);
    }
}




using DiamondKataNew;

Console.WriteLine("Please enter a Character from A to Z");

        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");

        var diamond = Diamond.Create(inputChar);
        Console.WriteLine(diamond);



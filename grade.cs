using System;

namespace grading{
public class Program
{
    static void Main()
    {
        Console.Write("Enter a letter: ");
        char letter = char.ToUpper(Console.ReadKey().KeyChar);

        string carModel;

        switch (letter)
        {
            case 'T':
                carModel = "Toyota";
                break;
            case 'M':
                carModel = "Mercedes";
                break;
            case 'R':
                carModel = "Range Rover";
                break;
            case 'L':
                carModel = "Lexus";
                break;
            default:
                carModel = "Car not in the database";
                break;
        }

        Console.WriteLine($"\nCar Model: {carModel}");
    }
}
}

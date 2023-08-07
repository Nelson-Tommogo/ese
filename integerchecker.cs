using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 9 == 0)
        {
            Console.WriteLine($"{number} is evenly divisible by 9.");
        }
        else
        {
            Console.WriteLine($"{number} is not evenly divisible by 9.");
        }
    }
}

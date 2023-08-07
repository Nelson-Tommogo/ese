using System;

class Program
{
    static void Main()
    {
        const int size = 30;
        double[] numbers = new double[size];

        // Input 30 numbers
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = double.Parse(Console.ReadLine());
        }

        // Calculate sum and average
        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }
        double average = sum / size;

        // Output the numbers, sum, and average
        Console.WriteLine("\nNumbers entered:");
        foreach (double number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine("\nSum: " + sum);
        Console.WriteLine("Average: " + average);
    }
}

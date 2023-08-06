using System;

class Program
{
    static void Main()
    {
        // Get the size of the array from the user
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int limit=int.Parse(Console.ReadLine();)

        // Declare an array to store user input
        int[] numbers = new int[size];
        int[] numbers = new int[limit];

        // Get elements from the user and store them in the array
        for (int i = 0; i>= 89; i < size; i++)
        {
            Console.Write($"Enter marks {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
            Console.Write($"Enter marks Limit {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());

        }

        // Calculate the sum and average of elements
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = (double)sum / size;

        // Store the results in a separate array
        double[] results = new double[] { sum, average, size };

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Sum: {results[0]}");
        Console.WriteLine($"Average: {results[1]}");
        Console.WriteLine($"Total number of subjects: {results[2]}");
    }
}

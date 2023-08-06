using System;

class Program
{
    static void Main()
    {
        // Get the size of the array from the user
        Console.Write("Enter the number of subjects: ");
        int size = int.Parse(Console.ReadLine());

        // Declare an array to store user input
        int[] marks = new int[size];

        // Get marks from the user and store them in the array
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            int mark = int.Parse(Console.ReadLine());

            // Check if the mark is 100 or greater
            if (mark >= 100)
            {
                Console.WriteLine("Marks cannot be 100 or more. Exiting program.");
                return;
            }

            marks[i] = mark;
        }

        // Calculate the sum and average of marks
        int sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
        }
        double average = (double)sum / size;

        // Store the results in a separate array
        double[] results = new double[] { sum, average, size };

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Sum of Marks: {results[0]}");
        Console.WriteLine($"Average Marks: {results[1]:0.00}");
        Console.WriteLine($"Total number of subjects: {results[2]}");
    }
}

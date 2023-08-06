using System;

class Program
{
    static void Main()
    {
        // Single-Dimensional Array
        int[] singleArray = new int[5]; // Creating a single-dimensional array with 5 elements
        Console.WriteLine("Single-Dimensional Array:");

        for (int i = 0; i < singleArray.Length; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            singleArray[i] = int.Parse(Console.ReadLine());
        }

        // Displaying the elements of the single-dimensional array
        Console.WriteLine("\nElements of the Single-Dimensional Array:");
        foreach (int num in singleArray)
        {
            Console.Write($"{num} ");
        }

        // Multi-Dimensional Array
        int[,] multiArray = new int[3, 3]; // Creating a two-dimensional array with 3 rows and 3 columns
        Console.WriteLine("\n\nMulti-Dimensional Array:");

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Enter element at [{row},{col}]: ");
                multiArray[row, col] = int.Parse(Console.ReadLine());
            }
        }

        // Displaying the elements of the multi-dimensional array
        Console.WriteLine("\nElements of the Multi-Dimensional Array:");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"{multiArray[row, col]} ");
            }
            Console.WriteLine();
        }

        // Jagged Array
        int[][] jaggedArray = new int[3][]; // Creating a jagged array with 3 rows

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write($"Enter the number of elements for row {i + 1}: ");
            int size = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[size];

            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Enter element {j + 1}: ");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Displaying the elements of the jagged array
        Console.WriteLine("\nElements of the Jagged Array:");
        foreach (int[] row in jaggedArray)
        {
            foreach (int num in row)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}

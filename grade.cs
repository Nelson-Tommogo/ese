using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks for Subject 1: ");
        int subject1 = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        int subject2 = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        int subject3 = int.Parse(Console.ReadLine());

        double average = (subject1 + subject2 + subject3) / 3.0;

        string grade;
        if (average >= 70)
        {
            grade = "A";
        }
        else if (average >= 60)
        {
            grade = "B";
        }
        else if (average >= 50)
        {
            grade = "C";
        }
        else if (average >= 40)
        {
            grade = "D";
        }
        else
        {
            grade = "E";
        }

        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Grade: {grade}");
    }
}

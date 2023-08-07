using System;

namespace trialmeth
{
    public static class TrialClass
    {
        public static float ComputeSum()
        {
            float a = 6.6f;
            float b = 67.1f;
            float c = 0.6f;
            float e = 9.1f;

            float sum = a + b + c + e;
            return sum;
        }
    }

    public class Program // Separate class for Main method
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calling the ComputeSum method:");
            float result = TrialClass.ComputeSum();
            Console.WriteLine("Sum: " + result);
        }
    }
}

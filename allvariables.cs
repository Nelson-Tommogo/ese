using System;

namespace VariableTypesProgram
{
    class Program
    {
        // Instance variable
        int instanceVar = 10;

        // Static variable
        static int staticVar = 20;

        // Constant variable
        const int constantVar = 30;

        // Readonly variable
        readonly int readOnlyVar;

        public Program()
        {
            // Readonly variable can only be assigned in the constructor
            readOnlyVar = 40;
        }

        void LocalVariableMethod()
        {
            // Local variable
            int localVar = 50;
            Console.WriteLine("Local Variable: " + localVar);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            // Accessing instance variable
            Console.WriteLine("Instance Variable: " + obj.instanceVar);

            // Accessing static variable
            Console.WriteLine("Static Variable: " + staticVar);

            // Accessing constant variable
            Console.WriteLine("Constant Variable: " + constantVar);

            // Accessing readonly variable
            Console.WriteLine("Readonly Variable: " + obj.readOnlyVar);

            // Accessing local variable from method
            obj.LocalVariableMethod();
        }
    }
}

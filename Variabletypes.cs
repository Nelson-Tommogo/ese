using System;

namespace VariableTypesDemo
{
    class MyClass
    {
        // Instance variable
        int instanceVar;

        // Static variable
        static int staticVar;

        // Constant variable
        const int constantVar = 10;

        // Readonly variable
        readonly int readonlyVar;

        public MyClass(int value)
        {
            // Assign value to readonly variable in the constructor
            readonlyVar = value;
        }

        public void LocalVariableExample()
        {
            // Local variable
            int localVar = 5;

            Console.WriteLine("Instance Variable: " + instanceVar);
            Console.WriteLine("Static Variable: " + staticVar);
            Console.WriteLine("Constant Variable: " + constantVar);
            Console.WriteLine("Readonly Variable: " + readonlyVar);
            Console.WriteLine("Local Variable: " + localVar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(15);
            MyClass obj2 = new MyClass(20);

            // Modify static variable value using class name
            MyClass.staticVar = 100;

            Console.WriteLine("Object 1:");
            obj1.LocalVariableExample();

            Console.WriteLine("\nObject 2:");
            obj2.LocalVariableExample();
        }
    }
}

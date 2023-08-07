using System;

namespace AccessSpecifiers
{
    class Student
    {
        // Private fields (encapsulation)
        private string id;
        private string name;
        private string email;

        // Public properties with get and set accessors
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // Setting values to the properties
             student.ID = "D045";
            student.Name = "Common Genius";
            student.Email = "nelsontommogo9@gmail.com";
            // getting values
            Console.WriteLine("ID = " + student.ID);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);
        }
    }
}

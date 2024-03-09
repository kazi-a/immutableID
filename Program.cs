using System;

namespace immutableID
{
    class Student
    {
        // properties with the ID set accessor set to init
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }

        // Parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }

        // Parameterized constructor accepting ID only
        public Student(int i)
        {
            Id = i;
            FirstName = "";
            LastName = "";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Student object using the new constructor and pass it an ID
            Student student1 = new Student(1);
            student1.FirstName = "John";
            student1.LastName = "Doe";

            // Create a second Student object using the parameterized constructor
            Student student2 = new Student(2, "Jane", "Smith");

            // Print out the values from both objects
            Console.WriteLine("Student 1:");
            Console.WriteLine($"ID: {student1.Id}");
            Console.WriteLine($"First Name: {student1.FirstName}");
            Console.WriteLine($"Last Name: {student1.LastName}");
            Console.WriteLine();

            Console.WriteLine("Student 2:");
            Console.WriteLine($"ID: {student2.Id}");
            Console.WriteLine($"First Name: {student2.FirstName}");
            Console.WriteLine($"Last Name: {student2.LastName}");
        }
    }
}

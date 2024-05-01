using System;

// Define the namespace for the application
namespace AbstractClassDemo
{
    // Define an interface called IQuittable
    public interface IQuittable
    {
        // Method signature for Quit, which is to be implemented by any class that inherits this interface
        void Quit();
    }

    // Define an abstract class called Person
    public abstract class Person
    {
        // Public properties for first and last names
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method SayName to be implemented by any derived classes
        public abstract void SayName();
    }

    // Define a class Employee that inherits from Person and implements IQuittable interface
    public class Employee : Person, IQuittable
    {
        // Implement the SayName method to display the full name of the employee
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has decided to quit the job.");
        }
    }

    // Main class where the program execution starts
    class Program
    {
        // Main method - the entry point of the application
        static void Main(string[] args)
        {
            // Instantiate an Employee object and initialize it
            Employee emp = new Employee() { firstName = "Sample", lastName = "Student" };

            // Call the SayName method on the Employee object
            emp.SayName();

            // Create an IQuittable reference to the Employee object using polymorphism
            IQuittable quittableEmp = emp;

            // Call the Quit method using the IQuittable reference
            quittableEmp.Quit();

            // Prevent the console from closing immediately
            Console.ReadLine();
        }
    }
}

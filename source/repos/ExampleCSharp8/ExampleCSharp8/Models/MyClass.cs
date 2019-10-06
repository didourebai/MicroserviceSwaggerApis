using System;
using ExampleCSharp8.Interfaces;

namespace ExampleCSharp8.Models
{
    public class MyClass : InterfaceA
    {
        public void OperationA()
        {
            Console.WriteLine("This is implemented inside the class!");
        }

        public void OperationB(string message)
        {
            Console.WriteLine(message);
        }
    }
}

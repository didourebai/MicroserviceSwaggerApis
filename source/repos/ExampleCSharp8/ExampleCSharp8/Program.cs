using ExampleCSharp8.Interfaces;
using ExampleCSharp8.Models;
using System;

namespace ExampleCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            CallClass();
            Console.ReadLine();
        }

        public static void CallClass()
        {
            InterfaceA myClass = new MyClass();
            myClass.OperationA();
            myClass.OperationB("This is implemented in OperationB");
            myClass.OperationC("This is implemented inside the interface.");
            myClass.OperationD("this is inside the interface");
        }
    }
}

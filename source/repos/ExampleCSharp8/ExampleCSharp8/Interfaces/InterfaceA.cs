using System;

namespace ExampleCSharp8.Interfaces
{
    interface InterfaceA
    {
        void OperationA();
        void OperationB(string message);

        void OperationC(string message)
        {
            Console.WriteLine(message);
        }

        void OperationD(string message) => OperationB(message);

    }
}

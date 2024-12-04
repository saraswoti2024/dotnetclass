using System;

// Define a delegate
//helps to call a method indirectly
// That means, a delegate holds the address of a method which can be called using that delegate.
public delegate void Operation(string message); //return type same hunu parxa delegate rw point gareko function ko

internal class Program
{

    static void Main(string[] args)
    {
        Operation operation = new Operation(MyFunc); //always takes function while using delegate
        Operation operation2 = new Operation(MyFunc2);
        operation("Hello"); //Invocation
        operation2("Hi");
    }
    // Method that takes a delegate as parameter
    public static void MyFunc(string message)
    {
        Console.WriteLine(message);
    }

    public static void MyFunc2(string message)
    {
        Console.WriteLine(message);
    }
}
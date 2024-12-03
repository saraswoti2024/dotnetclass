//using System;
//using System.Data;

//namespace staticclass
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int sum = MathUtilities.Add(3, 5);
//            int factorial = MathUtilities.Factorial(5);
//            Console.WriteLine($"sum:{sum}");
//            Console.WriteLine($"Factorial of 5: {factorial}");
//        }
//        public static class MathUtilities
//        {
//            public static int Add(int a, int b)
//            {
//                return a + b;
//            }
//            public static int Factorial(int number)
//            {
//                if (number <= 1) return 1;
//                return number * Factorial(number - 1);
//            }
//        }
//    }
//}


//example
// C# program to illustrate the concept of static class
using System;

namespace ExampleOfStaticClass
{

    // Creating static class
    // Using static keyword
    static class Author
    {

        // Static data members of Author
        public static string A_name = "Ankita";
        public static string L_name = "CSharp";
        public static int T_no = 84;

        // Static method of Author
        public static void details()
        {
            Console.WriteLine("The details of Author is:");
        }
    }

    // Driver Class
    public class GFG
    {

        // Main Method
        static public void Main()
        {

            // Calling static method of Author
            Author.details();

            // Accessing the static data members of Author
            Console.WriteLine("Author name : {0} ", Author.A_name);
            Console.WriteLine("Language : {0} ", Author.L_name);
            Console.WriteLine("Total number of articles : {0} ",
                                                Author.T_no);
        }
    }
}


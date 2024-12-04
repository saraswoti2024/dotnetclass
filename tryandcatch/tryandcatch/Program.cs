using System;

namespace TryCatch
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = Divide(10, 1);
                Console.WriteLine($"Result of division: {result}");
                int[] a = { 1, 2, 3, 4 };
                Console.WriteLine(a[6]); //yesto error lai bound checking vanxa
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
               
            }
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // throw ex;
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.WriteLine("Program continues after try-catch-finally block.");
        }

        static int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                // Manually throwing an exception
                throw new DivideByZeroException();
            }
            else
            {
                return numerator / denominator;
            }
        }
    }
}
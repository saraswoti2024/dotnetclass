using System;

namespace Stringss
{
    public static class Program
    {
        static void Main(string[] args)
        {
            ////Character Conversion
            //string s = "Hello";
            //Console.WriteLine(s.ToUpper());  // Output: "HELLO"
            //Console.WriteLine(s.ToLower());
            //string a = "sara";
            //Console.WriteLine(a.ToUpper());// Output: "hello"

            ////String Concatenation
            //string str1 = "Hello";
            //string str2 = "World";
            //int str3 = 12;
            ////string result = str1 + " " + str2;  // Output: "Hello World"
            ////Console.WriteLine(result);

            //string result2 = string.Concat(str1," ", str2," ", str3);  // Output: "Hello World"
            //Console.WriteLine(result2);

            ////String Interpolation
            string name = "Alice";
            int age = 30;
            string message = $"My name is {name} and I am {age} years old.";
            string what = $"saraswoti is {name}'s bestfriend";
            Console.WriteLine(message);  // Output: "My name is Alice and I am 30 years old."
            Console.WriteLine(what);

            string firstname = "sara";
            string lastname = "khadka";
                Console.WriteLine($"firstname: {firstname} \n lastname : {lastname} ");
               }
    }
}
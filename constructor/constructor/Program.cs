using System;

namespace constructor
{
 public class Person
    {
        public string Name;
        public int Age;
        public static string category;

        //creating constructor / no return type in constructor
        public Person()
        {
            Name = "unknown";
            Age = 22;
        }

        //parameterized constructor
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        //copy constructor
        public Person (Person p)
        {
            Name = p.Name;
            Age = p.Age;
        }

        //static constructor
        static Person()
        {
            category = "Human";
        }
        //private constructor(used within class only)
        private Person(int age, string name)
        {
            Name = name;
            Age = age;
        }

        //factory method to create an object using the private constructor
        public static Person CreateSpecialPerson(int age,string name)
        {
            return new Person(age, name);
        }

        public void DisplayInfo() {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Categori: { category} ");
        }
    }
 
    public class Program
    {
        public static void Main()
        {
            Person p1 = new Person(); //default constructor
            p1.DisplayInfo();

            Person p2 = new Person("john",30);
            p2.DisplayInfo();

            Person p3 = new Person(p2);
            p3.DisplayInfo();

            Console.WriteLine($"Category from static constructor: {Person.category}");

            Person p4 = Person.CreateSpecialPerson(100, "Special");
            p4.DisplayInfo();
        }
    }
}

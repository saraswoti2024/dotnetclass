using System;

namespace partialclass  //aautai class lai 3,4 oota part ma tukryako ani tahi ma continue garna milxa
    //compile time mai compiled hunxa partial class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of the partial class
            MyClass myInstance = new MyClass();


            myInstance.Method1();
            myInstance.Method2();
        }
    }
}

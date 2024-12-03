using System;

namespace Test.Accessmodifier
{
    public class AccessModifierDemo
    {
        //jun class lae ni access garna payo
        public int publicmember { get; set; }

        //private ma same class only access
        private string PrivateMember { get; set; }

        //inheritated walal class haru lae access garna payo
        protected double ProtectedMember { get; set; }

        //same folder,project,library vitrw access garna milxa
        internal bool InternalMember { get; set; }

        protected internal DateTime ProtectedInternalMember { get; set; }

        private protected string PrivateProtectedMember { get; set; }
        public int PublicMember { get; private set; }

        public AccessModifierDemo()
        {
            ProtectedMember = 3.14;
            ProtectedInternalMember = DateTime.Now;
            PrivateMember = "private Data";
            PublicMember = 42;
            PrivateProtectedMember = "Restricted Access";
            InternalMember = true;
        }

        public void DisplayPublicData()
        {
            Console.WriteLine($"Public Member: {PublicMember}");
        }

        private void DisplayPrivateData()
        {
            Console.WriteLine($"Private Member: {PrivateMember}");
        }
        protected void DisplayProtectedData()
        {
            Console.WriteLine($"Protected Member:{ProtectedMember}");
        }
    }
    
        class Program
        {
            static void Main(string[] args)
            {
                AccessModifierDemo demo = new AccessModifierDemo();
                demo.DisplayPublicData();
                //demo.DisplayProtectedData();
                //demo.DisplayPrivateData();
                //demo.DisplayProtectedData();
            }
        }

 
}

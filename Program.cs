using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration validateUser = new Registration();
            validateUser.validateFirstName("Chandana");
            Console.WriteLine("--------------------------------------");
            validateUser.validateLastName("Reddy");
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
        }
    }
}
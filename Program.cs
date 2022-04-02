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
            validateUser.validateEmailId("chandana@gmail.com");
            Console.WriteLine("--------------------------------------");
            validateUser.validateMobileNumber("917893338629");
            Console.WriteLine("--------------------------------------");
            validateUser.validatePassword("chandu");
            Console.WriteLine("--------------------------------------");
            validateUser.validateUpperCasePassword("Chandana");
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
        }
    }
}
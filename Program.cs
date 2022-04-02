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
            validateUser.validateEmailId("chandanareshma@gmail.com");
            Console.WriteLine("---------------------------------------");
            validateUser.validateMobileNumber("7893338629");
            Console.WriteLine("---------------------------------------");
            validateUser.validatePassword("chandu123");
            Console.WriteLine("---------------------------------------");
            validateUser.validateUperCasePassword("Chandu123");
            Console.WriteLine("---------------------------------------");
            validateUser.validateNumericPassword("Chandu@123");
            Console.WriteLine("---------------------------------------");

            Console.ReadKey();
        }
    }
}
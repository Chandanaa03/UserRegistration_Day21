using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Registration
    {
        public void validateFirstName(string firstName)
        {
            string stringForFirstName = "^[A-Z][a-z]{3,}?";
            try
            {

                if (Regex.IsMatch(firstName, stringForFirstName))
                    Console.WriteLine(firstName + " is Valid");

                else
                    Console.WriteLine(firstName + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void validateLastName(string lastName)
        {
            string stringForLastName = "^[A-Z][a-z]{3,}?";
            try
            {


                if (Regex.IsMatch(lastName, stringForLastName))
                    Console.WriteLine(lastName + " is Valid");
                else
                    Console.WriteLine(lastName + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void validateEmailId(string emailID)
        {
            string stringForEmailId = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$";
            try
            {

                if (Regex.IsMatch(emailID, stringForEmailId))
                    Console.WriteLine(emailID + " is Valid");
                else
                    Console.WriteLine(emailID + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void validateMobileNumber(string mobileNumber)
        {
            string stringForMobileNumber = "^[0-9]{10}";
            try
            {

                if (Regex.IsMatch(mobileNumber, stringForMobileNumber))
                    Console.WriteLine(mobileNumber + " is Valid");
                else
                    Console.WriteLine(mobileNumber + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Rule:1
        public void validatePassword(string password)
        {
            string stringForPassword = "^.{8,}?";
            try
            {
                if (Regex.IsMatch(password, stringForPassword))
                    Console.WriteLine(password + " is Valid");
                else
                    Console.WriteLine(password + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Rule:2
        public void validateUpperCasePassword(string UCPassword)
        {
            string stringForUCPassword = "^[A-Z]+.{8,}?";
            try
            {
                if (Regex.IsMatch(UCPassword, stringForUCPassword))
                    Console.WriteLine(UCPassword + " is Valid");
                else
                    Console.WriteLine(UCPassword + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void validateNumericPassword(string NumericPassword)
        {
            try
            {
                string stringForNumericPassword = "^.{8,}?";
                if (Regex.IsMatch(NumericPassword, stringForNumericPassword))
                    Console.WriteLine(NumericPassword + " is Valid");
                else
                    Console.WriteLine(NumericPassword + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void validateSpecialCharacter(string SpecialCharacter)
        {
            try
            {
                string stringForNumericPassword = "^(?=.*[a-z])(?=.*[A-Z])(?=.*)(?=.*[^a-zA-Z]).{8,15}$";
                if (Regex.IsMatch(SpecialCharacter, stringForNumericPassword))
                    Console.WriteLine(SpecialCharacter + " is Valid");
                else
                    Console.WriteLine(SpecialCharacter + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
      
      
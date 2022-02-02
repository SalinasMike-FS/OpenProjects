using System;
//Mike Salinas
//30 Jan 2021
//APA
//API project
namespace API
{
    public class Validation
    {
        private static string _stringNumber;
        private static string _userChoice;
        private static int _number = 0;
        public static int Integer(string _stringNumber)
        {

            while (!int.TryParse(_stringNumber, out _number)) //validate
            {
                //alert the user to the error
                Console.WriteLine("Please only type in positive numbers and do not leave blank! \r\n ");
                _stringNumber = Console.ReadLine();
            }


            return _number;
        }

        public static string BlankSpace(string _userChoice)
        {
            while (string.IsNullOrWhiteSpace(_userChoice)) //
            {
                Console.WriteLine("Please do not leave blank.");
                _userChoice = Console.ReadLine(); //re-prompt
            }

            return _userChoice;
        }
    }
}

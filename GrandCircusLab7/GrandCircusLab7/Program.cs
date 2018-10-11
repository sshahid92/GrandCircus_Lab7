using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GrandCircusLab7
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckIfValid("Enter your name (Example: Mohammad).", @"^[A-Z][a-z]{1,30}$", "Name is valid!", "Sorry, name is not valid!");
            CheckIfValid("Enter your email (example@myhost.com).", @"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z]{2,3}$", "Email is valid!", "Sorry, email is not valid!");
            CheckIfValid("Enter your phone number(Example: (313)-333-4455).", @"\(?\d{3}\) *?-? *\d{3} *-? *-?\d{4}", "Phone number is valid!", "Sorry, phone number is not valid!");
            CheckIfValid("Enter a date. (Example: dd/mm/yyyy)", @"^([0-2][0-9]|(3)[0-1]|[1-9]{1})(\/|-)([1-9]{1}|(1)[0-2])(\/|-)(\d{4})$", "Date is valid!", "Sorry, date is not valid!");
            CheckIfValid("Enter an HTML element. (Example: <p> </p>)", @"(<(\s*[\w+]*)>)*(\s)*(<\/(\s*[\w+]*)>)", "HTML element in valid!", "Sorry, not a valid HTML element!");
        }

        private static string CheckIfValid(string prompt, string regex, string success, string fail)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                bool validate = Regex.IsMatch(input, regex);
                if (validate == true)
                {
                    Console.WriteLine(success);
                    return input;
                }
                else
                {
                    Console.WriteLine(fail);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXDemo
{
    public class Pattern
    {
        public static string Regex_Pattern = "[A-Z]{1}[a-z]{2,}";
        public bool validatePincode(string Pincode)
        {
            return Regex.IsMatch(Pincode, Regex_Pattern);
        }
    }
    public class REGEX
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter First Name");
            string Pincode = Console.ReadLine();

            Pattern pattern = new Pattern();
            Console.WriteLine("....................................");
            if (pattern.validatePincode(Pincode))
                Console.WriteLine("WelCome {0}",Pincode);
            else
                Console.WriteLine("Enter Valid Name");
        }
    }
}

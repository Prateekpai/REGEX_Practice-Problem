using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXDemo
{
    public class Pattern
    {
        public static string Regex_Pattern = "[0-9]{2}(.)[0-9]{10}";
        public bool validatePincode(string Pincode)
        {
            return Regex.IsMatch(Pincode, Regex_Pattern);
        }
    }
    public class REGEX
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Valid Mobile Number along with Country Code");
            string Pincode = Console.ReadLine();

            Pattern pattern = new Pattern();
            Console.WriteLine("....................................");
            if (pattern.validatePincode(Pincode))
                Console.WriteLine("Your Mobile Number {0} has been saved ", Pincode);
            else
                Console.WriteLine("Enter Valid Mobile Number");
        }
    }
}

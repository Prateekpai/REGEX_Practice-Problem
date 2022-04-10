using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXDemo
{
    public class Pattern
    {
        public static string Regex_Pattern = "[a-z]{3}(.)[a-z]{3}(@)[a-z]{2}(.)[a-z]{2}(.)[a-z]{2}";
        public bool validatePincode(string Pincode)
        {
            return Regex.IsMatch(Pincode, Regex_Pattern);
        }
    }
    public class REGEX
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Valid Email");
            string Pincode = Console.ReadLine();

            Pattern pattern = new Pattern();
            Console.WriteLine("....................................");
            if (pattern.validatePincode(Pincode))
                Console.WriteLine("Email ID {0} is Saved", Pincode);
            else
                Console.WriteLine("Enter Valid Name");
        }
    }
}

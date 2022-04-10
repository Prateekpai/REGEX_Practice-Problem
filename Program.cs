﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXDemo
{
    public class Pattern
    {
        public static string Regex_Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public bool validatePincode(string Pincode)
        {
            return Regex.IsMatch(Pincode, Regex_Pattern);
        }
    }
    public class REGEX
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Email ");
            string Pincode = Console.ReadLine();

            Pattern pattern = new Pattern();
            Console.WriteLine("....................................");
            if (pattern.validatePincode(Pincode))
                Console.WriteLine("Your Email {0} is saved", Pincode);
            else
                Console.WriteLine("Enter Valid Email");
        }
    }
}

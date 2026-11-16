using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts_And_OOP.Concepts.Extension
{
    // Extension Method:
    // Allows us to add a new method to an existing type
   
    // The extension method must:
    // 1. Be inside a static class.
    // 2. Be a static method.
    // 3. Use the 'this' keyword on the first parameter.

    // This is a new source code for existing type
    public static class NumberExtensions
    {
        // Weather the provided number is a even or not.
        public static bool IsEven(this int num) 
        {
            return num % 2 == 0;
        } 
    }

    public static class StringExtensions 
    {
        // Extends string with a custom method that trims whitespace, and converts it to upper case.
        public static string ToUpperCase(this string text) 
        {
            return text.Trim().ToUpper();
        }
    }
}

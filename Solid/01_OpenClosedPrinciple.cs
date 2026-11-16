using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts_And_OOP.Solid
{
    // O — Open/Closed Principle
    // A class should be open for extension but closed for modification.
    public static class NumberExtensions
    {
        // Extension methods are a good example of the OCP idea because we can extend an
        //  existing type without modifying its source code.
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
    }
}

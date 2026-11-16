using C_Sharp_Concepts.Shared.Model;
using C_Sharp_Concepts_And_OOP.Concepts.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Concepts.Delegates
{
    public class BuiltInDelegate 
    { 
        // Action<T> : Returns void
        Action<Property> updateStatus = property =>
        {
            property.Status = false;
        };

        // Func<T,TResult> : Return a value
        Func<Property, string> propertyName = pro =>
        {
            return pro.PropertyName;
        };

        // Predicate<T> : Returns bool. but it accepts only one parameter
        Predicate<Property> isActive = property => 
        {
            return property.IsDeleted;
        };

    }
}

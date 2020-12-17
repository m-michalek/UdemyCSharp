using System;

namespace NullableObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Does not compile because it is a value type and value types can not be null
            // DateTime date = null;

            // Nullable makes value types nullable
            Nullable<DateTime> date1 = null;
            // Gets the value or the default value for the data type
            Console.WriteLine(date1.GetValueOrDefault());
            
            // A shorter version
            DateTime? date2 = null;
            // Gets the value or the default value for the data type
            Console.WriteLine(date2.GetValueOrDefault());
            
            // Null Coalescing Operator
            DateTime today;

            // This means if not null take date2 else DateTime.Now
            today = date2 ?? DateTime.Now;
            Console.WriteLine(today);
            
            // The Null Coalescing Operator is the same like this but shorter
            if (date2 != null)
            {
                today = date2.GetValueOrDefault();
            }
            else
            {
                today = DateTime.Now;
            }
        }
    }
}
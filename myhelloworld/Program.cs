using System;

namespace myhelloworld
{
    /// <summary>
    /// This is an XML documentation comment
    /// This class performs an important function
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Single line comment test
            /* Multi line 
             * comment
             * block */

            // VARIABLES 
            bool test = true;
            int test1 = 12345;
            double test2 = 3.5423;
            char test3 = 'g';
            string test4 = "Gladys";

            Console.WriteLine($"This is a bool: {test}, an int: {test1}, a double: {test2}, a char: {test3}, a string: {test4}");

            // MIN MAX VALUES 
            int checkMaxValue = int.MaxValue;
            int checkMinValue = int.MinValue;
            // increment will convert it to min value
            checkMaxValue++;

            Console.WriteLine(checkMaxValue);
            Console.WriteLine(checkMinValue);

            // IMPLICIT TYPES 
            var a = false;
            var b = 123;
            var c = 12.54;
            var d = 'e';
            var e = "Hi";

            Console.WriteLine(b.GetType());

            // OPERATORS
            int x = 93;
            int y = 11;
            // only that remains on 93
            int z1 = x++; 
            int z2 = ++y;

            Console.WriteLine($"This is x:{x}, y:{y}, z1:{z1}, z2:{z2}");
        }
    }
}

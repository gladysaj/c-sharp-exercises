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
        }
    }
}

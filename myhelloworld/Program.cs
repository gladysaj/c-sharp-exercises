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
            //bool test = true;
            //int test1 = 12345;
            //double test2 = 3.5423;
            //char test3 = 'g';
            //string test4 = "Gladys";

            //Console.WriteLine($"This is a bool: {test}, an int: {test1}, a double: {test2}, a char: {test3}, a string: {test4}");

            // MIN MAX VALUES 
            //int checkMaxValue = int.MaxValue;
            //int checkMinValue = int.MinValue;
            // increment will convert it to min value
            //checkMaxValue++;

            //Console.WriteLine(checkMaxValue);
            //Console.WriteLine(checkMinValue);

            // IMPLICIT TYPES 
            //var a = false;
            //var b = 123;
            //var c = 12.54;
            //var d = 'e';
            //var e = "Hi";

            //Console.WriteLine(b.GetType());

            // OPERATORS
            //int x = 93;
            //int y = 11;
            // only that remains on 93
            //int z1 = x++; 
            //int z2 = ++y;

            //Console.WriteLine($"This is x:{x}, y:{y}, z1:{z1}, z2:{z2}");

            // Math
            //int num = 23;
            //int num1 = 50;
            //int num2 = 90.32;

            //int f = num + num1;
            //int g = num1 * num2;
            //int h = num2 / num1;

            // Write an expression that returns true if x is even, and false if x is odd. Store the result of the expression in a bool.
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"Number: {num} is even");
            //}
            //else 
            //{
            //    Console.WriteLine($"Number: {num} is odd");
            //}

            // Write an expression that returns false if y is divisible by 3. Store the result of the expression in a bool

            // Write an expression that rounds a double to 3 decimal places and store the result in a double.

            // TYPE CONVERSIONS
            //int x = 34;
            //int y = 89;
            //int z = 45;

            //double a = 23.343;
            //double b = 87.6565;
            //double c = 32.12;

            // Store the integers in the doubles
            //double x1 = x;
            //double y1 = y;
            //double z1 = z;
            //Console.WriteLine($"Integers to doubles: {x1}, {y1}, {z1}");

            // Store the doubles in the integers - this requires a cast operator 
            //int a1 = (int)a;
            //int b1 = (int)b;
            //int c1 = (int)c;
            //Console.WriteLine($"Doubles to integers: {a1}, {b1}, {c1}");

            // STRINGS
            // Create a string with escape sequences in it and print it out
            // Console.WriteLine("This is adding a new line\n escape\t sequence");
            //Console.WriteLine("This is a url: c:\\myFolder\\test");

            // Create a literal string and print it out
            //Console.WriteLine(@"This is a path: c:myFolder\dontNeedDoubleSlash");

            // Concatenation 
            // Concatenate two strings together and print them out
            //string name = "Gladys";
            //string lastName = "Alvarez";
            //Console.WriteLine(name + lastName);

            // Length
            // Print a string along with its length
            //string user = "gladyscodes";
            //int userLength = user.Length;
            //Console.WriteLine($"The length of that word is {userLength}");

            //Indexing 
            // Create a string with length > 3 with an odd number of characters.
            // string hobbies = "boxing";
            // Print the first, middle, and last character, concatenated together.
            // char first = hobbies[0];
            // char middle = hobbies[2];
            // char last = hobbies[hobbies.Length - 1];

            // Console.WriteLine($"First char: {first}, middle char: {middle}, last char: {last}");

            // Changing case 
            // Print a string, the same string in all uppercase, and the same string in all lowercase
            // string name = "Gladys";
            // Console.WriteLine(name.ToUpper());
            // Console.WriteLine(name.ToLower());
        }
    }
}

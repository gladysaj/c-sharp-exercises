using System;

namespace myhelloworld
{
    /// <summary>
    /// This is an XML documentation comment
    /// This class performs an important function
    /// </summary>
    
    // ENUM 
    enum Sports
    {
        Boxing, 
        Gymnastics = 5, 
        Spinning,
        Soccer = 20
    }

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

            // Getting parts of strings 
            /* Create a string with length > 3.
               Print the string with both the first and last characters removed.
               Make sure your code still works if you change the string size.
               Repeat the above exercise using a different string method.*/
            //string animal = "dolphin";
            //string sub1 = animal.Substring(1, animal.Length - 2);
            //string remFirtsLetter = animal.Remove(0,1);
            //string finalWord = remFirtsLetter.Remove(remFirtsLetter.Length -1, 1);
            //Console.WriteLine($"Using Substring() = {sub1}");
            //Console.WriteLine($"Using Remove() = {finalWord}");

            // Searching
            // Declare strings x and char y and initialize them to whatever you like.
            //string x = "coding";
            //char y = 'i';

            // Write an expression that returns the index of the first occurrence of char y in string x
            //int firstIndex = x.IndexOf(y);
            //Console.WriteLine($"First occurrence of char y is: {firstIndex}");

            // Write an expression that returns a bool that represents if y is anywhere in string x
            //bool checkValue = x.Contains(y);
            //Console.WriteLine(checkValue);

            // Create a literal string that holds a fake path to a file (@”c:\foo\bar.txt”, for example).
            //string pathFile = @"Fake path to file c:\foo\bar.txt";
            //Console.WriteLine(pathFile);

            // Write code to get just the file name (no path), without the extension.
            //string[] splitPath = pathFile.Split('c');
            //Console.WriteLine($"Get the file name: {splitPath}");

            // Write code to get just the drive letter, in uppercase.
            //Console.WriteLine(pathFile.ToUpper());

            // SPLITTING 
            // Declare string x and initialize it to whatever you like. 
            //string x = "Enrique";
            // Make sure the string has spaces in it.
            // Split the string on space and observe the results
            // string[] spaces = x.Split(' ');
            // Console.WriteLine(spaces);    

            // FORMATTING 
            // Create a const string x that contains formatting tokens
            //const string x = "I am {0} and I will be joining {1} for the Cohort {2}";

            //const string name = "Gladys";
            //const string company = "Microsoft";
            //const int number = 23;
            // Create another string y that uses string.Format to insert values into string x
            //string y = string.Format(x, name, company, number);
            // Print string y
            //Console.WriteLine(y);
            // Create a double d and initialize it to a number with > 2 decimal places.
            //double d = 93.11;
            // Print the double, but only include 2 decimals when printing


            // PRINTING AND PARSING 
            // Create bool a, int b, double c, and char d, and initialize them to whatever you want (other than default values).
            //bool a = true;
            //int b = 123;
            //double c = 11.93;
            //char d = 'g';
            // Convert these types to strings w, x, y, and z.
            //string w = a.ToString();
            //string x = b.ToString();
            //string y = c.ToString();
            //string z = d.ToString();
            //Console.WriteLine($"Using ToString() = {w}, {x}, {y}, {z} ");
            // Create bool e, int f, double g, and char h. Use the appropriate Parse() method to initialize these variables from the strings w, x, y, and z.
            //bool e = bool.Parse(w);
            //int f = int.Parse(x);
            //double g =  double.Parse(y);
            //char h = char.Parse(z);
            //Console.WriteLine($"Using Parse() = {e}, {f}, {g}, {h}");

            // ENUMS 
            // Create an enum inside the HelloWorld namespace, but outside of the Program class
            //Call the enum whatever you like, populate it with whatever names and values you like
            // Declare a variable and assign it to one of the enum values.
            // Using the variable, print both the enum name AND the enum value
            //var favoriteSport = Sports.Boxing;
            //Console.WriteLine($"{favoriteSport}");

            // Convert the enum to int
            //var secondSport = Sports.Gymnastics;
            //int secondSportAsInteger = (int) secondSport;
            //Console.WriteLine($"{secondSportAsInteger}");


        }
    }
}

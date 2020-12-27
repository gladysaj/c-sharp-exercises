using System;

namespace myhelloworld
{
    /// <summary>
    /// This is an XML documentation comment
    /// This class performs an important function
    /// </summary>

    // ENUM 
    //enum Sports
    //{
    //    Boxing, 
    //    Gymnastics = 5, 
    //    Spinning,
    //    Soccer = 20
    //}

    //enum Food
    //{
    //    Chinese,
    //    Mexican,
    //    Thai
    //}

    // STRUCTS
    //public struct Books
    //{
    //    public string bookName;
    //    public string author;
    //    public double price;
    //}

    // COMMAND LINES ARG
    //enum Direction
    //{
    //    Up, 
    //    Down, 
    //    Left, 
    //    Right
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Greeting("Gladys");
            string fullName = GetFullName("Gladys", "Alvarez", "gladyscodes");
            Console.WriteLine(fullName);
            int[] array2 = { 10, 10, 10 };
            Console.WriteLine(string.Join(", ", array2));
            UpdateArray(array2, 2, 200);
            Console.WriteLine(string.Join(", ", array2));

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

            // CHECK THIS ONE!
            // Write an expression that returns true if x is even, and false if x is odd. Store the result of the expression in a bool.
            //bool isEven = true;

            //if (num % 2 == 0)
            //{
            //   Console.WriteLine($"Number: {num} is even = {isEven}");
            //}
            //else 
            //{
            //    Console.WriteLine($"Number: {num} is odd");
            //}
            // CHECK THIS ONE!
            // Write an expression that returns false if y is divisible by 3. Store the result of the expression in a bool
            // CHECK THIS ONE!
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

            //CHECK THIS ONE!!
            // Write code to get just the file name (no path), without the extension.
            // string[] splitPath = pathFile.Split('c');
            // Console.WriteLine($"Get the file name: {splitPath}");

            // CHECK THIS ONE!!
            // Write code to get just the drive letter, in uppercase.
            //Console.WriteLine(pathFile.ToUpper());

            // SPLITTING 
            // Declare string x and initialize it to whatever you like. 
            // string x = "Enrique";
            // Make sure the string has spaces in it.
            // Split the string on space and observe the results
            // string[] nameWithSpaces = x.Split(' ');
            // Console.WriteLine(nameWithSpaces);    

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

            // CHECK THIS ONE!!
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

            // STRUCTS
            // Create a struct inside the HelloWorld namespace, but outside of the Program class
            // Call the struct whatever you like and add some members to it
            // Declare a variable x and instantiate the struct
            // Declare a variable y and instantiate the struct
            // Set every member in x to the values of every member in y
            // Print the members of x

            //var x = new Books();

            //x.bookName = "Outliers";
            //x.author = "Malcom Gladwell";
            //x.price = 17.99;

            //Console.WriteLine($"This is a struct= book name: {x.bookName}, author: {x.author}, price: {x.price}");

            //var y = new Books();

            //y.bookName = "The miracle morning";
            //y.author = "Hal Elrod";
            //y.price = 12.99;

            // CONSOLE I/O
            // Create a program that prompts the user for their first name, then middle name, then last name, all on different lines.
            // Print the first, middle, and last name all on the same line
            // Print “Press any key to exit…” and wait for the user to press a key to exit.

            //Console.Write("Please enter your name: ");
            //var name = Console.ReadLine();
            //Console.Write("Please enter your middle name: ");
            //var middleName = Console.ReadLine();
            //Console.Write("Please enter your last name: ");
            //var lastName = Console.ReadLine();

            //Console.WriteLine($" Welcome! {name} {middleName} {lastName}");
            //Console.WriteLine("Press any key to exit");

            // COMMAND LINE ARGUMENTS 
            // Create an enum called Direction with the values: Up, Down, Left, and Right

            // CHECK THIS ONE!!
            // Create a program that expects three arguments – a Direction, a bool, and an int.

            // If the program is called with no arguments OR called with one argument of “/?”,
            // print a help message explaining what arguments are expected with an example of a valid command line.
            // If either of the first two arguments are missing, print an error message. The third argument is optional
            // Store the arguments in variables of the appropriate type
            // If any value can’t be stored correctly, print an error message
            // Print the variables stored in step 3. Make sure to include the int if it was specified

            // VISUAL STUDIO ARGUMENTS 
            // Test the code above by passing in arguments through visual studio
            // SOLUTION: go to the sol explorer right click on the application name and go to properties
            // Console.WriteLine("There are " + args.Length + " arguments");
            // var argsStr = string.Join(" ", args);
            // Console.WriteLine("The args are: " + argsStr);

            // COMMAND LINE ARGUMENTS
            // Test the code above by passing in arguments directly on the command line


            // PART II

            // CONDITIONALS 

            // IF/ ELSE 
            // Create an int x and set it to 1
            // Write an if/else if/else statement that will check if x is less than, 
            // equal to, or greater than 100 and print an appropriate message for each case
            // Change the value of x to cause each case to be triggered

            //int x = 1;
            //int y = 120;
            //int z = 100;

            //if (x < 100)
            //{
            //    Console.WriteLine($"Value {x} is less than 100");
            //}
            //if (z == 100)
            //{
            //    Console.WriteLine($"Value {z} is equal to 100");
            //}
            //if (y > 100)
            //{
            //    Console.WriteLine($"Value {y} is greater than 100");
            //}

            // SWITCH
            // Create an enum type. Name it whatever you like and populate it with whatever values you like.
            // Write a switch statement that checks each value of the enum and does something for each match.

            // var food = Food.Mexican; // this is the one displayed

            //switch (food)
            //{
            //    case Food.Chinese:
            //        Console.WriteLine("I like Chinese food");
            //        break;

            // Include one case that falls through to the next case.
            //case Food.Thai:
            //case Food.Mexican:
            //    Console.WriteLine("I love the Mexican food!");
            //    break;

            //case Food.Thai:
            //    Console.WriteLine("Loving Thai food");
            //    break;

            //default:
            //    Console.WriteLine("The food is invalid");
            //    break;

            // ORDER OF OPERATIONS 
            // Create a string s and initialize it to whatever you like.
            // Write code that does the following using conditional operators:
            // If the string length is less than 5 and is odd OR
            // If the string length is greater than or equal to 10 and is even
            // Print a message
            // Change the string length to make sure your code works properly

            // CHECK THIS ONE!!
            //string s = "Coffeeeeeeeeeeeeee";

            //int sLength = s.Length;
            //int isOddOrEven = s.Length % 2;

            //if ((sLength < 5 && isOddOrEven != 0) || (sLength >= 10 && isOddOrEven == 0))
            //{
            //    Console.WriteLine($"String: {s} is less than five and is odd or is greater than 10 and is even");
            //}

            // NESTED CONDITIONALS
            // Duplicate the logic above using nested conditionals
            // Do not use any conditional operators when comparing values

            //if (sLength < 5)
            //{
            //    Console.WriteLine("The length is less than five");

            //    if (isOddOrEven != 0)
            //    {
            //        Console.WriteLine("and is odd");
            //    }
            //}

            // LOOPS 

            // While 
            // Create an infinite while loop and run your program to see what happens
            // for (int i = 1; i > 0; i++)
            // {
            //    Console.WriteLine("I will run forever");
            // }
            // Create a string s and initialize it to “0123456789”
            // Use a while loop to print every odd digit in the string, all on the same line.

            //string s = "0123456789";
            //int counter = 0;

            //Console.WriteLine(s.Length);

            //while (counter != s.Length)
            //{
            //    if (s[counter] % 2 != 0)
            //    {
            //        Console.WriteLine($"Printing odds: {s[counter]}");
            //    }
            //    counter++;
            //}

            // DO WHILE 
            // Duplicate the above logic using a Do While loop


            // FOR
            // Duplicate the above logic using a for loop


            // FOREACH
            // Duplicate the above logic using a foreach loop



            // NESTED LOOPS
            // Imagine you have a hat with 5 different numbers in it. You take out numbers, one at a time, without putting them back.
            // Write code that prints out every possible combination of numbers you can get, in all the different orders you can get them. Use any type of loops you want.
            //int[] hat = {12, 93, 11, 3, 10};


            // LOOP FLOW CONTROL 
            // Declare a string s and initialize it to whatever you want.
            // Make sure the first character in your string is repeated somewhere else in the string
            // Write a loop that searches through the string and looks for another occurrence of the first character found.
            // If the character found doesn’t match the first one, the loop should immediately go to the next letter
            // If the character found matches, print the index of the match, and immediately exit the loop.

            // ARRAYS
            // SINGLE DIMENSIONAL ARRAYS

            // Create an int array of size 10. Use a while loop to fill the array with the numbers 1 through 10.
            //int[] arr = new int[10];

            //int count = 1;

            //while (count <= arr.Length)
            //{
            //    Console.WriteLine(count++);
            //}

            // Use a for loop to print the contents of the array in reverse order (IMPROVE THIS ONE!!)
            //int[] array1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //for (int i = array1.Length -1 ; i >= 0; i--)
            //{
            //    Console.WriteLine(array1[i]);
            //}

            // Write code that prints the sum of all numbers in the array (IMPROVE THIS ONE!!)
            //int[] array2 = { 2, 4, 5, 6, 8, 9, 1 };

            //int sum = 0;
            //foreach (var num in array2)
            //{
            //    sum += num;
            //    Console.WriteLine($"Total is: {sum}");
            //}

            // Print the contents of the array without using a loop
            //string arrayContent = string.Join(",", array2);
            //Console.WriteLine(arrayContent);

            // MULTI-DIMENSIONAL ARRAYS
            // Create a 2D int array of any size 
            // Use any loop(s) to store the product of the two indices in each element
            // For example, the element at[2, 3] should be set to 6
            // Print the contents of the array using a foreach loop
            var array2D = new int[4, 4];
            int rows = array2D.GetLength(0);
            int col = array2D.GetLength(1);

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    int value = array2D[x, y] = x * y;
                }
            }

            foreach (var item in array2D)
            {
                Console.WriteLine(item);
            }
        }


        // FUNCTIONS
        // BASIC FUNCTIONS

        // Write a function that prints out whatever string you pass into it.Call the function to make sure it works
        private static void Greeting(string name)
        {
            Console.WriteLine(name);
        }

        // Write a function that concatenates three strings and returns the result. Call the function to make sure it works.
        private static string GetFullName(string firstName, string lastName, string alias)
        {
            return $"{firstName} {lastName} alias {alias}";
        }

        // Write a function that takes in an int array, an int index, and an int value. 
        // The function should update the array at the specified index with the specified value.
        // If the index is out of range, the function should do nothing.Call the function to make sure it works.
        private static void UpdateArray(int[] array, int index, int value)
        {
            if (index < array.Length)
            {
                array[index] = value;
            }
            //try
            //{
            //    array[index] = value;
            //} catch (System.IndexOutOfRangeException)
            //{
            //    return;
            //}
        }

        // Write a function that takes in a string and returns a new string that contains every other word 
        // (starting from the first) in the original.
        // Call the function to make sure it works.
        // For example, passing in “to be or not to be” should return “to or to”
        private static string UpdateString(string s)
        {

        }


        // Write a function that takes in a string, an optional int parameter called index, and an optional int parameter called length.
        // The function should return a substring of the original string starting at the specified index, with the specified length.Call the function to make sure it works.
        // If the index or length are out of range, the function should return an empty string.
        // If the index is not specified, start at index 0
        // If the length is not specified(or is 0), take the rest of the string

        // REFERENCE TYPE EQUALITY
        
        // Write a function called AreArraysEqual that returns bool.The function should take in two int arrays and return whether they contain the same elements, in the same order.Call the function to make sure it works.
        // The function should return immediately as soon detects a mismatch

        // OUTPUT PARAMETERS

        // Write a function that returns void with two int input parameters.The function should have four output parameters that should return the sum, difference, product, and quotient of the two inputs. Call the function to make sure it works.

        // REFERENCE PARAMETERS

        // Write a function that takes in a string and a reference to an int.The function should return the character at the index specified by the int.
        // If the int is negative, the first character should be returned and the int should be changed to 0.
        // If the int is larger than the string length, the last character should be returned and the int should be changed to the last index in the string.

    
    }
}

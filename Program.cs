using System.Diagnostics;
using System.Xml;

namespace Prog120_S24_L3_Intergrals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vicky Le
            // 4/9/2024
            // Programming 120

            // Expected Result = 6
            //int value = 123;
            //int base10 = 10;
            //int sum = 0;
            //--------
            // divide and modulus
            // Console.WriteLine(value % base10);
            //Console.WriteLine($"Current Value: {value}");

            //int singleValue = value % base10;
            //sum += singleValue;
            //value /= base10;

            //Console.WriteLine($"Current Value: {value}");
            //Console.WriteLine($"Sum: {sum}");

            //singleValue = value % base10;
            //sum += singleValue;
            //value /= base10;

            //Console.WriteLine($"Current Value: {value}");
            //Console.WriteLine($"Sum: {sum}");

            // How to sum all numbers in a number with a loop
            int largerValue = 123456;
            int newSum = 0;
            int base10 = 10;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (largerValue > 0)
            {
                // Getting the single value
                int currentSingleValue = largerValue & base10;
                // Adding the single value
                newSum += currentSingleValue;
                //SLICING the single value
                largerValue /= base10;

                Console.WriteLine($"Current Value: {currentSingleValue}");
                Console.WriteLine($"Sum: {newSum}");
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Restart();

            string numbers = "123456";
            int sumString = 0;

         
            foreach (char number in numbers)
            {
                string charToString = number.ToString();
                int stringToNumber = int.Parse(charToString);

                sumString += stringToNumber;
            }
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);

            // Loops
            // Conditions



        } // main

        // Pemdas();
        static void Pemdas()
        {
            // 6 Fundamentals
            // Inputs
            // Outputs

            // Variables
            // Operations
            // Math ( + - * / )
            // Modulus ( % )
            // Assignment Operation keyword = value
            // Comparison
            // Logical
            // Coumpound

            int vitalli = 7;
            int brian = 88;
            int vicky = 6;
            int coby = 7;
            int hoang = 7;

            int sum = vitalli + vicky;
            Console.WriteLine($"Sum: {sum}");

            int divide = brian / coby;
            int mod = brian % coby;
            Console.WriteLine($"Divide: {divide}");
            Console.WriteLine($"Modulus: {mod}");

            // Order of Options
            // Pemdas
            // Parenthese
            // Exponents
            // Multiply
            // Divide
            // Addition
            // Subtraction

            int randomEquation = 4 - 2 * 9 - 4 + 2;
            int randomEquationPemdas = 4 - (2 * 9) - 4 + 2;

            int p1 = 2 * 9;
            int p2 = 4 - p1;


            Console.WriteLine(randomEquation);
            Console.WriteLine(randomEquationPemdas);

            // Compound Operators
            int age = 40;
            //age = age + 2;

            // +=, -=, /=, *=, %=
            age -= 2;
            Console.WriteLine(age);
        }

        // IntAndPrimitiveExample();
        static void IntAndPrimitiveExample()
        {
            // Whole Number Types
            // Integral Type
            // int
            int age = 40;
            int daysInYear = 365;
            int daysAlive = age * daysInYear;
            // $ for string interpolation
            Console.WriteLine($"You have been alive for {daysAlive} days");
            // sbyte s = -128;

            // Primitive Data Type
            int newAge = age;
            Console.WriteLine($"Age: {age}");
            age = 35;
            Console.WriteLine($"NewAge: {newAge}");

            string name = "Billy";
            string newName = name;

            Console.WriteLine($"Name: {name}");

            name = "John";

            Console.WriteLine($"NewName: {newName}");
            Console.WriteLine($"Name: {name}");

        }
        // How to define a method
        static void CharacterExample()
        {
        // CharacterExample();
            //char
            string word = "Hello";

            // Char ( Character ) is an individual character
            // A character is placed in single quote ' '
            char letter = 'H';
            char lowerCaseH = (char)((int)letter + 32);
            //foreach (char character in word)
            //{
            //    Console.WriteLine(character);
            //}

            Console.WriteLine((char)('a' - ' '));

            // Review
            // Console. WriteLine
            //Console.Write

            // Variables
            // string
            // "collection of characters"
            // string interpolation
            // concatenation
        }
} // class
} // namespace

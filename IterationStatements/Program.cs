using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbers();
            ThreeCubed();
            Console.WriteLine($"{AreTheyEqual(7, 11)}");
            EvenOrOdd();
            PositiveOrNegative();
            OldOrYoung();
            Range();
            MultiplicationTable();
        }
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void ThreeCubed()
        {
            for (int l = 3; l <= 999; l += 3)
            {
                Console.WriteLine($"{l}");
            }
        }

        public static bool AreTheyEqual(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void EvenOrOdd()
        {
            int z = 7;

            if (z % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


        }

        public static void PositiveOrNegative()
        {
            var y = -8;

            if (y > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        public static void OldOrYoung()
        {
            Console.WriteLine("How old are you?");
            var input = (Console.ReadLine());

            int age = (int.Parse(input));
            int b = 18;

            if (age >= b)
            {
                Console.WriteLine("Congrats! You're old enough to vote!");
            }
            else
            {
                Console.WriteLine("You're too young to vote, sorry.");
            }
        }
        public static void Range()
        {
            Console.WriteLine("Input a number to determine if you're in range.");
            int input = int.Parse(Console.ReadLine());

            int startRange = -10;
            int endRange = 10;

            if (input >= startRange && input <= endRange)
            {
                Console.WriteLine($"Your number is within range.");
            }
            else
            {
                Console.WriteLine($"Sorry but your number is not in the range that is required.");
            }

        }
        public static void MultiplicationTable()
        {
            int o = 7;
            var numbers = new int[] {1,2,3,4,5,6,7,8,9,10,11,12};

            foreach(var number in numbers)
            {
                int result = number * o;
                Console.WriteLine($"{o} multiplied by {number} is {result}");
            }
        }
    }
}

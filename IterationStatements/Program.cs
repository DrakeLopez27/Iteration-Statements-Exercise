using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int a, int b)
        {
            var numCheck = (a == b) ? true : false;

            if (a == b)
            {
                numCheck = true;
            }
            else
            {
                numCheck = false;
            }

            return numCheck;
        }
        //Write a method to check whether a given number is even or odd

        public static void EvenOdd(int a)
        {
            Console.WriteLine("Type a number.");
            var num = Int64.Parse(Console.ReadLine());

            var remainder = num % 2;

            if (remainder == 0)
            {
                Console.WriteLine($"{num} is an even number ");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");

            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void IfPositiveNeg()
        {
            Console.WriteLine("Type a number between -100 - 100");
            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine($"{a} is a negative number");
            }
            else
            {
                Console.WriteLine($"{a} is a positive number");
            }

        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void Age()
        {
            Console.WriteLine("Type your age");
            var age = int.Parse(Console.ReadLine());
            
            if (age >=18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are NOT old enough to vote!");
            }
            
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void WithinRange()
        {
            Console.WriteLine("Type a number");
            int userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum < -10 || userNum > 10)
            {

                Console.WriteLine("Not in range");

            }
            else
            {

                Console.WriteLine("within range");

            }

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            var startNum = 1;
            var numCap = 12;
            
            List<int> list = new List<int>();

            for(startNum = 1; startNum <= numCap; startNum++)
            {
                list.Add(startNum);
            }
            foreach(int num in list) 
            { 
                Console.WriteLine($"{numCap} * {num} = {numCap * num}");
            }

        }

        //Call the methods to test them in the Main method below
        public static void Main(string[] args)
        {

            PrintThousand();

            Threes();

            Console.WriteLine(IsEqual(2, 8));

            EvenOdd(5);

            IfPositiveNeg();

            WithinRange();

            MultiplicationTable();


            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            PositiveToNegative();

            IncrementByThree();

            CheckIfEqual(3, 4);

            CheckEvenOrOdd(14);

            PositiveOrNegative(-45);

            Console.WriteLine("Enter your age to see if you can vote or not");

            string userResponse = Console.ReadLine();

            CheckVotingAge(userResponse);

            Console.WriteLine("Enter a number");

            string userRangeResponse = Console.ReadLine();

            RangeofNumbers(userRangeResponse);

            MultiplicationTable();

            Console.ReadLine();
        }

        #region 1000 - -1000 Method
        public static void PositiveToNegative()
        {
            Console.WriteLine("Starting positive");

            for(int i = 1000; i >= -1000; i--)
            {
                switch (i)
                {
                    case -1:
                        Console.WriteLine("");
                        Console.WriteLine("Starting negative");
                        break;

                }
                Console.WriteLine(i);
            }

        }
        #endregion

        #region 3 - 999 Method
        public static void IncrementByThree()
        {
            Console.WriteLine("Starting increments of 3 to 999");

            for(int i = 3; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region Check if equal Method
        public static void CheckIfEqual(int i, int x)
        {
            var response = (i == x) ? $"{i} and {x} are equal" : $"{i} and {x} aren't equal";
            Console.WriteLine(response);
        }
        #endregion

        #region Check if even or odd Method
        public static void CheckEvenOrOdd(double i)
        {
            var response = (i / 2 == 1) ? $"{i} is even" : $"{i} is odd";
            Console.WriteLine(response);
        }
        #endregion

        #region Check if positive or negative Method
        public static void PositiveOrNegative(int i)
        {
            var response = (i >= 0) ? $"{i} is positive" : $"{i} is negative";
            Console.WriteLine(response);
        }
        #endregion

        #region Check if able to vote Method
        public static void CheckVotingAge(string input)
        {
            int userAge = Convert.ToInt32(input);
            var response = (userAge < 18) ? "You are to young to vote!" : "You can vote!";
            Console.WriteLine(response);
        }
        #endregion

        #region Check if range is -10 - 10 from user Method
        public static void RangeofNumbers(string input)
        {
            int queryNumbers = Convert.ToInt32(input);
            var response = (queryNumbers <= 10 && queryNumbers >= -10) ? $"{queryNumbers} is within -10 and 10" : $"{queryNumbers} isn't within -10 and 10";
            Console.WriteLine(response);
        }
        #endregion

        #region Multiplication table Method
        public static void MultiplicationTable()
        {
            int counter;
            int number;


            for(counter = 1; counter <= 12; counter++)
             {
                for (number = 1; number <= 12; number++)
                {
                    Console.WriteLine($"{counter} * {number} = {counter * number} ");
                }

            }
            
        }
        #endregion

    }
}


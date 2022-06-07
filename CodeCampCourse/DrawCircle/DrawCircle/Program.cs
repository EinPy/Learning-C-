using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lists are mutable
            int[] numbers = { 3, 7, 13 };
            string[] friends = new string[2];
            friends[0] = "alex";
            friends[1] = "magne";
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }
            Console.WriteLine(numbers[2]);

            OutPut("EINAR", 21);
            Console.WriteLine(cube(5));
            ifTest(true, false);
            Console.WriteLine(GetMax(10, 11));

            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"This is a double: {num1}");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(SwitchTets(i));
            }
            WhileTest(10);
            Console.ReadLine();

        }

        static void OutPut(string name, int age)
        {
            Console.WriteLine("TEST OF METHOD");
            Console.WriteLine(name);
            Console.WriteLine($"you are {age} years old");
        }
        private static int cube(int n)
        {
            return n * n * n;
        }
        private static void ifTest(bool hungry, bool tired)
        {
            if (hungry)
            {
                Console.WriteLine("Eat something");
            }
            else
            {
                Console.WriteLine("you are saturated");
            }
            if (tired)
            {
                Console.WriteLine("Go to sleep");
            }
            else
            {
                Console.WriteLine("You are able to work");
            }
            if (hungry && tired)
            {
                Console.WriteLine("You are not well");
            }
            else if (hungry || tired)
            {
                Console.WriteLine("You are either hungry or tired but not both");
            }
            else
            {
                Console.WriteLine("You are neither hungry nor tired");
            }

        }
        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static string SwitchTets(int a)
        {
            //a representes a days after newYears
            // Assums day 1 is monday
            int day = a % 7;
            string dayName;

            switch (day)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednsday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            return dayName;
        }

        static void WhileTest(int n)
        {
            int index = 0;
            while (index < n)
            {
                Console.WriteLine(index);
                index++;
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, minutes;
            hours = TimeConsoleInput(0, 24, "Enter hours: ");
            minutes = TimeConsoleInput(0, 59, "Enter minutes: ");

            Clock clock = new Clock(hours, minutes);

            Console.WriteLine($"Lesser angle between hours and minutes arrows: {clock.GetAngle()} degree(-s)");

            Console.ReadKey();
        }
        //min and max shows between what numbers you can choose
        //condition - console output to user, before input
        static int TimeConsoleInput(int min, int max, string condition)
        {
            int output = -1;
            while(output == -1)
            {
                Console.Write(condition);
                string input = Console.ReadLine();
                //checks if console input can be converted to integer
                if(int.TryParse(input, out int result))
                {
                    //checks if given number is between min and max
                    if(result>=min && result <= max)
                    {
                        output = result;
                    }
                    else
                    {
                        Console.WriteLine($"Input shoud be between {min} and {max}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            return output;
        }
    }
}

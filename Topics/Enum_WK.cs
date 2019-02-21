using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
   public class Enum_WK
    {
        enum Sequence {LevelA=90, LevelB, LevelC, LevelD, LevelE, LevelF};

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void method()
        {
            Console.WriteLine(Enum.GetName(typeof(WeekDays), 4+"<-----Using Getname() method"));

            Console.WriteLine("WeekDays constant names:");

            foreach (string str in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(str+"Iterating the Values in loop");
            }
            Console.WriteLine("Enum.TryParse():");

        }

        public static void Main(string[] args)
        {
            int status = (int)Sequence.LevelD;
            Console.WriteLine(status);
            Console.WriteLine(Sequence.LevelC);

            method();

            Console.ReadLine();
        }
    }

}

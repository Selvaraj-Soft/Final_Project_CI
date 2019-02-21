using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Variabales
    {
       static int obj1;
        static string obj2;
        static float obj3;
        static char obj4;
        static double obj5;
        static decimal obj6;

        static void Main(string[] args)
        {
            obj1 = 7777;
            //obj2 = 4521; //Cannot implicitly convert type 'int' to 'string'
            obj2 = "Raju";
            obj3 = 23.90F;
            obj4 = 'H';
            obj5 = 58.6754;
            obj6 = 10.00M;

          

            int int_conv = (int)obj5;   //DoubleToInt

            int int_conv2 = (int)obj3;

            Console.WriteLine(obj1); Console.WriteLine(obj2); Console.WriteLine(obj3); 
            Console.WriteLine(obj4); Console.WriteLine(obj5); Console.WriteLine(obj6);


            Console.WriteLine("\n \n"+ int_conv);
            Console.WriteLine("\n \n" + int_conv2);
            Console.ReadLine();

        }
    }
}

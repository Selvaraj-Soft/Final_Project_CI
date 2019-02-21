using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    public class Test_Topics2

    {
        public Test_Topics2()
        {
            Console.WriteLine("Executing Constructor Method");
        }

        public Test_Topics2(int var1,string str)
        {
            Console.WriteLine(str+var1+ " Executing Constructor Method With arg");
        }

       static void string_Count()
        {
            string str = "Selvaraj";           
            int count = str.Count(x => x == 'a');
            Console.WriteLine(count+"<-----No of letters Count is ");
        }

        static void array_method()
        {
            int[,] obj = new int[,] { { 99, 77 }, { 88, 66}, { 77, 55} };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(obj[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            Test_Topics2 obj = new Test_Topics2();
            Test_Topics2 obj1 = new Test_Topics2(836,"Selva");
            string_Count();
            array_method();
            Console.ReadLine();
        }
    }
}

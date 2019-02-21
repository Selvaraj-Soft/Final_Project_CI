using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class UnSafe_Codes
    {
        //int* data1;
        //string* str;

        static unsafe void method1()
        {

            int value = 555;
            int* data = &value;

            Console.WriteLine(value);
            Console.WriteLine(*data);
            Console.WriteLine((int)data + "<<--Address of this variable");

        }

        static unsafe void method2()
        {

            //int num = 99;
            //num++;

            //int* result = &num;
            //Console.WriteLine(*result + "<<--Incremental value from variable");

            unsafe      //using unsafe as a block
            {
                int a = 99;
                a++;

                int* b = &a;
                Console.WriteLine(*b + "<<--Incremental value from variable");

            }

        }

        static unsafe void method3()
        {

            int a = 10; //value= 10;  
            a++; //value= 11;  
            Console.WriteLine("\n\tBefore Increment");

            int* p = &a;

            Console.WriteLine( "Value of p is: {*p} \t Address of p is:{(int)p}");
            ++p;
            Console.WriteLine("\n\tAfter Increment");
            Console.WriteLine( "Value of p is: "+*p+" \t Address of p is:"+(int)p+"\n");
            Console.WriteLine("\tCalculation");
            Console.WriteLine( "Size of int {sizeof(int)}");
            Console.WriteLine( "Actual address of 11 is: {(int)p - (int)(sizeof(int))} ");

        }

        public static void Main(string[] args)
        {

           // method1();
            //method2();
            method3();
            Console.ReadLine();
        }

    }
}

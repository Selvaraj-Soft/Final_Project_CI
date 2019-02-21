using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    public class Delgates_WK
    {
        public delegate void delmethod();

        public class Class2
        {

            public static void method1()
            {
                Console.WriteLine("Method 1 Calling");
            }

            public static void method2()
            {
                Console.WriteLine("Method 2 Calling");
            }

            public void method3()
            {
                Console.WriteLine("Method 3 Calling");
            }

        }

        public static void Main(string[] args)
        {
            
            delmethod del1 = Class2.method1;            
           
            delmethod del2 = new delmethod(Class2.method2); //  using the delagate with delegate obj
            Class2 obj = new Class2();
            
            delmethod del3 = obj.method3;

            del1();  //<<Calling method directly
            del2();     //calling method using object
            del3();     //calling nmethod with use of class object
            Console.ReadLine();
        }
    }
}


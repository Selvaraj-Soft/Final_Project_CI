using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Attrib_WK
    {

        class HelpAttribute : Attribute                             //Inheriting this attribute class to our class
        {
            public string HelpText { get; set; }

        }


        [Obsolete("Old method will be ignored", true)]              //Attribute with obsolette
        static void methodA()
        {
            Console.WriteLine("Old Method is executed");
        }

        static void methodB()
        {
            Console.WriteLine("Updated Method is executed");
        }

        //Custom Attributes Creation

        [Help(HelpText = "This is a class")]                        //specifying the classes
        class Customer
        {
            private string _CustomerCode;

            [Help(HelpText = "This is a property")]                 //specifying the properties
            public string CustomerCode
            {
                get { return _CustomerCode; }
                set { _CustomerCode = value; }
            }

            [Help(HelpText = "This is a method")]                  //specifying the methods 
            public void Add()
            {
                int i = 40;

                int result = i + 20;

                Console.WriteLine(result);
            }
        }
        
        public static void Main()
        {
        /*    methodA();*/              // throwing error as methodA() is Obsollete with the string we mentioned 
            methodB();
            Customer obj = new Customer();
            obj.Add();
            Console.ReadLine();
        }

    }
}

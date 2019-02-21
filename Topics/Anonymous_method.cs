using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Anonymous_method
    {
        public delegate void Action(string data);
        
        static void method1()
        {
            Console.WriteLine("This method is invoke by Delegate object");

        }

        public static void Main(string[] args)
        {
            //Console.WriteLine("Anonymous Method Running");           

            Action obj = delegate (string data)
            {
                Console.WriteLine(data);
            };

            obj("Anonymous method is called");

            Console.ReadLine();
        }
    }
}

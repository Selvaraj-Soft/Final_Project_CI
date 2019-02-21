using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Loops
    {

        void for_loop()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

        }

        void while_loop()
        {

            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }


        }
            
        void do_whileLoop()
        {

            int number = 0;
            do
            {
                Console.WriteLine("Do while condition numbers"+number);
                number = number + 9;
            } while (number <= 4);

        }

        void for_each()
        {
            ArrayList list = new ArrayList();
            list.Add("Selva");
            list.Add("Raj");
            list.Add("Updating the list");

            foreach (string name in list)
                Console.WriteLine(name);

        }
    static void Main(string[] args)
        {

            Console.WriteLine("Loops Method");
            Loops obj = new Loops();

            obj.for_loop();
            obj.while_loop();
            

            obj.do_whileLoop();
            obj.for_each();
            

            Console.ReadLine();
        }

    }
}

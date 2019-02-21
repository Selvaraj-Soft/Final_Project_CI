using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Events_WK2
    {
        public delegate void Data();

        public event Data Marketing;

       
        public static void DigitalData()
        {
            int numb= 541741;
            string Value = Convert.ToString(numb);

            Console.WriteLine(Value+"Digital Values Displaying");

        }
        public static void AnalogData()
        {
            Console.WriteLine("Analog Data is Displaying");

        }

        public static void Important_Data()
        {
            String str = "Once an event is declared, it must be associated with one or more event handlers before it can be raised";
            Console.WriteLine(str);
        }

        public static void Additional_Data()
        {
            int x = 99;
            int y = 01;
            Console.WriteLine("Add Method {0}", x + y);
        }

        public Events_WK2()
        {
            
                if (Marketing != null)
                {
                    Marketing += new Data(DigitalData);
                    Marketing += new Data(AnalogData);
                    Marketing += new Data(Important_Data);
                    Marketing += new Data(Additional_Data);
                    Marketing();
                    Console.WriteLine("Event is raised");
                }

                if (Marketing == null)
                    Console.WriteLine("Given Event is null");
            }


        public static void Main(string[] args)
        {
            Events_WK2 obj = new Events_WK2();

            obj.Marketing += new Data(DigitalData);
            obj.Marketing += new Data(AnalogData);
            obj.Marketing += new Data(Important_Data);
            obj.Marketing += new Data(Additional_Data);
            try
            {
                obj.Marketing();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "Event is null");
            }
        

            Console.ReadLine();
        }
    }
}

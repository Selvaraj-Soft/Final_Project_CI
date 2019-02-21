using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class MyClass
    {
        private int data;
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
    }

    class getcolor
    {
        private string color;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value == "Red")
                    color = value;
                else
                    Console.WriteLine("Data value");
            }
        }
    }


    class mybaseclass
    {
        public string text_data
        {


            get
            {
                Console.WriteLine("Get my data string");
                return "Sucess";

            }

            set
            {
                Console.WriteLine("String Data Existing");
            }
        }

        class Properties_B 
        {
            static void Main(string[] args)
            {
                //MyClass obj = new MyClass();
                //obj.Data = 787;
                //int result = obj.Data;
                //Console.WriteLine(result);

                //Properties_B obj1 = new Properties_B();
                //obj1.text_data = "Custom Value";
                //Console.WriteLine(obj1.text_data);
                //Console.ReadLine();

                getcolor obj2 = new getcolor();
                obj2.Color = "Red";
                Console.WriteLine(obj2.Color);
                
            }

        }
    }
}

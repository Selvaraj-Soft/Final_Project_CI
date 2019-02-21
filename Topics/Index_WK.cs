using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Index_WK
    {

        public static int size = 10;
        public static string[] namelist = new string[size];
        public Index_WK()
        {

            for (int i = 0; i < size; i++)
            {
                namelist[i] = "Selva";
                Console.WriteLine(namelist[i] + "   _Constructor Executed");
            }
        }

        private string[] range = new string[5];
        public string this[int indexrange]
        {
            get
            {
                return range[indexrange];
            }
            set
            {
                range[indexrange] = value;
            }
        }
    
        public static void Main(string[] args)
            {

            Index_WK obj = new Index_WK();      //Class is created with object
            obj[0] = "ONE";
            obj[1] = "TWO";

            Console.ReadLine();

            }
        }

    }


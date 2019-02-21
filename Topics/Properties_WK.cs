using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Properties_WK
    {
        private int num = 0;
        private string name;
        public int GetNum
        {
            get
            {
                return num;
            }
            set
            {
                num = value;               
                
            }
        }

        public string Name
        {
            get
            {
                return name.ToUpper();             //setting the name to CAP letters      
            }
            set
            {
                // name = value;
                name = "selvaraj";
            }
        }


        public static void Main(string[] args)
        {

            Properties_WK obj = new Properties_WK();
            obj.GetNum = 45;
            obj.Name = "Selva";
            Console.WriteLine(obj.GetNum);
            Console.WriteLine(obj.name);


            Console.ReadLine();

        }
    }
}

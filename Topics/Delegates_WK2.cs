using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Delegates_WK2
    {
       

        public delegate void Action();
        //StreamWriter streamWriter;

        public delegate void Process(int value);
        public  static void GetList_Name()
        {

            List<string> obj = new List<string>();
            obj.Add("Selv");
            obj.Add("Raj");
            obj.Add("Sofcrylic_Company");
            foreach (string data in obj)
            {
                Console.Write(data+"<--->");
            } 

        }

        public static void GetMarks(int num)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Average Total marks scored--->"+num);           
        }
        public static void Workplace(int ID1)
        {
            Console.WriteLine("ID Card number is --->>>"+ ID1);
        }

        public static void School(int ID2)
        {
            Console.WriteLine("ID Card number is >>>"+ ID2);
        }

        public static void College(int ID3)
        {
            Console.WriteLine("ID Card number is >>>"+ ID3);
        }


        public static void Main(string[] args)
        {

            // Delegates_WK2 test = new Delegates_WK2();
            //   test.GetList_Name();                           //Calling function in default way using object

            Action execute = new Action(GetList_Name);
            execute();                                          //Calling function using delegate object
            Process objec = new Process(GetMarks);
            objec(97);

            //We can use delegate in this type also

            objec += Workplace;
            objec += new Process(Workplace);
            objec += College;
            objec(55);
            Console.ReadLine();
        }
    }
}

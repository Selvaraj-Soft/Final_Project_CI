//defining directives
#define name
#define name_
#define My_data

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;


namespace Topics
{
    class Processor_Dirct
    {


        static void Check_processor()
        {
#if (My_data)
            Console.WriteLine("PI  symbol Found");
#else
            Console.WriteLine("Nothing Found");
#endif
        }

        static void check()
        {
#if (name)                                                             //Conditional Statments directives checks define 
            Console.WriteLine("Name symbol Found");

#else
            Console.WriteLine("Noting Found");
#endif

        }
#region                                                     //Decalring the region[portion of the code]
        static void GetAlerts(int num,string str)
        {
            int data=num;
            string data1=str;
            Console.WriteLine("Im dealing with {0} numbers of programs in my {1} Company", data, data1);

        }
#endregion
        static void Main(string[] args)
        {
            check();
           // Check_processor();
            GetAlerts(500,"Softcrylic Technology");
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Events_WK
    {
        public delegate void Action();          //Declaring Delegates

        event Action Myevent;                   //Declaring Events

      //  public delegate void MyEventHandler(object sender, EventArgs e);        //implementing Event:
        public Events_WK()
        {

            Myevent += new Action(method1);             //intializing Delegates objects to events
        }
        public static void method1()
        {
            Console.WriteLine("This method was executed by event");
            //Console.WriteLine("Executing Eventually with help");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 executed using delegates& event");
        }
        public static void Main(string[] args)
        {
            Events_WK obj = new Events_WK();
            
            obj.Myevent();
            Events_WK objA = new Events_WK();
          //  objA=Object.Equals=>(obj.MemberwiseClone());
            Console.ReadLine();
        }
    }
}

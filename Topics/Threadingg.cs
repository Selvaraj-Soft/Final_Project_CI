using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Topics
{
    class Threadingg
    {
          void method1()
        {
            lock (this)                                      //Locking the thread so that no context-switching between the threads
                                                             //{executes synchronously}
            {

                
                for (int i = 0; i < 25; i++)
                {
                    //bool objt = Thread.IsAlive;
                    Console.WriteLine(i);
                    

                }
            }
                Thread t = Thread.CurrentThread;                //Get the current thread name
                Console.WriteLine(t.Name + " is running");
            
        }
        static void GetString()
        {
            char[] obj = { 'S', 'E', 'L','V','A'};
            string str = new string(obj);

            Console.WriteLine(DateTime.Today.ToString("yyyy-MM-dd"));
            Console.WriteLine(str+"<---Char to string-Task1");
            Thread t = Thread.CurrentThread;                //Get the current thread name
            Console.WriteLine(t.Name + "is running");
        }

        static void GetChar()
        {
            string str = "SELVARAJ";
            char[] obj = str.ToCharArray();
            foreach (var data in obj)
            Console.Write(data+" ");
         // Thread.Sleep(5200);
            Console.WriteLine("<---String to char-Task2");
            Thread t = Thread.CurrentThread;                //Get the current thread name as object 
            Console.WriteLine(t.Name + " is running");
            //Thread.Sleep(200);
        }
        public static void Main(string[] args)
        {
            Thread objt = Thread.CurrentThread;
            
            objt.Name = "MainThread";
            Console.WriteLine(objt.Name);

            Threadingg obj = new Threadingg();

            Thread t1 = new Thread(obj.method1);
            Thread t2 = new Thread(obj.method1);
            // Thread t3 = new Thread(new ThreadStart(Threadingg.method1));

            //     t1.Name = t2.Name = "ForLoop_Thread"; //Setting the Thread Name
            t1.Name = "ForLoop_Thread1";
            t2.Name = "ForLoop_Thread2";

            t1.Start();
            t2.Start();            
            //t3.Join();
            Thread task1 = new Thread(GetString);
            Thread task2 = new Thread(GetChar);
            Thread task3 = new Thread(GetChar);

            task1.Name = task2.Name = task3.Name = "Conversion_Thread";//Setting the Thread Name

           // task1.Priority = ThreadPriority.Lowest;
            task2.Priority = ThreadPriority.Highest;  //Setting the thread priorities

            task1.Start();
            task2.Start();
            task2.Join(); //calling threads to wait until the joined thread is terminated or completes its task.

            Thread.Sleep(5200); ///Maintain sleep time between threads
            try
            {
                task3.Start();
                task3.Abort();  //Terminating the thread.
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }                        
            Console.ReadLine();
        }
    }
}

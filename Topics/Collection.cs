using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Topics
{
    class Collection
    {
         string res = "Raju";

       static void arraylsit()
        {

            ArrayList obj = new ArrayList();
            obj.Add("Selva");
            obj.Add(85);
            obj.Add('R');
            obj.Add(90.05F);
            foreach (var data in obj)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(obj.IndexOf('R'));
            Console.WriteLine(obj.IndexOf("Selva"));
            obj.Insert(4, 56.5F);
            foreach (var data in obj)
            {
                Console.WriteLine(data);
            }
            
        }

        static void hashtable()
        {

            Hashtable obj = new Hashtable();
            obj.Add(1, "Selva");
            obj.Add(3, 'A');
            obj.Add(2, 9098);
            obj.Add(7, 8976F);
            obj.Add(4, "i can't");
            obj.Add(5, "Block Email");

            ICollection key = obj.Keys;

            foreach (var value in key)
            {
                Console.WriteLine(value + "------>---" + obj[value]);
            }
            obj.Remove(5);
          }

        static void sortedList()
        {
            SortedList obj = new SortedList();
            obj.Add(54, "Test");
            obj.Add(09,"Clip");
            obj.Add(14,"Video");
            obj.Add(65,"Notebook");
            obj.Add(32,"Age");
            ICollection keycollec = obj.Keys;
            Console.WriteLine( obj.GetByIndex(2));
            Console.WriteLine(obj.GetKey(3));            
            //  Console.WriteLine(obj.IndexOfKey(2));
         //Console.WriteLine(obj.ContainsKey(54));
          foreach(var data in keycollec)
            Console.WriteLine(data+ "<----My Data's are--->" + obj[data]);
            Console.WriteLine(obj.ContainsKey("Test"));
            
        }

        static void generics()
        {

            string strName = "My Name is {0} and my age is {1} and I am working in {2} and mybio is {3}";
            //strName = string.Format(strName, "Gopal", 28, "Softcrylic");

            Console.WriteLine(strName);

            List<selva> obj = new List<selva>();
            obj.Add(new selva { FullName = "Selvaraj", Age = 26});
            obj.Add(new selva { FullName = "Ravi", Age = 22 });
            obj.Add(new selva { FullName = "Ragini", Age = 26 });
            obj.Add(new selva { FullName = "Gopal", Age = 27 });
            obj.Add(new selva { FullName = "Siva", Age = 27 });

            foreach (var data in obj)
            {
                Console.WriteLine(strName, data.FullName, data.Age, data.CompanyName, data.Bio);
            }
            
        }
        static void dictionary()
        {
            //Namespace:System.Collections.Generic
            // Assemblies:System.Collections.dll, mscorlib.dll, netstandard.dll
            // Create a new dictionary of strings, with string keys.           
            Dictionary<string, string> openWith =new Dictionary<string,string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("PNG", "paint.exe");
            openWith.Add("paint", "paint.exe");
            openWith.Add("word", "wordpad.exe");

        }

        static void Main(string[] args)
        {
            //  arraylsit();
          //   hashtable();
           sortedList();
           // generics();
            Console.ReadLine();
        }
    }

    internal class selva
    {

        public string FullName { get; set; }
        public int Age { get; set; }

        public string Bio
        {
            get
            {
              return   FullName + Age.ToString();
            }
        }

        public string CompanyName
        {
            get
            {
                return "Softcrylic";
            }
        }
    }
}

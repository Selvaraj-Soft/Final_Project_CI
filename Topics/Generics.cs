using System;
using System.Collections.Generic;
using Topics;

namespace Topics
{
    class Generics_class<T>
    {

        static void Generic_classes()
        {
            List<int> obj = new List<int>();
            obj.Add(54);//type must 
            obj.Add(47);
            obj.Add(62);
            obj.Add(41);
            obj.Add(10);
            obj.Add(99);

            foreach (int data in obj)
                Console.WriteLine(data);

        }

        private IEnumerable<object> Generic_method<Object>()
        {

            List<int> objA = new List<int>();
            objA.Add(54);//type must 
            objA.Add(47);
            objA.Add(62);
            objA.Add(41);
            objA.Add(10);
            objA.Add(99);

            foreach (int values in objA)
            {
                Console.WriteLine(values + "Defined Values");
                if (values > 50)
                    yield return values;
                Console.WriteLine(values);
            }

        }
        static void generic_m()
        {
            Queue<string> data_value = new Queue<string>();
            data_value.Enqueue("Data1");
            data_value.Enqueue("Data2");
            data_value.Enqueue("Data3");
            data_value.Enqueue("Data4");
            data_value.Enqueue("Data5");

            foreach (var get_data in data_value)
            {
                //Console.WriteLine(get_data);
                if (get_data == "Data3")
                    Console.WriteLine(get_data);
            }

        }
        static void Main(string[] args)
        {
            Topics.Generics_class method = new Generics_class();

            // Generic_classes();
            //generic_m();
            // method.Generic_method<Object>();
            string test = "Selvaraj";
            Console.WriteLine(test.Length);
            Console.ReadLine();
        }

        
    }
}

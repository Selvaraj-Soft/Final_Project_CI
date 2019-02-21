using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Collection_Programs
    {
        void dictionary_methods()
        {
            //Dictionary<string, int> obj = new Dictionary<string, int>();
            //obj.Add("Selva",836);
            //obj.Add("company", 1000);
            //obj.Add("Offiz", 950);
           
        }

        public class Definition
        {
            public string Word { get; set; } 
            public string PartOfSpeech { get; set; }
            public string Meaning { get; set; }
        }

        static void collection_methods()
        {

            Dictionary<string, string> bigRedBook1 = new Dictionary<string, string>();
            bigRedBook1.Add("acorn", "the fruit of the oak, a smooth oval nut in a rough cuplike base.");

            string value = "";
            if (bigRedBook1.TryGetValue("acorn", out value))
            {
                Console.WriteLine("For key acorn, found value {0}", value);
            }

        }


        public static void Main(string[] args)
        {
            collection_methods();
            type_collection();

            Dictionary<string, Definition> bigRedBook = new Dictionary<string, Definition>();

            var definition1 = new Definition { Word = "acorn", PartOfSpeech = "noun", Meaning = "the fruit of the oak, a smooth oval nut in a rough cuplike base." };
            var definition2 = new Definition { Word = "adore", PartOfSpeech = "verb", Meaning = "love and respect (someone) deeply." };
            var definition3 = new Definition { Word = "available", PartOfSpeech = "adj", Meaning = "able to be used or obtained; at someone's disposal." };
            
            bigRedBook.Add("acorn", definition1);
            bigRedBook.Add("adore", definition2);
            bigRedBook.Add("available", definition3);

            foreach (var data in bigRedBook)
            {
                Console.WriteLine(data);
                
            }

            //Contains Key-bool result

            if (!bigRedBook.ContainsKey("adore")) //ContainsKey returns a Boolean
            {
                bigRedBook.Add("adore", definition2);
                Console.WriteLine(bigRedBook+"");
            }

            //ContainsValue() result

            if (!bigRedBook.ContainsValue(definition1))
            {
                Console.WriteLine("The value exists in the Dictionary");
            }

            foreach (KeyValuePair<string, Definition> objA in bigRedBook)
            {
                Console.WriteLine(objA.Key+"-_-_-_-_-_"+objA.Value);
            }

            
            Console.ReadLine();
        }
        
        static void type_collection()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(1);
            stk.Push(12);
            stk.Push(123);
            stk.Push(1234);
            stk.Push(12345);
            stk.Push(123456);
            stk.Push(1234567);
            stk.Pop();
            // Console.WriteLine(stk.Peek(d)+"<----Top Element is \n");
           Console.WriteLine( stk.Contains(2)+"---<Contains  boolean value \n"); // returns true
            //Console.WriteLine(stk.Contains(2) + "Contains statement");
            stk.Contains(10); // returns false
            Console.WriteLine(stk.Peek());//Displays the 1st element 
            foreach (var s in stk)
            {
                Console.WriteLine(s + "\n");
            }

        }

    }
}

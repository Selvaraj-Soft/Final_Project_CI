using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Text_methods
    {
     public static string mytext= "My pensive SARA!they soft cheek reclined Thus on mine arm, most soothing sweet it is";


       static void substring()
        {
            Console.WriteLine("Substring--->"+Text_methods.mytext.Substring(10));
        }

        static void str_contains()
        {
           Console.WriteLine( Text_methods.mytext.Contains("SARA"));

        }
        static void string_char()
        {        
            char[] ch = { 'R', 'A', 'J', 'U' };
            string str = new string(ch);
            Console.WriteLine("Charatcter to string---->"+str);
        }

        static void string_copy()
        {
            string str = string.Copy(Text_methods.mytext);
            Console.WriteLine("Copy String--->>>" + str);
        }

        static void indexof()
        {
            int str = Text_methods.mytext.IndexOf("SARA");
            int strA = Text_methods.mytext.IndexOf("arm");
            int str1 = Text_methods.mytext.IndexOf("soft",str,strA);
            int str2 = Text_methods.mytext.IndexOf("reclined");
            int str3 = Text_methods.mytext.IndexOf("reclined",4);
            Console.WriteLine("indexof----->>" + str);
            Console.WriteLine("indexof----->>" + strA);
            Console.WriteLine("indexof----->>" + str1);
            Console.WriteLine("indexof----->>" + str2);
            Console.WriteLine("indexof----->>" + str3);
        }
        static void replace()
        {
            string str = Text_methods.mytext.Replace("SARA", "RAJU");
            Console.WriteLine(str);

        }

        static void split()
        {
            string name = "Selva raj";
            string[] splitted_str = name.Split(' ');
            foreach (string result in splitted_str)
            {
                Console.WriteLine(result);
            }
        }

        static void substringA()
        {
            Console.WriteLine( Text_methods.mytext.Substring(15));
        }

        static void chararray()
        {
            char[] variable = Text_methods.mytext.ToCharArray();
            //for
            
            foreach (char data in variable)
            {
                Console.WriteLine(data);
            }
        }

        static void length()
        {
            string name = "Selvaraj";
            Console.WriteLine(name.Length);

        }

        static void splita()
        {

            try
            {
                int num = 10;
                string str = Convert.ToString(num);
                Console.WriteLine(str + "Conversion");

                int i;
                int j;
                string s = "selva";
                i = int.Parse(s);
                j = Convert.ToInt32(s);
                Console.WriteLine(i + "Conversion using parse");

                Console.WriteLine(j + "Conversion using ToInt32");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
           // Text_methods abc = new Text_methods();
            //substring();
            //string_char();
            //str_contains();
            //string_copy();
            //indexof();
            //replace();
           // split();
            //substringA();
          //  length();
            splita();
           // chararray();
            Console.ReadLine();          
        }
    }
}

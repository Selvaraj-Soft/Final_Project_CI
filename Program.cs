using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Programs
{

    public class AnotherClass
    {
        private string detail;
        public  void metho()
        {
            string result = "Available";
            this.detail = "test";

            Console.WriteLine(result);
            Console.WriteLine(detail);

            Random ran= new Random();
            int d = ran.Next();
            
            Console.WriteLine(d);
            if ( d >= 10)
            {
                int data = ran.Next(6, 14);
                Console.WriteLine(data + "   Random Numbers");
            }
           
        }
        
        public virtual void Replacingmetho()
        {
            Console.WriteLine("Virtual Function");
        } 

    }
class Program : AnotherClass
    {
        //  private int A=100;
        public override void Replacingmetho()
        {
            Console.WriteLine("Overided Virtual Function");
        }
        public Program()
            {

            Console.WriteLine("Constructor Shop");
        }
        public static void random()
        {
            
            bool list = false;

            Random obj = new Random();
            list = Convert.ToBoolean(obj.Next(0, 2));

            if (list)
            {
                Console.WriteLine("Shop1");
            }
            else
            {
                Console.WriteLine("Shop2");
            }

        }

        public static void types()
        {

            int a = 34;
            float b = 21;
            double c = 90.2;
            string d = "text";
            char e = 's';
            float f = 15.5f;

            float n1 = (float)1 / 3;
            double n2 = (double)1 / 3;

            Console.WriteLine(a + "\n " + b + "\n " + c + " \n" + d + " \n" + e + "\n " + f + "\n ");
            Console.WriteLine(n1 + "  " + n2);
            //float d=6.3.2FF;

        }
        public static void array()
        {
            int[] number = new int[3];
            string[] text = new string[4];
            char[] character = new char[5];
            float[] fvalue = new float[3];
            //  int[][] doub = new int[1][3];
            int[,] a = new int[5, 2];

            number[0] = 888;
            number[2] = 90;
            fvalue[0] = 9.5f;
            fvalue[1] = 8.0f;

            text[1] = "selva";
            text[3] = "raj";
            character[2] = 'y';
            character[0] = 's';

            Console.WriteLine("__" + text[1] + " " + text[3]);

            
        }

        public static void parse()
        {
            string a = "400";

            int b = Int32.Parse(a);

            int c = Convert.ToInt32(a);
            //bool d = Convert.ToInt32(a);

            Console.WriteLine(a + "_____" + b + "____");
        }

        public static void split_join()
        {
            string str = @"There is a aeroplane in the ground, please hav a look";
            string[] value = str.Split(',');
            char[] letter = str.ToCharArray();
            //foreach (char S in letter )
            //{
            //    Console.WriteLine(S);
            //}
            //char[] value1 = str.Split(' ');
            foreach (string result in value)
            {
                Console.WriteLine(result);
            }

        }

        public static void format()
        {
            int a = 900;
            string b = "Ragi";
            char c = 'R';

            Console.WriteLine("I spent {0} for {1}, to buy the {2} keychain", a, b, c);

            Random ran = new Random();
            int result = ran.Next(-2, 9);

            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine(result);
            }
        }

        public static void two_array()
        {

            int[,] obj = new int[,] { { 1, 2, 3, 4 }, { 10, 9, 8, 7 } };
            int[] obj1 = new int[] { 4, 5, 6, 7, 9, 100 };
            //int size = obj1.GetLength;



            int L1 = obj.GetLength(0);
            int L2 = obj.GetLength(1);
            Console.WriteLine(L1);
            Console.WriteLine(L2);
            //Console.WriteLine(obj.Length);
            //Console.WriteLine(obj1.Length);


            for (int i = 0; i < L1; i++)
            {
                for (int j = 0; j < L2; j++)
                {
                    Console.Write(obj[i, j]);
                }
            }

            string[] SArray = new string[] { "\n Selva  ", "raj  ", "Ragi  ", "nagarajan  ", "dharmar" };

            SArray.SetValue("Data  ", 3);
            Array.Clear(SArray, 1, 3);

            foreach (string A in SArray)
            {
                Console.Write(A);
            }

            Console.Write(SArray.Length);

        }

        private int ab = 200;
        public void modifiers(int A)
        {
            
            Console.WriteLine(ab);
            Console.WriteLine(A);
            Console.WriteLine(this.ab);
        }

        public static string text()
        {
            
            
           // Console.WriteLine(obj.ToString());
            return "this is text class";
         }

        public void Param(params int[] value)
        {

            foreach (int A in value)
            {
                Console.WriteLine(A);
            }

        }
        public static void Param_kywd(params int[] value)
        {
            foreach (int A in value)
            {
                Console.WriteLine("\n"+A);
            }

        }

        public static void recs()
        {
            recs();
            Console.WriteLine("1st statement executed");
            
        }
  static void Main(string[] args)
        {
            Program obj = new Program();

            //random();
           // types();
           // array();
            // parse();
            //split_join();
            //format();
            //two_array();
            //obj.modifiers(5);

            //text();
            //Console.WriteLine(text());
            //Console.WriteLine(text().ToString());
            //Console.WriteLine(obj.ToString());// This statement object is printed
            /////////////////////////////////
        //obj.Param(1, 2, 3, 5);
        // Program.Param_kywd(99, 1, 2,100,125,290);

            obj.metho();              //Inheritance

            AnotherClass act = new AnotherClass();
            act.Replacingmetho();
            obj.Replacingmetho();

            // recs();               //Recursion   //STACKOVERFLOW Exception
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Topics
{

    //Reflection
    public class Reflection_WK
    {   

        public string name
        {
            get;
            set;
        }

        public int  number
        {
            get;
            set;
        }

        public Reflection_WK()
        {
            Console.WriteLine("Default Constructor");
        }
        static void GetTypes()
        {
            Type type = typeof(Reflection_WK);

            Console.WriteLine("This Class name is --->>: " + type.Name);        //To get the class name using type obj in code

            Console.WriteLine("This Namespace name is ---->>>: " + type.Namespace); //To get the namespace name using type obj in code


            PropertyInfo[] getproperty = type.GetProperties();                  //to get the properties used in the code    

            Console.WriteLine("The list of properties of the Customer class are:--");

            foreach (PropertyInfo data in getproperty)
            {

                Console.WriteLine(data.Name);

            }
            ConstructorInfo[] constructorInfo = type.GetConstructors();      //to get the constructors used in the code    
            foreach (ConstructorInfo c in constructorInfo)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(constructorInfo);

            //int i = 42;
            string str = "I Got Output";
            type = str.GetType();
            System.Console.WriteLine(type+"  <<----Getting the variable type in the Code");

        }
        public static void Main(string[] args)
        {
            GetTypes();

            Reflection_WK obj = new Reflection_WK();
            

            Console.ReadLine();
        }
    }
}

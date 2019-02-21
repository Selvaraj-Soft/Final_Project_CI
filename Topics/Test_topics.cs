using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Test_topics : action_class
    {

        void method1()
        {
            Console.WriteLine("Ordinary class methods");
        }
        void method2()
        {
        }
        public interface myinterface
        {
            void interfacemethod();
        }

        public static void Main(string[] args)
        {
            Test_topics obj = new Test_topics();
            obj.abstract_method3();
            obj.interfacemethod3();
            Console.ReadLine();
        }
    }
    public interface myinterface2
    {
        void interfacemethod2();
        //void interfacemethod3() //interface members cannoit have a definition
        //{

        //}
    }

    public interface myinterface3
    {
        void interfacemethod3();
    }

   public abstract class myabstract_class: myinterface3
    {
        void abstract_method()
        {

        }
        void abstract_method2()
        {
            Console.WriteLine("Abstract method is executing from abstract class");
        }
        public void interfacemethod3()
        {
            Console.WriteLine("Interface method is executing from abstract class");
        }
        public abstract void abstract_method3();
        
    }

    public class action_class: myabstract_class
    {
        public override void abstract_method3()
        {
            Console.WriteLine("Abstract_class_overriden method executed");
        }
        
    }
}

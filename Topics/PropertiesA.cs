using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topics;

namespace Topics
{
    public class news :Exception
    {
        public string Daily_news { get; set; }
        public string stringdata { get; set; } = "VisualStudio2015";
        public int No_of_news
        {
            get
            {
                return No_of_news = 500;
            }

            set { }
        }

        static public void property()
        {
            
            news obj = new news();

            Console.WriteLine(obj.No_of_news);
            obj.Daily_news = "HINDU";
            string statement = "There are totally {0} num of  {1}  newspapers is available";
            Console.WriteLine(statement, obj.No_of_news, obj.Daily_news);

            Console.ReadLine();
        }

        static public void default_property()
        {
            news obj1 = new news();
            Console.WriteLine(obj1.stringdata);
        }
      }
    }
    public class PropertiesA
    {
    static void Main(string[] args)
        {

        news.default_property();
        news.property();
        Console.WriteLine("SomeValue");
        Console.ReadLine();

        }

    }
   





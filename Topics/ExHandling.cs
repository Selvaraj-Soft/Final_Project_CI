using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class ExHandling : Exception
    {
        static void Exceptn()
        {
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;
                Console.WriteLine(result);
            }
            catch (Exception error)
            {
                //Console.WriteLine(error);
                Console.WriteLine(error.ToString());
            }
        }

        static void Exceptn1()
        {
            ExHandling obj = new ExHandling();

            try
            {
                throw new MandatoryException("UserName", "txtUserName");

                if (obj == null)
                {
                    Exception ex = new Exception("Test");

                    throw ex;

                }
                throw new Exception("");

            }
            catch (MandatoryException ex)
            {
                Console.WriteLine(ex.strFieldName + "  " + ex.strMessage);
            }

            catch (ApplicationException ex)
            {
                Console.WriteLine(ex);
                throw ex;

            }
           

        }


        static void Main(string[] args)
        {
            Exceptn();
            Exceptn1();
            Console.ReadLine();
        }

}

    public class MandatoryException : Exception

    {
        public string strMessage = string.Empty;
        public string strFieldName = string.Empty;
        public MandatoryException(string strParamMessage, string strParamFieldName)
        {
            strMessage = strParamMessage;
            strFieldName = strParamFieldName;
        }
    }

}

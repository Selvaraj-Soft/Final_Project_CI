using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Topics
{
    class Files_IO_Workout
    {

        static void GetFileStatus()
        {
            String location_path = "F:\\Dummy\\MyResult\\MyDocument1.txt";
            FileInfo file = new FileInfo(location_path);
            bool Getfile = file.Exists;

            if (Getfile != true)
            {
                file.Create();
                Console.WriteLine("File is created Successfuly");
                if (Getfile)
                {
                    StreamWriter write = file.CreateText();
                    write.WriteLine("The System.IO namespace has various classes that are used for performing numerous operations");
                    write.Close();
                }
            }
            else
            {
                Console.WriteLine("Something went wrong_The file is already existed in this location");
            }
           // Console.WriteLine(Getfile);
        }

        public static void Main(string[] args)
        {
            GetFileStatus();
            Console.ReadLine();
        }
    }
}

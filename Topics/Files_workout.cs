using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Files_workout
    {
        static string path = "F:\\WorkSpace_C#\\";
        static void check_file()
        {
            
            if (File.Exists(path))
            {
                Console.WriteLine("File Already Existed");
                string[] content = File.ReadAllLines(path);
                foreach (var data in content)
                {
                    Console.WriteLine(data);
                }

                if (File.Exists(path+ "MyFile.txt"))
                {
                    File.Delete(path+ "MyFile.txt");
                    Console.WriteLine("Created File Deleted Succesfully");
                }
            }
            else
            {
                Console.WriteLine("Specified file not created yet");
                File.Create(path+ "MyFile.txt");
                Console.WriteLine("New File is created using File class");
            }

        }
        static void filecreate()
        {
            FileStream obj = new FileStream(path+"MyFile.txt", FileMode.Create);
        }
         static void filewrite()
        {
            try
            {
                FileStream obj = new FileStream(path+"MyResultFile.txt", FileMode.CreateNew,FileAccess.ReadWrite);
                obj.WriteByte((byte)5);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
         }

        static void writefile_stream()
        {

            StreamWriter write = new StreamWriter(path + "Content.txt");
            write.WriteLine("This class writes strings or append strings to a text file. We can write numbers or the textual representation of anything.") ;
            write.Close();
        }
        public static void Main(string[] args)
        {
            check_file();
            //filecreate();
            // filewrite();
            writefile_stream();
            Console.ReadLine();
        }

    }
}

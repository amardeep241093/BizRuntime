using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class FileStream
    {
      
        static void Main(string[] args)
        {
            File f1 = new File();
            f1.WriterForFile();
            f1.ReaderForFile();
            Writer();
            Reader();
            Console.Read();
        }

            public static void Writer()
            {
                StreamWriter writer = new StreamWriter(@"J:\CSharp.txt");//passes the path of the file
                writer.WriteLine("Welcome to Lara");//writing text
                writer.WriteLine("Welcome to India");//writing text
                writer.Close();//closing the method
            }

            public static void Reader()
            {
                StreamReader reader = new StreamReader(@"J:\CSharp.txt");//reading from file
                Console.WriteLine(reader.ReadToEnd());//reading all bytes from documents
                reader.Close();
            }

        }
        
    }
  class File
        { 
        public void WriterForFile()
        {
            StreamWriter writer = new StreamWriter(@"J:\C_Sharp.txt");//passes the path of the file
            writer.WriteLine("Warm Welcome to Bizruntime");//writing text
            writer.Close();//closing the method
        }

            public void ReaderForFile()
            {
                StreamReader reader = new StreamReader(@"J:\C_Sharp.txt");//reading from file
                Console.WriteLine(reader.ReadToEnd());//reading all bytes from documents
                reader.Close();
            }
        }
    


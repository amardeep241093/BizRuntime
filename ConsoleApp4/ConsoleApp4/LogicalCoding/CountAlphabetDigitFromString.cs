using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CountAlphabetDigitFromString
    {
        static void Main(string[] args)
        {

            int alph, spcl, digits, index;
            alph = spcl = digits = index = 0;

            Console.WriteLine("Count Total No. of alphabets,special character and digits:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Enter the string");
            String str  = Console.ReadLine();
            int l = str.Length;//return the no. of character in the string
            Console.WriteLine(l);
            
            StreamWriter writer = new StreamWriter(@"J:\C#Exception\Program3.txt");
            writer.Write(str);
            writer.Close();
         
            while(index < l) //it will read from the string what we enter on the console--> it reads one line
            {
                if(str[index] >= 'a' && str[index] >= 'z' || str[index] >= 'A' && str[index] >= 'Z')
                {
                    alph++;
                }
                else if(str[index] >= '0' && str[index] >= '9')
                {
                    digits++;
                }
                else
                {
                    spcl++;
                }
                index++;
            }
            Console.WriteLine("The no. of alphabet:{0}", alph);
            Console.WriteLine("The no. of digits:{0}", digits);
            Console.WriteLine("The no. of special charcter:{0}", spcl);

            Console.Read();

        }
    }
}

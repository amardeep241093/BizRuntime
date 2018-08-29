using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class Removing
    {
        static void Main(string[] args)
        {
           
            int[] arr = new int[10];

            Console.WriteLine("Enter the size of array");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the element in the array:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
                
            }
            Console.Write("The array before removing are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the element you want to remove:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("The array after removing are: ");
            for (int i = 0; i < n; i++)
            {
                if(arr[i] % num != 0 )
                {
                    
                    Console.Write( arr[i] + " ");
                }
            }
            Console.WriteLine();
           
            Console.Read();
        }
        }
    }
   
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{   // Indexer on an interface:
    public interface InterfaceIndexer
    {

        // Indexer declaration:
        int this[int index]
        {
            get;
            set;
        }
    }

    // Implementing the interface.
    class IndexerClass : InterfaceIndexer
    {
        private int[] arr = new int[10];//Array declaration

        public int this[int index]   // indexer declaration
        {
            get
            {
                // The arr object will throw IndexOutOfRange exception.
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }


    class MainClass
    {
        static void Main(String[] args)
        {
            IndexerClass test = new IndexerClass();
            System.Random rand = new Random();
            // Call the indexer to initialize its elements.
          
            
            for (int i = 0; i < 10; i++)
            {
                test[i]= rand.Next();
            }
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Element #{0} = {1}", i, test[i]);
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
      }
        }
    

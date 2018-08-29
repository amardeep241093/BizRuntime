using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //defining delegates
    public delegate String GreetingDele(String str1);
    public delegate int GreetingDelegate(int a, int b);
    public delegate bool GreetingDelegate1(String str1,String str2);
    public delegate void NumberChanger(int n);
    //the method which does not have any name,it have only body.We can define it by using delegate keyword
    class AnonymousMethod
    {
        /*
        public static String Greeting(String str)
        {
            return "Amar" + str + " " + "Kumar";
        }
        */
        //static void Main(string[] args)
        //{
            /*
            GreetingDele gd = new GreetingDele(Greeting);
            String str2  = gd.Invoke("deep");
            Console.WriteLine(str2);
            Console.Read();
            */

            /* 
              GreetingDele gd = delegate (String str) //use delegate keyword and type of parameter
              {
                  return "Amar" + str + " " + "Kumar";
              }; //anonymous method always end with a semicolon
              String str1 = gd.Invoke("deep");
              Console.WriteLine(str1);
              Console.Read();
              */

            //GreetingDelegate gd1 = delegate (int a, int b)
            //{
            //    return a + b;
            //};
            //int sum = gd1.Invoke(20, 30);
            //Console.WriteLine(sum);
            //Console.Read();

            //GreetingDelegate1 gd1 = delegate (String str1, String str2)
            //{
            //    if (str1 == str2)
            //        return true;
            //    return false;
            //};

            //bool str3 = gd1.Invoke("Ram", "Ram");
            //bool str4 = gd1.Invoke("Ram", "Amar");
            //Console.WriteLine(str3);
            //Console.WriteLine(str4);

            //Console.Read();
            //Console.WriteLine("==========================");

            static int num = 10;

            public static void AddNum(int p)
            {
                num += p;
                Console.WriteLine("Named Method: {0}", num);
            }
            public static void MultNum(int q)
            {
                num *= q;
                Console.WriteLine("Named Method: {0}", num);
            }
            public static int getNum()
            {
                return num;
            }
          static void Main(string[] args)
            {
            //create delegate instances using anonymous method
            NumberChanger nc = delegate (int x) {
                    Console.WriteLine("Anonymous Method: {0}", x);
                };

                //calling the delegate using the anonymous method 
                nc(10);

                //instantiating the delegate using the named methods 
                nc = new NumberChanger(AddNum);

                //calling the delegate using the named methods 
                nc(5);

                //instantiating the delegate using another named methods 
                nc = new NumberChanger(MultNum);

                //calling the delegate using the named methods 
                nc(2);
                Console.ReadKey();
            }
        }
    }
   


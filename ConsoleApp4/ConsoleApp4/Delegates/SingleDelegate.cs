using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //1.defining a delegate with same signature & parameter as method
    public delegate void SumDelegate(int a, int b);
    public delegate String ProgramDelegate(String str);
    public delegate int MulDelegate(int c, int d);
    public delegate int DivDelegate(int i, int j);
    class SingleDelegate
    {
        public void sum(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        static String Program(String str)
        {
            return "Hello" + str;
        }

        public int Mul(int c, int d)
        {
           return (c * d);  
        }

        public static int Div(int i,int j)
        {
            return (i / j);
        }

        static void Main(string[] args)
        {
            SingleDelegate d1 = new SingleDelegate();
            // d1.sum(10, 20);
            //Console.WriteLine(Delegate1.Program(" " + "Amar"));
            //2.instantiating the delegating
            SumDelegate sd = new SumDelegate(d1.sum);
            sd(100, 200); //passing the required parameter and calling the delegate
            sd.Invoke(200, 300);
                

            ProgramDelegate pd = new ProgramDelegate(Program);
            Console.WriteLine(pd("Amar"));
            Console.WriteLine(pd.Invoke("Ram"));

            MulDelegate md = new MulDelegate(d1.Mul); //non-static method call by ref of instance class
            Console.WriteLine("Mul:" + md(10, 2));

            DivDelegate dv = new DivDelegate(Div);
            Console.WriteLine("Div:" + dv(100, 2));

            Console.Read();
        }
    }
}

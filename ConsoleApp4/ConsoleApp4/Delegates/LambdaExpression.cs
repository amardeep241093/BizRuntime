using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public delegate String LambdaDelegate(String name);
    public delegate bool LambdaDelegate1(String str);
    public delegate int FuncLambda(int i, int j);
    public delegate void ActionLambda(int i, int k, int l);
    public delegate int predicateLambda(String str);

    class LambdaExpression
    {
        static void Main(string[] args)
        { //no need of delegate keyword and parameter type becoz delegate already know written type is string
            LambdaDelegate gd = name =>
            {
                return "Bizruntime" + name + " " + "Service pvt. ltd.";
            };
            String name1 = gd.Invoke("It");
            Console.WriteLine(name1);
            Console.WriteLine("=====================");


            LambdaDelegate1 ld1 = str =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };

            bool b1 = ld1.Invoke("Amardeep");
            Console.WriteLine(b1);
            Console.WriteLine("==========================");

            Func<int, int, int> func = (i, j) =>
                {
                    return i + j;
                };
            int sum = func.Invoke(20, 30);
            Console.WriteLine(sum);

            Action<int, int, int> action = (i, k, l) =>
            {
                Console.WriteLine(i + k + l);
            };
           action.Invoke(20, 30, 50);

            Predicate<String> pl = (str) =>
            {
                if (str.Length > 10)
                    return true;
                return false;
            };
            bool b = pl.Invoke("Amardeep");
            Console.WriteLine(b);

            Console.Read();
        }
     

        }
    }
    
    


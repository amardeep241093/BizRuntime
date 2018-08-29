using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class GenericDelegate //executing og multiple task at a time is delegate
    {
        public void method1(int i, double d, float f)
        {
            Console.WriteLine("the result of void is: " + i + d + f);
        }
        public int method2(int i, byte d)
        {
            return (i + d);
        }
        public double method3(int i, double d, float f)
        {
            return (i + d + f);
        }
        public float method3(float a, float f)
        {
            return (a + f);
        }
        public String method4(String a, String b)
        {
            return "Amar" + a + b;

        }
        public bool method5(String a)
        {
            if (a.Length == 5)
                return true;
            return false;
        }
        public static void method6(int i, double b, float f)
        {
            Console.WriteLine("The result of static action is:" + i + b + f );
        }
        public static String method7(String a, String b, String c)
        {
            return "Sandeep" + a + b;
        }
        public static int method8(int i, int j, int k, byte b)
        {
            return i + b + k;
        }
        public static int method9(int a, byte b)
        {
            return  a + b;
        }
        public static bool method10(int a)
        {
            if (a >= 10)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            GenericDelegate gd = new GenericDelegate();
            //used for void reutrn type
            Action<int, double, float> action = gd.method1;
            action += method6;
            action(10, 2.5, 3.6f);

            //used for value return type 
            Func<int, byte, int> func = gd.method2;
            func += method9;
            int result = func(10, 20);
            Console.WriteLine("the result of function 10 & 20 : " + result);

            Func<int, int, int , byte, int> func1 = method8;
            int result1 = func1.Invoke(10, 20, 30, 5);
            Console.WriteLine("the result of function1: " + result1);

            Func<String, String, String> func2 = gd.method4;
            String result3 = func2.Invoke("Ram", "Shyam");
            Console.WriteLine("the result of function 10 & 20 : " + result3);

            Func<int, bool> func3 = method10;//predicate can be also used in the Func generic by providing the output data type
            bool result4 = func3.Invoke(35);
            Console.WriteLine(func3);

            //used for boolean return type and takes 1 parameter only
            //  Predicate<String, String> predicate1 = gd.method5; //not valid only 1 argument
            Predicate<String> predicate1 = gd.method5;
            predicate1("Amardeep");

            Predicate<int> predicate2 = method10;
            predicate2(10);

            Console.Read();
        }

    }
}

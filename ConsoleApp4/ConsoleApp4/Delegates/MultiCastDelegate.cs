using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public delegate void rectangleDele(int a, int b);
    public delegate String rectDele(String str);
    public delegate int multiDele(int p, int r);

    class MultiCastDelegate //same signature with all method(return type and data type)
    {//return type should be void bcoz first value return is overriden by second value reutn type method
        public void Rectangle(int a, int b)
        {
            Console.WriteLine("Area of Rectangle:" + (a * b));
        }

        public void PerimeterRectangle(int a, int b)
        {
          Console.WriteLine("Perimeter of rectangle:" + 2 * (a + b));
        }

        public String Name(String str)//parameter are same
        {
            return "Hello" + str;
        }
        public String name(String str1)
        {
            return "Bizruntime" + str1;
        }
        public int Name1(int a, int b)//parameter are same
        {
            return (a - b);
        }
        public int Name2(int c, int d)
        {
            return (d * c);
        }

        static void Main(string[] args)
        {
            
            MultiCastDelegate md = new MultiCastDelegate();
            /*  rectangleDele rd = md.Rectangle;//using same ref. variable
              rd += md.PerimeterRectangle;//execute boh the method
             // rd = md.PerimeterRectangle;//override the first method value
              rd(10, 20);
              rd.Invoke(30, 10);
              rd(5, 10);
              */

            /*   
               rectDele rd1 = md.Name;  //return type is string...so it is overriding the value
               rd1 +=  md.name;            
               String s1 = rd1.Invoke("Amar");
               Console.WriteLine("The return type value" + s1);
           */

            multiDele md1 = md.Name1;
            md1 += md.Name2;
            int i =  md1(20, 9);
            Console.WriteLine(i);
            Console.Read();

        }
    }
}

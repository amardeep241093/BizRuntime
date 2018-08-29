using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employee
    {
        String Ename, ECompany, Eaddress;
        int Eid, Eage, Ereg;

        public Employee(String Ename, String ECompany, String Eaddress, int Eid, int Eage, int Ereg)
        {
            this.Ename = Ename;
            this.ECompany = ECompany;
            this.Eaddress = Eaddress;
            this.Eid = Eid;
            this.Eage = Eage;
            this.Ereg = Ereg;

        }
        //modifier<type> this[parameter-type]
        public Object this[int index] //just like property to get and set accessor//indexer
        {
            get
            {
                if (index == 0)
                    return Ename;
                else if (index == 1)
                    return ECompany;
                else if (index == 2)
                    return Eaddress;
                else if (index == 3)
                    return Eid;
                else if (index == 4)
                    return Eage;
                else if (index == 5)
                    return Ereg;
                return null;
            }

            set//value keyword is used to assign by set indexer
            {
                if (index == 0)
                    Ename = (String)value;//unboxing-converting object value to value type
                else if (index == 1)
                    ECompany = (String)value;
                if (index == 2)
                    Eaddress = (String)value;//unboxing-converting object value to value type
                else if (index == 3)
                    Eid = (int)value;
                if (index == 4)
                    Eage = (int)value;//unboxing-converting object value to value type
                else if (index == 5)
                    Ereg = (int)value;
            }
        }
           //indexer with string type
          public Object this[String name] //just like property to get and set accessor//indexer///declaration of indexer
        {
            get //accessing by String name
            {
                if (name == "Ename")
                    return Ename;
                else if (name == "ECompany")
                    return ECompany;
                else if (name == "Eaddress")
                    return Eaddress;
                else if (name == "Eid")
                    return Eid;
                else if (name == "Eage")
                    return Eage;
                else if (name == "Ereg")
                    return Ereg;
                return null;
            }
        }
    }

        class Indexer
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee("Amar", "Bizruntime", "Btm", 101, 24, 267001);
                Console.WriteLine("Ename" + emp[0]); //get accessing the value by index
                Console.WriteLine("ECompny" + emp[1]);
                Console.WriteLine("Eaddress" + emp[2]);
                Console.WriteLine("Eid" + emp[3]);
                Console.WriteLine("Eage" + emp[4]);
                Console.WriteLine("Ereg" + emp[5]);

                emp[3] = 102; //we are updating tthe value
                emp[0] = "Deep";
            Console.WriteLine();
            Console.WriteLine("After updating:");
            Console.WriteLine("Ename" + emp[0]); //get accessing the value by index
            Console.WriteLine("ECompny" + emp[1]);
            Console.WriteLine("Eaddress" + emp[2]);
            Console.WriteLine("Eid" + emp[3]);
            Console.WriteLine("Eage" + emp[4]);
            Console.WriteLine("Ereg" + emp[5]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ename" + emp["Ename"]); //get accessing the value by index
            Console.WriteLine("ECompny" + emp["ECompany"]);
            Console.WriteLine("Eaddress" + emp["Eaddress"]);
            Console.WriteLine("Eid" + emp["Eid"]);
            Console.WriteLine("Eage" + emp["Eage"]);
            Console.WriteLine("Ereg" + emp["Ereg"]);
            Console.Read();
            }
        }  
}


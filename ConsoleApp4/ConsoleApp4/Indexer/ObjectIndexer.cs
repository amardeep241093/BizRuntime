using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employee1
    {
        Object Ename, Eid, Elocation, Ecompany, Edesign, Esalary;

        public Employee1(Object Ename, Object Eid, String Elocation, Object Ecompany, String Edesign, Object Esalary)
        {
            this.Ename = Ename;
            this.Eid = Eid;
            this.Elocation = Elocation;
            this.Ecompany = Ecompany;
            this.Edesign = Edesign;
            this.Esalary = Esalary;
        }
        /*C# does not limit the index type to integer. For example, it may be useful to use a string with an indexer.
         * Such an indexer might be implemented by searching for the string in the collection, and returning the appropriate value. 
       
    */
        public Object this[Object obj] //String is object type--> so it is accepting string type //declaration of indexer
        {
            get
            {
                if (obj == "Ename")
                    return Ename;
                else if (obj == "Eid")
                    return Eid;
                else if (obj == "Ecompany")
                    return Ecompany;
                else if (obj == "Elocation")
                    return Elocation;
                else if (obj == "Edesign")
                    return Edesign;
                else if (obj == "Esalary")
                    return Esalary;
                return null;

               
            }
        }
    }

        class ObjectIndexer
        {
        static void Main(string[] args)
        {
            Employee1 emp1 = new Employee1("Ram", "Ram101", "BTM", "Bizruntime", "Software", 20000);
            Console.WriteLine("Ename:" + "  " + emp1["Ename"]);
            Console.WriteLine("Eid:" + "  " + emp1["Eid"]);
            Console.WriteLine("Elocation:" + "  " + emp1["Elocation"]);
            Console.WriteLine("Ecompany:" + "  " + emp1["ECompany"]);
            Console.WriteLine("Edesign:" + "  " + emp1["Edesign"]);
            Console.WriteLine("Esalary:" + "  " + emp1["Esalary"]);
            Console.Read();

        }
    }
}

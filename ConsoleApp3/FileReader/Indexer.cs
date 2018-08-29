using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class Employee
    {

        String Ename, Ecompany, Eaddress;
        int EId, Eage, Ereg;

        public Employee(String Ename, String Ecompany, String Eaddress, int EId, int Eage, int Ereg)
        {
            this.Ename = Ename;
            this.Ecompany = Ecompany;
            this.Eaddress = Eaddress;
            this.EId = EId;
            this.Eage = Eage;
            this.Ereg = Ereg;
        }

        public Object this[int index]
        {
            get
            {
                if (index == 0)
                    return Ename;
                else if (index == 1)
                    return Ecompany;
                else if (index == 2)
                    return Eaddress;
                else if (index == 3)
                    return EId;
                else if (index == 4)
                    return Eage;
                else if (index == 5)
                    return Ereg;
                return null;

            }
        }
    }
    class EmployeeDetails
    {
        static void Main(string[] arg)
        {
            Employee emp = new Employee("Amar", "Bizruntime", "Sarjapur", 101, 24, 253729);
            Console.WriteLine("Ename" + emp[0]);
            Console.WriteLine("Ecompany" + emp[1]);
            Console.WriteLine("Eaddress" + emp[2]);
            Console.WriteLine("EId" + emp[3]);
            Console.WriteLine("Eage" + emp[4]);
            Console.WriteLine("Ereg" + emp[5]);
            Console.Read();

        }
           
       
        
        }
    }
    


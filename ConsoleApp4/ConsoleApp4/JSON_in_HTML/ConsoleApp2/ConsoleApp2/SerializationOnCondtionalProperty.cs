using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_OnCondtional_Property
{
    class Employee
    {
        public String Name { get; set; }
        public Employee Manager { get; set; }

        public bool ShouldSerializeManager()
        {
            //dont serialize the manager if employee is a manager
            return (Manager != this);
        }
    }
    public class EmployeeMain
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Amardeep";
            Employee emp1 = new Employee();
            emp1.Name = "Rajdeep";

            emp.Manager = emp1;
            emp1.Manager = emp1;

            String json = JsonConvert.SerializeObject(new[] { emp, emp1 });
            Console.WriteLine(json);
            Console.Read();
        }
    }
}


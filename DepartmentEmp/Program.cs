using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DepartmentEmp
{
    public class Employee
    {
        public string ename { get; set; }
        public string city { get; set; }
        public double sal { get; set; }

    }
    public class Department
    {
        public int No { get; set; }
        public string Name { get; set; }
       
        public Employee[] Employees { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee[] e1 = new Employee[]
            {
              new Employee{ename="Rahul",city="Pune" ,sal=20000},
             new Employee{ ename = "Sham",city = "satara", sal=26000},
            };

            Employee[] e2 = new Employee[]
            {
              new Employee{ename="Radha",city="Sangli",sal=560000 },
               new Employee{ename="Gopal",city="Bihar",sal=40500 },
               new Employee{ename="Kunal",city="Uttrakhand" ,sal=10000},
            };
            Employee[] e3 = new Employee[]
            {
                 new Employee{ename="Ramesh",city="Madhyapradesh",sal=50000 },
                  new Employee{ename="Sumit",city="Zarkhand",sal=40000 },
                   new Employee{ename="Kumar",city="Bhopal",sal=30000 },
            };
             Department[] departments   = new Department[]
            {
                  new Department{No=1,Name="IT",Employees=e1},
                  new Department{No=2,Name="Science",Employees=e2},
                  new Department{No=3,Name="Art",Employees=e3},

            };
            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.No} {d.Name}");
                foreach (Employee e in d.Employees)
                {
                    Console.WriteLine($"\t {e.ename} -> {e.city}-> {e.sal }");
                }
            }

        }
    }
}








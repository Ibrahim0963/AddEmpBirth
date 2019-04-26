using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmpBirth
{
    class Program
    {
        struct Employee
        {
            public string EmpName;
            public DateOfBirth Date;
        }
        struct DateOfBirth
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static int count=0;
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            char menu;
            Console.Write("\n\nCreate a nested struct and store data in an array :\n");
            Console.Write("-------------------------------------------------------\n");

            List<Employee> emps = new List<Employee>(); // List<Employee> emp = new List<Employee>(); without this Employee emp;
            Employee emp;
           do
            {
                Console.Write("Name of the employee : ");
                emp.EmpName = Console.ReadLine();

                Console.Write("Input day of the birth : ");
                emp.Date.Day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input month of the birth : ");
                emp.Date.Month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input year for the birth : ");
                emp.Date.Year = Convert.ToInt32(Console.ReadLine());
                emps.Add(emp);
                // Console.WriteLine();
                Console.WriteLine("if you want to continue clik (y) else (n): ");
                menu = Console.ReadKey().KeyChar;
            }
            while (menu != 'n' && menu != 'N');
            Console.Clear();
            foreach (Employee E in emps)
            {
                Console.WriteLine("Employee Name : "+E.EmpName); // look 
                Console.WriteLine("Employee Date : "+E.Date.Day + "/" +E.Date.Month+ "/" + E.Date.Year); // look
                Console.WriteLine("---------------------------------------------------------------------");
         
            }
            Console.ReadKey();
        }
    }
}

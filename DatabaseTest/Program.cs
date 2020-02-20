using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var manager in new employeesEntities().dept_manager.Include(x => x.employees).Include(x => x.departments))
                Console.WriteLine($"{manager.employees.last_name} {manager.from_date} {manager.to_date} {manager.departments.dept_name}");


            Console.ReadLine();
        }
    }
}

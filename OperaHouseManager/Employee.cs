using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseManager
{
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int WeeklySalary { get; set; }
        public int PerformanceSalary { get; set; }


        public Employee() { }
        public Employee(string name, string pos, int weekSalary, int perfSalary)
        {
            Name = name;
            Position = pos;
            WeeklySalary = weekSalary;
            PerformanceSalary = perfSalary;
        }
    }
}

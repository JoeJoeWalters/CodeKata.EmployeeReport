using EmployeeReport.Kata.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport.Kata.Reporting
{
    public class EmployeeReporter : IEmployeeReporter
    {
        private List<Employee> _Employees;

        public EmployeeReporter()
        {
            _Employees = new List<Employee>(); // To stop the nullable error (as not declared as readonly)
        }

        public void Load(Employee[] employees)
        {
            _Employees = new List<Employee>(employees);
        }
        public List<Employee> Search(int age)
            => _Employees.Where(emp => emp.Age >= age).ToList();
        public List<Employee> Search(int age, string direction)
            => (direction == "asc") ? 
                Search(age).OrderBy(x => x.Name).ToList() :
                Search(age).OrderByDescending(x => x.Name).ToList();
    }
}

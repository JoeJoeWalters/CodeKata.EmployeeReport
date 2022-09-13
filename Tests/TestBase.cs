using EmployeeReport.Kata.Domain;
using EmployeeReport.Kata.Reporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport.Kata.Tests
{
    public class TestBase
    {
        internal readonly Employee[] data = new Employee[]
            { 
                new Employee("max", 17),
                new Employee("sepp", 18),
                new Employee("nina", 15),
                new Employee("mike", 51)
            };

        public readonly IEmployeeReporter Reporter;

        public TestBase(IEmployeeReporter reporter)
        {
            Reporter = reporter;
            reporter.Load(data);
        }
    }
}

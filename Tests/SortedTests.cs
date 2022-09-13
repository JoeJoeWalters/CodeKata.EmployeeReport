using EmployeeReport.Kata.Domain;
using EmployeeReport.Kata.Reporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport.Kata.Tests
{
    public class SortedTests : TestBase
    {
        public SortedTests(): base(new EmployeeReporter())
        {

        }

        [Theory]
        [InlineData("asc", new string[] { "max", "mike", "nina", "sepp" })]
        public void Get_Employees_Over_Age(string direction, string[] expectedOrder)
        {
            // ARRANGE
            List<Employee> found;
            int age = 0;

            // ACT
            found = base.Reporter.Search(age, direction);

            // ASSERT
            Assert.Equal(expectedOrder, found.Select(x => x.Name).ToArray());
        }
    }
}

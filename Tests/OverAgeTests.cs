using EmployeeReport.Kata.Domain;
using EmployeeReport.Kata.Reporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport.Kata.Tests
{
    public class OverAgeTests : TestBase
    {
        public OverAgeTests(): base(new EmployeeReporter())
        {

        }

        [Theory]
        [InlineData(18, 2)]
        public void Get_Employees_Over_Age(int age, int expectedNumber)
        {
            // ARRANGE
            List<Employee> found;

            // ACT
            found = base.Reporter.Search(age);

            // ASSERT
            Assert.Equal(expectedNumber, found.Count);
        }
    }
}

using EmployeeReport.Kata.Domain;

namespace EmployeeReport.Kata.Reporting
{
    public interface IEmployeeReporter
    {
        void Load(Employee[] employees);

        List<Employee> Search(int age);
        List<Employee> Search(int age, string direction);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;
        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }

        public IEmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body = string.Join(Environment.NewLine, _employees.Select(x => $"Employee: {x.Name}\t\tSalary: {x.Salary}$"));
            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer = "-------------------------------------------------------------------";
            _employeeReport.Footer += $"Total salary: {_employees.Sum(x => x.Salary)}";
            return this;
        }

        public IEmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header = $"Employees REPORT ON DATE: {DateTime.Now}";
            return this;
        }

        public EmployeeReport GetReport()
        {
            var employeeReport = _employeeReport;
            _employeeReport = new();
            return employeeReport;
        }
    }
}

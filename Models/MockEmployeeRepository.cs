using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1,Name="Tasfia",Department=Dept.HR,Email="tasfia@mail.com"},
                new Employee(){Id=2,Name="Adeeb",Department=Dept.IT,Email="adeeb@mail.com"},
                new Employee(){Id=3,Name="Nabila",Department=Dept.Accounts,Email="nabila@mail.com"}
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) +1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int Id)
        {
           Employee employee = _employeeList.FirstOrDefault(e => e.Id == Id);
            if (employee!=null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == Id);
        }

    }
}
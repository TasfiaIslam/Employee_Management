using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
    }
}

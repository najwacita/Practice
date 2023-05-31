using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netways.Employee
{
    public interface IEmployeeManager
    {
        //printHelloMessage(IEnumerable<Employee> employees)
        public void PrintHelloMessage(IEnumerable<Employee> employees);
        public IEnumerable<Employee> GetEmployeeByDepartmentId(IEnumerable<Employee> employees, int departmentId);
        public IEnumerable<Employee> AddEmployee(List<Employee> employees, Employee employee);
        public Employee UpdateEmployee(List<Employee> employees, Employee employee);
        public Employee RemoveEmployee(List<Employee> employees,  Employee employee);


    }
}

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Netways.Employee
{
    public class EmployeeManager : IEmployeeManager
    {

        public void PrintHelloMessage(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"hello {item.FirstName}");
            }
        }

        public IEnumerable<Employee> GetEmployeeByDepartmentId(IEnumerable<Employee> employees, int departmentId)
        {
            return employees.Where(d => d.DepartmentId == departmentId);
        }

        public IEnumerable<Employee> AddEmployee(List<Employee> employees, Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public Employee UpdateEmployee(List<Employee> employees, Employee employee)

        {

            if (employees.Find(c => c.Id == employee.Id) != null) 
            {
                var updateEmployee = employees.FirstOrDefault(c => c.Id == employee.Id);
                //employees.FirstOrDefault(c => c.Id == employee.Id) = employee;
                if (updateEmployee != null)

                {

                    employee.FirstName = updateEmployee.FirstName;
                    employee.LastName = updateEmployee.LastName;
                    employee.DateOfBirth = updateEmployee.DateOfBirth;

                    int index = employees.IndexOf(employee);

                    employees[index] = updateEmployee;


                }
                return employee;

            }
            return employee;
        }


            /* var updateEmployee = employees.FirstOrDefault(c => c.Id == employee.Id);
             if (updateEmployee != null)

             {

                 employee.FirstName = updateEmployee.FirstName;
                 employee.LastName = updateEmployee.LastName;
                 employee.DateOfBirth = updateEmployee.DateOfBirth;
                 return employee;

             }
             else return employee;

         }*/


            public Employee RemoveEmployee(List<Employee> employees, Employee employee)

            {
                var removeEmployee = employees.Find(ctx => ctx.Id == employee.Id);
                if (removeEmployee != null)
                {
                    employees.Remove(removeEmployee);
                    int index = employees.IndexOf(employee);
                    if (index != -1)
                    {
                        employees[index] = removeEmployee;
                    }
                    return employee;



                }
                else return employee;

            }

        }
    }

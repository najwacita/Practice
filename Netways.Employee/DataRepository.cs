using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netways.Employee
{
    public class DataRepository: IDataRepository
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
             new Employee { Id = 234, DepartmentId = 101, FirstName = "ayman ", LastName = "test" ,DateOfBirth=new DateTime(2015-05-05)},
             new Employee(235, 101, "mira", "test", DateTime.Now.AddYears(-23)),
             new Employee { Id = 244, DepartmentId = 102, FirstName = "Moni", LastName = "loli",DateOfBirth=new DateTime(2015-05-05) },
             new Employee { Id = 734, DepartmentId = 103, FirstName = "rarsha", LastName = "mosh" ,DateOfBirth=new DateTime(2015-05-05)},
            };
        }

        public IEnumerable<Department> GetDepartments()
        {
            return new List<Department>
            {
             new Department { Id = 101, Name="HR" },
             new Department{Id = 102, Name="Accounts"},
             new Department{Id = 103, Name="Back-end"},
            };
        }
    }

}

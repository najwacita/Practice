using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netways.Employee
{
    public  interface IDataRepository
    {
        // List<Employee> GetAll();
      public  IEnumerable<Employee> GetEmployees();
        public IEnumerable<Department> GetDepartments();


    }
}

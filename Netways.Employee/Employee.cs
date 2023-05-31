using System.Globalization;

namespace Netways.Employee
{
    public class Employee
    {
        public int Id { get; set; }
       
        public int DepartmentId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }


        public Employee()
        {
            
        }

        public Employee(int id, int departmentId, string firstName, string lastName, DateTime dateOfBirth)
        {
            this.Id = id;
            this.DepartmentId = departmentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }
    }


}
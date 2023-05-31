using Autofac;
using Netways.Employee;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

var mockGenerator = new DataRepository();

var builder = new ContainerBuilder();
builder.RegisterType<Employee>();
builder.RegisterType<EmployeeManager>().AsSelf();
IContainer container = builder.Build();
container.Resolve<Employee>();
container.Resolve<EmployeeManager>();
var employeeManager = container.Resolve<EmployeeManager>();

//var employeeManager = new EmployeeManager();
//private IDataRepository dataRepository;


//Employee oEmp = new Employee();
// oEmp.FirstName = "lol";


// oEmp.LastName = "mol";
//oEmp.Age = 25;

//EmployeeManager empMana = new EmployeeManager();
//empMana.PrintHelloMessage(oEmp);

var employees = mockGenerator.GetEmployees().ToList();
var departments = mockGenerator.GetDepartments();

//employeeManager.PrintHelloMessage(employees);
var employeeByDepartment = employeeManager.GetEmployeeByDepartmentId(employees, 101);

foreach (var item in employeeByDepartment)
{
    Console.WriteLine($"first name : {item.FirstName}, departmentId = {item.DepartmentId}");
}

var newListOfEmplyee = employeeManager.AddEmployee(employees, new Employee(303, 101, "hanna", "nassar", DateTime.Now));
employeeManager.PrintHelloMessage(newListOfEmplyee);
var newListUpdateOfEmployee = employeeManager.UpdateEmployee(employees, new Employee(303, 101, "nnana", "sari", new DateTime(2019, 05, 08)));

Console.WriteLine($"first name : {newListUpdateOfEmployee.FirstName},{newListUpdateOfEmployee.LastName}, departmentId = {newListUpdateOfEmployee.DepartmentId},{newListUpdateOfEmployee.DateOfBirth}");


var newListDeleteOfemployee = employeeManager.RemoveEmployee(employees, new Employee(303, 101, "hanna", "nassar", DateTime.Now));
Console.WriteLine(newListDeleteOfemployee.ToString());



//var newListOfEmplyee = employeeManager1.AddEmployee(employees, new Employee(303, 101, "hanna", "nassar", DateTime.Now));
//employeeManager1.PrintHelloMessage(newListOfEmplyee);



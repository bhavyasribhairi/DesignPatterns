// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");

EmployeePrototype emp1 = new PermanentEmployeeConcretePrototype()
{
    Name = "Bhavya",
    Department = "CSE",
    Salary = 10000,
    EmploymentType = "FullTime"
};


EmployeePrototype emp2 = emp1;
emp2.Name = "Kavya";
emp2.Department = "MECH";
Console.WriteLine("Showing employee1");
emp1.ShowDetails();
Console.WriteLine("Showing employee2");
emp1.ShowDetails();


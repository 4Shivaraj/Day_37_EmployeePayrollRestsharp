using System;

namespace EmployeePayrollRestSharp
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Employee Payroll using RestSharp!");
        }
    }
}

/*
UC-5
Ability to Delete Employee from Employee Payroll JSON Server
- Use JSON Server and RESTSharp to then delete the employee by ID
- Delete the Employee from the Memory

{
  "employees": [
    {
      "id": 1,
      "name": "Shivaraj",
      "Salary": "100000"
    },
    {
      "id": 2,
      "name": "Cheluvesha",
      "Salary": "98665"
    },
    {
      "id": 3,
      "name": "Deepak",
      "Salary": "80000"
    },
    {
      "id": 4,
      "name": "Naresh",
      "Salary": "71400"
    },
    {
      "name": "Mounesh",
      "salary": "78400",
      "id": 5
    },
    {
      "name": "Lisa",
      "salary": "95000",
      "id": 6
    },
    {
      "Name": "Kim ",
      "Salary": "125040",
      "id": 8
    }
  ]
}
 */
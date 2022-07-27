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
UC-4
Ability to Update Salary in Employee Payroll JSON Server
- Firstly Update the Salary in Memory
- Post that Use JSON Server and RESTSharp to Update the salary

Standard Output: 
{
  "name": "Lisa",
  "salary": "95000",
  "id": 6
}
 */
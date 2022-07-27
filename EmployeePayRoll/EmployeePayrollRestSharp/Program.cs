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
UC-3
Ability to add multiple Employee to the EmployeePayroll JSON Server
- Use JSON Server and RESTSharp to add multiple Employees to Payroll
- Ability to add using RESTSharp to JSONServer in the MSTest Test Case and then on success add to EmployeePayrollService
- Validate with the successful Count

Standard Output: 
{
  "Name": "Kylie ",
  "Salary": "885040",
  "id": 6
}
{
  "Name": "Kendall ",
  "Salary": "125030",
  "id": 7
}
{
  "Name": "Kim ",
  "Salary": "125040",
  "id": 8
}
 */
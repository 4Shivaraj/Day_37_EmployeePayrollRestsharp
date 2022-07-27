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
UC-2
Ability to add a new Employee to the EmployeePayroll JSON Server
- Use JSON Server and RESTSharp to save the EmployeePayroll Data of id, name, and salary
- Ability to add using RESTSharp to JSONServer in the MSTest Test Case and then on success add to Employee Payroll
- Validate with the successful Count

 Standard Output: 
{
  "name": "Mounesh",
  "salary": "78400",
  "id": 5
}
 */
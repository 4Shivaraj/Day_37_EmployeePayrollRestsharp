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
 * UC-1
Ability to Retrieve all Employees in EmployeePayroll JSON Server
- Use JSON Server and RESTSharp to save the EmployeePayroll Data of id, name, and salary
- Retrieve in the MSTest Test and corresponding update the Memory with the Data

 Standard Output: 
Id: 1	Name: Shivaraj	Salary: 100000
Id: 2	Name: Cheluvesha	Salary: 98665
Id: 3	Name: Deepak	Salary: 80000
Id: 4	Name: Naresh	Salary: 71400
 */
using System;

namespace EmployeePayrollADO.Net
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to EmployeePayroll ADO.Net!");
            EmployeeRepository repository = new EmployeeRepository();

            //UC 5
            repository.GetEmployeesFromForDateRange("2021 - 02 - 01");

        }
    }
}

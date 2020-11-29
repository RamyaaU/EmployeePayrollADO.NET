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
            //UC 2
            EmployeeRepository repository = new EmployeeRepository();
            repository.GetAllEmployees();

            //UC 3
            Console.WriteLine(repository.UpdateSalaryIntoDatabase("Teressa", 30000) ? "Update done successfully " : "Update Failed");
        }
    }
}

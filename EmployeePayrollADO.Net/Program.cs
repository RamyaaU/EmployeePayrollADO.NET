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
            //UC 6
            repository.FindGroupedByGenderData();
        }

        /// <summary>
        /// Adds the new employee into the database.
        /// </summary>
        public static void AddNewEmployee()
        {
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeModel model = new EmployeeModel();
            model.EmployeeName = "Dior";
            model.Address = "Orion";
            model.BasicPay = 30000;
            model.Deductions = 4000;
            model.Department = "IT";
            model.Gender = "F";
            model.PhoneNumber = 983798;
            model.NetPay = 833;
            model.Income_Tax = 32;
            model.StartDate = DateTime.Now;
            model.TaxablePay = 2300;
            Console.WriteLine(repository.AddEmployee(model) ? "Record inserted successfully " : "Failed");
        }
    }
}
      

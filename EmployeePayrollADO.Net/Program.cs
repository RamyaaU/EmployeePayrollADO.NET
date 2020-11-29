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

            //UC 8 
            repository.RetrieveEmployeeDetailsFromMultipleTables();
        }

        /// Adds the new employee into the database.
        public static void AddNewEmployee()
        {
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeModel model = new EmployeeModel();
            model.EmployeeName = "sam";
            model.Address = "chennai";
            model.BasicPay = 50000;
            model.Deductions = 4000;
            model.Department = "Sales";
            model.Gender = "M";
            model.PhoneNumber = 983798;
            model.NetPay = 66000;
            model.Income_Tax = 3200;
            model.StartDate = DateTime.Now;
            model.TaxablePay = 3200;
            Console.WriteLine(repository.AddEmployee(model) ? "Record inserted successfully " : "Failed");
        }
    }
}
      
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayrollADO.Net
{
    public class EmployeeRepository
    {
        //For sql authentication
        public static string connectionString = @"Data Source=RAMYA\SQLEXPRESS;Initial Catalog=payroll_services;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayroll
{
    public class EmployeeRepo
    {
        public static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConnectionString);

        public bool AddEmploye(EmployeeModel employee)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails", this.connection);
                    command.CommandType=System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                    command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", employee.Address);
                    command.Parameters.AddWithValue("@Department", employee.Department);
                    command.Parameters.AddWithValue("@Gender", employee.Gender);
                    command.Parameters.AddWithValue("@BasicPay", employee.BasicPay);
                    command.Parameters.AddWithValue("@Deducation", employee.Deduction);
                    command.Parameters.AddWithValue("@TaxablePAy", employee.TaxablePay);
                    command.Parameters.AddWithValue("@Tax", employee.Tax);
                    command.Parameters.AddWithValue("@NetPay", employee.NetPay);
                    command.Parameters.AddWithValue("@StartDate", employee.StartDate);
                    command.Parameters.AddWithValue("@City", employee.City);
                    command.Parameters.AddWithValue("@Country", employee.Country);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            { 
                connection.Close();
            }
        }
    }
}

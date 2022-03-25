using System;

namespace empPayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");

            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeName = "Rita";
            employee.PhoneNumber = "4534545487";
            employee.Address = "Chennai";
            employee.Department = "HR";
            employee.Gender = "F";
            employee.BasicPay = 3500.00;
            employee.Deduction = 250.00;
            employee.TaxablePay = 4353;
            employee.Tax = 345.5;
            employee.NetPay = 4000.00;
            employee.StartDate = DateTime.Now;
            employee.City = "Chennai";
            employee.Country = "Indian";


            repo.AddEmploye(employee);
        }
    }
}
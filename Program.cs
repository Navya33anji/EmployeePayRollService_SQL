using EmployeePayrollServices;
using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");

            EmployeeRepo repo = new EmployeeRepo();

            EmployeeModel model = new EmployeeModel();

            
            model.EmployeeName = "Tina";
            model.EmployeeAge = 24;
            model.EmployeeAdress = "Goa";
            model.EmployeeSalary = 34000;
            model.Gender = "F";
            model.ModifiedDate = Convert.ToDateTime("2021-10-25 20:50:42.773");

            //repo.AddEmployee(model);
            repo.GetAllEmployee();




        }
    }
}

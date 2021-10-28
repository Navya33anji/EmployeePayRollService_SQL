using EmployeePayrollService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayrollServices
{
    class EmployeeRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = Payroll_service; Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel();

                using (this.connection)
                {
                    string query = @"Select EmployeeID,EmployeeName,EmployeeAge,EmployeeAddress,Gender,EmployeeSalary,ModifiedDate from EmployeeTable1";
                    this.connection.Open();
                    var cmd = new SqlCommand(query, this.connection);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                           
                            employeeModel.EmployeeName = dr.GetString(1);
                            employeeModel.EmployeeAge = dr.GetInt32(2);                            employeeModel.Gender = dr.GetString(4);
                            employeeModel.EmployeeSalary = dr.GetInt32(5);
                            employeeModel.ModifiedDate = dr.GetDateTime(6);

                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}",  employeeModel.EmployeeName, employeeModel.EmployeeAge,  employeeModel.Gender, employeeModel.EmployeeSalary, employeeModel.ModifiedDate);
                            Console.WriteLine("\n");
                        }
                    
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    dr.Close();



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                this.connection.Close();
            }
        }

       

    }
}

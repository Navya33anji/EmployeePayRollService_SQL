using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollService
{
    class EmployeeModel
    {

        public int EmploeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeAdress { get; set; }
        public string Gender { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

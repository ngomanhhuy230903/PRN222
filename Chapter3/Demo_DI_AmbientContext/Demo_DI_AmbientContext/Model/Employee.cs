using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DI_AmbientContext.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public IDepartment EmployeeDept { get; private set; }

        // Default Constructor for .NET Core DI Container
        public Employee() { }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
        }

        public void AssignDepartment(IDepartment dept)
        {
            EmployeeDept = dept ?? throw new ArgumentNullException(nameof(dept));
        }

        public override string ToString()
        {
            return $"EmpID: {EmployeeId}, Emp Name: {EmployeeName}, " +
                   $"Department: {EmployeeDept.DeptName}";
        }
    }
}

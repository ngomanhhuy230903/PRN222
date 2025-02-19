using Demo_DI_Property_Injection.Model;

public class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    private IDepartment _employeeDept;

    public Employee(int id, string name)
    {
        EmployeeId = id;
        EmployeeName = name;
    }

    // Property Injection
    public IDepartment EmployeeDept
    {
        get
        {
            if (_employeeDept == null)
                _employeeDept = new Engineering();
            return _employeeDept;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), "Null value is not allowed");
            if (_employeeDept != null)
                throw new InvalidOperationException("Department has already been assigned");
            _employeeDept = value;
        }
    }

    public override string ToString()
    {
        return $"EmpID: {EmployeeId}, Emp Name: {EmployeeName}, Department: {_employeeDept.DeptName}";
    }
}

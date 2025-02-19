using Demo_DI_MethodInjection.Model;

public class Employee
{
    public int EmployeeId;
    public string EmployeeName;
    public IDepartment EmployeeDept;

    // Default Constructor added for .NET Core DI Container.
    // So that it can automatically create the instance.
    public Employee() { }

    // Parameterized Constructor
    public Employee(int id, string name)
    {
        EmployeeId = id;
        EmployeeName = name;
    }

    // Assign department using method injection
    public void AssignDepartment(IDepartment dept)
    {
        EmployeeDept = dept ?? throw new ArgumentNullException(nameof(dept), "Null");
        // Other business logic if required.
    }

    // Override ToString method for displaying employee details
    public override string ToString()
    {
        return $"EmpID: {EmployeeId}, Emp Name: {EmployeeName}, " +
               $"Department: {EmployeeDept?.DeptName ?? "Not Assigned"}";
    }
}

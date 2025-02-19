using System;
using Demo_DI_AmbientContext.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Demo_DI_AmbientContext
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Employee>()
                .AddTransient<MarketingProvider>()
                .AddTransient<DefaultDepartmentProvider>()
                .BuildServiceProvider();

            DepartmentProvider.Current = serviceProvider.GetService<MarketingProvider>();

            Employee emp1 = serviceProvider.GetService<Employee>();
            emp1.EmployeeId = 1;
            emp1.EmployeeName = "Jack";

            // Ensure EmployeeDept has a public setter
            typeof(Employee).GetProperty("EmployeeDept").SetValue(emp1, DepartmentProvider.Current.Department);

            Employee emp2 = serviceProvider.GetService<Employee>();
            emp2.EmployeeId = 2;
            emp2.EmployeeName = "David";

            typeof(Employee).GetProperty("EmployeeDept").SetValue(emp2, DepartmentProvider.Current.Department);

            Console.WriteLine(emp1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(emp2);
            Console.ReadLine();
        }
    }
}

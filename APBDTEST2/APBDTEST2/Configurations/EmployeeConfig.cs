using APBDTEST2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
namespace APBDTEST2.Configurations
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var employees = new List<Employee>();

            employees.Add(new Employee
            {
                IdEmployee = 1,
                FirstName = "JohnE",
                LastName = "MawE"
            });

            employees.Add(new Employee
            {
                IdEmployee = 2,
                FirstName = "SaraE",
                LastName = "CurryE"
            });
            builder.HasData(employees);

        }
    }
}

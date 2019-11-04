using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Tasfia",
                    Department = Dept.IT,
                    Email = "tasfia@mail.com"
                },
                 new Employee
                 {
                     Id = 2,
                     Name = "Adeeb",
                     Department = Dept.IT,
                     Email = "adeeb@mail.com"
                 }
            );

        }
    }
}

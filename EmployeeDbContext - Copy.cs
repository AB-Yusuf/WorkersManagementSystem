using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;

namespace EmployeeManagementSystem
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("name=employeedb")
        {
            Database.Initialize(false);
        }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            modelBuilder.Configurations.AddFromAssembly(currentAssembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
using Entities.Concrete;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class Context : DbContext
    {
        public Context([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

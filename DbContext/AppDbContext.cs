using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Concepts.Solid;

namespace C_Sharp_Concepts_And_OOP.OOPs
{
    // Abstract class : It is a class that can not be instantiated.
    // It's mainly used as a base class to provide common functionality.

    // Required Nuget Packages for run a migration:

    // dotnet add package Microsoft.EntityFrameworkCore --version 8.0.19
    // dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.19
    // SQLServer : dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.19
    // SQLite : dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.19
    // PostgreSQL : dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.11

    // Migration
    // dotnet ef migrations add InitialCreate
    // dotnet ef database update

    public class AppDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> option):base(option) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

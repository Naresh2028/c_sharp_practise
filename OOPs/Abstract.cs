using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts_And_OOP.OOPs
{
    // Abstract class : It is a class that can not be instantiated.
    // It's mainly used as a base class to provide common functionality.
    public class AppDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .ToTable("Users");
        //}
    }
}

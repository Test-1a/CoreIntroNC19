using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreIntroNC19.Models
{
    public class CoreIntroNC19Context : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public CoreIntroNC19Context (DbContextOptions<CoreIntroNC19Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>().HasData(
                 new Person { Id= 1, Age= 20, Name= "Kalle", Salary=20000},
                 new Person { Id= 2, Age= 45, Name= "Anna", Salary=15000},
                 new Person { Id= 3, Age= 62, Name= "Nisse", Salary=65000},
                 new Person { Id= 4, Age= 23, Name= "Pelle", Salary=10000}
                );
        }

    }

}

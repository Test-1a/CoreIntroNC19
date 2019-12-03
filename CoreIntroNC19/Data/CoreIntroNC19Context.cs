using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreIntroNC19.Models
{
    public class CoreIntroNC19Context : DbContext
    {
        public CoreIntroNC19Context (DbContextOptions<CoreIntroNC19Context> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}

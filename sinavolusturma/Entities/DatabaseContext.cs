using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinavolusturma.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public DbSet<question> questions { get; set; }
    }
}

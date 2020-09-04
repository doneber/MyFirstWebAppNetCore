using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAppNetCore.Entities
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Task> Tasks{set;get;}
        public TaskDbContext(DbContextOptions options) : base(options)
        {
        }

        protected TaskDbContext()
        {
        }
    }
}

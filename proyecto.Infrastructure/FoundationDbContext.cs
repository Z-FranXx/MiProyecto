using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Infrastructure
{
    internal class FoundationDbContext : DbContext
    {
        public FoundationDbContext(DbContextOptions<FoundationDbContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
    }
}

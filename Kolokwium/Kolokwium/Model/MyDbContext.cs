using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class MyDbContext : DbContext
    {

        public DbSet<Team> GetTeams { get; set; }

        public MyDbContext()
        { }

        public MyDbContext(DbContextOptions options) : base(options)
        { }
    }
}

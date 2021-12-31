using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentProject.Models;

namespace RentProject.Data
{
    public class RentProjectContext : DbContext
    {
        public RentProjectContext (DbContextOptions<RentProjectContext> options)
            : base(options)
        {
        }

        public DbSet<RentProject.Models.User> User { get; set; }

        public DbSet<RentProject.Models.Car> Car { get; set; }
    }
}

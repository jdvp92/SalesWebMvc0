using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc0.Models;

namespace SalesWebMvc0.Data
{
    public class SalesWebMvc0Context : DbContext
    {
        public SalesWebMvc0Context(DbContextOptions<SalesWebMvc0Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc0.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}

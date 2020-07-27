using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Entities
{
    public class CalculatorContext : DbContext
    {
        public CalculatorContext(DbContextOptions<CalculatorContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Log> Logs { get; set; }

    }
}

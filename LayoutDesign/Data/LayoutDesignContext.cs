using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LayoutDesign.Models;

namespace LayoutDesign.Data
{
    public class LayoutDesignContext : DbContext
    {
        public LayoutDesignContext (DbContextOptions<LayoutDesignContext> options)
            : base(options)
        {
        }

        public DbSet<LayoutDesign.Models.Employee> Employee { get; set; } = default!;
    }
}

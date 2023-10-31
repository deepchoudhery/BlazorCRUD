using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class NewDbContext : DbContext
    {
        public NewDbContext (DbContextOptions<NewDbContext> options)
            : base(options)
        {
        }

        public DbSet<Child> Child { get; set; } = default!;
    }

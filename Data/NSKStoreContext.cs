using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NSKStore.Models;

namespace NSKStore.Data
{
    public class NSKStoreContext : DbContext
    {
        public NSKStoreContext (DbContextOptions<NSKStoreContext> options)
            : base(options)
        {
        }

        public DbSet<NSKStore.Models.Products> Products { get; set; } = default!;
    }
}

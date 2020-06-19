using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudApiDefault.Models;

namespace CrudApiDefault.Data
{
    public class CrudApiDefaultContext : DbContext
    {
        public CrudApiDefaultContext (DbContextOptions<CrudApiDefaultContext> options)
            : base(options)
        {
        }

        public DbSet<CrudApiDefault.Models.Product> Product { get; set; }
    }
}

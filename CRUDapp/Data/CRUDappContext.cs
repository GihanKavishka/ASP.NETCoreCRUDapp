using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDapp.Models;

namespace CRUDapp.Data
{
    public class CRUDappContext : DbContext
    {
        public CRUDappContext (DbContextOptions<CRUDappContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDapp.Models.Person> Person { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consumer.Models;

namespace WebAPIInMemoryDB.Models
{
    public class BpiDBContext : DbContext
    {
        public DbSet<BpiItem> BpiItems { get; set; }

        public BpiDBContext(DbContextOptions<BpiDBContext> options)
            : base(options)
        {

        }
    }
}
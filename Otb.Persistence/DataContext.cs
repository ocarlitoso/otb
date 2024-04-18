using Microsoft.EntityFrameworkCore;
using Otb.Domain;
using System.Collections.Generic;

namespace Otb.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Institution> Institutions { get; set; }
    }
}
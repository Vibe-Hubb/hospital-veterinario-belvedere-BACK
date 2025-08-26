using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace HospVet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        base.OnModelCreating(modelBuilder);
        }
    }
}

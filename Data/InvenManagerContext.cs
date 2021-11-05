using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InvenManager.wwwroot.Models;
using InvenManager.Models;

namespace InvenManager.Data
{
    public class InvenManagerContext : DbContext
    {
        public InvenManagerContext (DbContextOptions<InvenManagerContext> options)
            : base(options)
        {
        }

        public DbSet<InvenManager.wwwroot.Models.AssetModel> AssetModel { get; set; }

        public DbSet<InvenManager.Models.Owner> Owner { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<AssetModel>()
                .ToTable("Assets", b => b.IsTemporal());
        }

    }
}

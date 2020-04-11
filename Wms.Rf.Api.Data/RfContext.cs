using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wms.Rf.Api.Models;

namespace Wms.Rf.Api.Data
{
    public class RfContext : DbContext
    {
        public RfContext(DbContextOptions<RfContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRFMenu>()
                .HasKey(x => new { x.StoreId, x.UserId });
            modelBuilder.Entity<UserRFMenu>()
                .HasOne(x => x.User).WithMany(x => x.UserRFMenus).HasForeignKey(x => x.UserId);
            modelBuilder.Entity<UserRFMenu>()
                .HasOne(x => x.Menu).WithOne(x => x.UserRFMenu).HasForeignKey<UserRFMenu>(x => x.MenuId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<RFMenu> RFMenu { get; set; }
        public DbSet<UserRFMenu> UserRFMenu { get; set; }
    }
}

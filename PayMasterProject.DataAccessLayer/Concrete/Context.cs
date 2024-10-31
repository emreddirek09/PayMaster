using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayMasterProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<User, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-68E6J3H6\\SQLEXPRESS; initial catalog=PayMasterDb; Trusted_Connection=true;TrustServerCertificate=True");
        }
        public DbSet<User> User {  get; set; }
        public DbSet<Site> Site {  get; set; }
        public DbSet<Daire> Daire {  get; set; }
        public DbSet<Block> Block {  get; set; }
        public DbSet<ApartmentDebts> ApartmentDebts {  get; set; }
         

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<int>>().HasKey(x => new { x.LoginProvider, x.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<int>>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserToken<int>>().HasKey(x => new { x.UserId, x.LoginProvider, x.Name });


            modelBuilder.Entity<ApartmentDebts>()
                .HasOne(d => d.Daire)
                .WithMany(d => d.Debts)
                .HasForeignKey(d => d.DebtDaireID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ApartmentDebts>()
                .HasOne(d => d.CreatedByAdmin)
                .WithMany(k => k.CreatedBorclar)
                .HasForeignKey(d => d.DebtCreatedByAdminId)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}

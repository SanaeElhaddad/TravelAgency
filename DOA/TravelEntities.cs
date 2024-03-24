using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyApp.Model;

namespace TravelAgencyApp.DOA
{
    public class TravelEntities:DbContext
    {
        public DbSet<Personnel> personnels { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Guide> guides { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Voyage> voyages { get; set; }
        public TravelEntities() : base("AgencyMapping") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Guide>().ToTable("Guide");
        }
    }
}

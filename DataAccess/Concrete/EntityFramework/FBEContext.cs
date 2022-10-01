using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FBEContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FBEData;Trusted_Connection=true");
        }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<AnnouncementCategory> AnnouncementCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Prelector> Prelectors{ get; set; }
        public DbSet<PrelectorPosition> PrelectorPositions { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}

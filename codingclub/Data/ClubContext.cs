using codingclub.Models;
using Microsoft.EntityFrameworkCore;

namespace codingclub.Data
{
    public class ClubContext : DbContext
    {
        public ClubContext(DbContextOptions<ClubContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().ToTable("Projects");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Member>().ToTable("Members");
        }
    }
}
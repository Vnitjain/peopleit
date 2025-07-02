using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;
using PeopleIT.Data.Models;

namespace PeopleIT.Data
{
    public class PeopleITDBContext : DbContext
    {
        public PeopleITDBContext(DbContextOptions<PeopleITDBContext> options) : base(options)
        {
        }
        public DbSet<Lead> Leads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lead>()
            .HasKey(l => new { l.QuoteSentDate, l.Salesperson, l.ProjectName });

        base.OnModelCreating(modelBuilder);
    }
    }
}
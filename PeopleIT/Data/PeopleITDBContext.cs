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
    }
}
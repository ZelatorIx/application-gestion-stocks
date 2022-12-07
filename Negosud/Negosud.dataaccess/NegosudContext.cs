using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess
{
    public class NegosudContext : DbContext
    {
        public NegosudContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Negosud;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Item> Items { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Client> Clients { get; set; }

        public static void InitDataDb()
        {
            using (NegosudContext context = new NegosudContext())
            {
                context.Families.Add(new Family() { Name = "Rosé" });
                context.Families.Add(new Family() { Name = "Rouge" });
                context.Families.Add(new Family() { Name = "Blanc" });
                context.Families.Add(new Family() { Name = "Champagne" });
                context.SaveChanges();
            }
        }
    }
}

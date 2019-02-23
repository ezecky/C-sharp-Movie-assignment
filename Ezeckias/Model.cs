using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EzeckiasApp.NewDb
{
    public class EzeckiasContext : DbContext
    {
        public DbSet<Ezeckiastbl> Ezeckiass { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.EzeckiasApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Ezeckiastbl
    {
        [Key]
        public int EzeckiasId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}
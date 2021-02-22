using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WPF_CRUD.Data
{
    public class GatunekDB : DbContext
    {

        public GatunekDB(DbContextOptions<GatunekDB> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Gatunek> Gatunek { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gatunek>().HasData(GetGatunek());
            base.OnModelCreating(modelBuilder);

        }

        private Gatunek[] GetGatunek()
        {
            return new Gatunek[]
            {
                new Gatunek { ID =1, nazwa ="fantastyczno-naukowa" },

            };
        }
    }

}

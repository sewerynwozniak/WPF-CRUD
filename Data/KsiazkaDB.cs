using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_CRUD.Data
{
    class KsiazkaDB : DbContext
    {

        public KsiazkaDB(DbContextOptions<KsiazkaDB> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Ksiazka> Ksiazka { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ksiazka>().HasData(GetKsiazka());
            base.OnModelCreating(modelBuilder);

        }

        private Ksiazka[] GetKsiazka()
        {
            return new Ksiazka[]
            {
                new Ksiazka { ID =1, gatunek ="sci-fi", tytul ="Solaris"},

            };
        }

    }
}

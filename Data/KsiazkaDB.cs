using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_CRUD.Data
{
    public class KsiazkaDB : DbContext
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
                new Ksiazka { ID =1, gatunek ="fantastyczno-naukowa", tytul ="Solaris", autor="Stanisław Lem", rok_wydania="1961", kod_ISBN="9780151628342" },

            };
        }

    }
}

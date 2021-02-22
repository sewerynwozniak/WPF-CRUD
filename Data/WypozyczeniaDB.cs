using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WPF_CRUD.Data
{
    public class WypozyczeniaDB : DbContext
    {

        public WypozyczeniaDB(DbContextOptions<WypozyczeniaDB> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Wypozyczenie> Wypozyczenie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wypozyczenie>().HasData(GetWypozyczenia());
            base.OnModelCreating(modelBuilder);

        }

        private Wypozyczenie[] GetWypozyczenia()
        {
            return new Wypozyczenie[]
            {
                new Wypozyczenie { ID =1, IDczytelnik =2, IDksiazka=3, data_wyp=new DateTime(2020, 6, 1), data_zwr=new DateTime(2020, 10, 5), zwrocona=true},

            };
        }

    }
}

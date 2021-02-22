using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WPF_CRUD.Data
{
    public class CzytelnikDB :DbContext
    {

        public CzytelnikDB(DbContextOptions<CzytelnikDB> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Czytelnik> Czytelnik { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Czytelnik>().HasData(GetCzytelnik());
            base.OnModelCreating(modelBuilder);


        }

        private Czytelnik[] GetCzytelnik()
        {
            return new Czytelnik[]
            {
                new Czytelnik { ID =1, imie ="Adam", nazwisko ="Mazur", miasto="Kraków", ulica="mogilska", nr_budynku="10", nr_tel="600500150"},
                
            };
        }


    }
}

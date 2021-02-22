using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_CRUD.Data
{
    public class Ksiazka
    {
        public int ID { get; set; }
        public string gatunek { get; set; }
        public string tytul { get; set; }
        public string autor { get; set; }
        public string rok_wydania { get; set; }
        public string kod_ISBN { get; set; }
    }
}

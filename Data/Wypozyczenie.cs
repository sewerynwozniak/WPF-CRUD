using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_CRUD.Data
{
    public class Wypozyczenie
    {

        public int ID { get; set; }
        public int IDczytelnik { get; set; }
        public int IDksiazka { get; set; }
        public DateTime data_wyp { get; set; }
        public DateTime data_zwr { get; set; }
        public bool zwrocona { get; set; }

    }
}

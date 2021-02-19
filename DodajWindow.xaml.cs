using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_CRUD.Data;

namespace WPF_CRUD
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class DodajWindow : Window
    {

        CzytelnikDB czytelnikDB;
        Czytelnik czytelnik = new Czytelnik();


        public DodajWindow(CzytelnikDB czytelnikDB)
        {
            this.czytelnikDB = czytelnikDB;
            InitializeComponent();
            addNewCzytelnik.DataContext = czytelnik;
        }



        private void AddCzytelnik(object sender, RoutedEventArgs e)
        {
            czytelnikDB.Czytelnik.Add(czytelnik);
            czytelnikDB.SaveChanges();
            czytelnik = new Czytelnik();
            this.Visibility = Visibility.Hidden;
        }
    }
}

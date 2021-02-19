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
    /// Logika interakcji dla klasy EdytujWindow.xaml
    /// </summary>
    public partial class EdytujWindow : Window
    {

        CzytelnikDB czytelnikDB;
        Czytelnik czytelnik = new Czytelnik();

        public EdytujWindow()
        {
            this.czytelnikDB = czytelnikDB;
            InitializeComponent();
            addNewCzytelnik.DataContext = czytelnik;
        }


        private void EditCzytelnik(object sender, RoutedEventArgs e)
        {
            czytelnikDB.Czytelnik.Add(czytelnik);
            czytelnikDB.SaveChanges();
            czytelnik = new Czytelnik();
            this.Visibility = Visibility.Hidden;
        }


    }
}

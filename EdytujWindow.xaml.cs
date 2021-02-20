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
        Czytelnik selectedCzytelnik = new Czytelnik();

        public EdytujWindow(CzytelnikDB czytelnikDB, Czytelnik selectedCzytelnik)
        {
            this.selectedCzytelnik = selectedCzytelnik;
            this.czytelnikDB = czytelnikDB;
            InitializeComponent();
            edytujCzytelnikGrid.DataContext = selectedCzytelnik;
        }



        private void edytujCzytelnikClick(object sender, RoutedEventArgs e)
        {
            czytelnikDB.Update(selectedCzytelnik);
            czytelnikDB.SaveChanges();
            this.Visibility = Visibility.Hidden;
        }
    }
}

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

        public EdytujWindow(CzytelnikDB czytelnikDB, Czytelnik selectedCzytelnik)
        {
            
            InitializeComponent();
            edytujCzytelnikGrid.DataContext = selectedCzytelnik;
        }



        private void editCzytelnikClick(object sender, RoutedEventArgs e)
        {

        }
    }
}

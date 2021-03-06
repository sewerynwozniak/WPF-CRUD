﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_CRUD.Data;

namespace WPF_CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CzytelnikDB czytelnikDB;
     

        public MainWindow(CzytelnikDB czytelnikDB)
        {

            this.czytelnikDB = czytelnikDB;
           
            InitializeComponent();
            GetCzytelnik();
            
        }

        private void GetCzytelnik()
        {
            CzytelnikDBGrid.ItemsSource = czytelnikDB.Czytelnik.ToList();
        }


        private void openDodajWindow(object sender, RoutedEventArgs e)
        {
            DodajWindow dodajwindow = new DodajWindow(czytelnikDB);
            dodajwindow.Show();
        }

        Czytelnik selectedCzytelnik = new Czytelnik();
        private void openEdytujWindow(object sender, RoutedEventArgs e)
        {
            selectedCzytelnik = (sender as FrameworkElement).DataContext as Czytelnik;
            EdytujWindow edytujWindow = new EdytujWindow(czytelnikDB, selectedCzytelnik);
            edytujWindow.Show();
        }

        Czytelnik selectedCzytelnikToDelete = new Czytelnik();
        private void usunRow(object sender, RoutedEventArgs e)
        {
            selectedCzytelnikToDelete = (sender as FrameworkElement).DataContext as Czytelnik;
            czytelnikDB.Czytelnik.Remove(selectedCzytelnikToDelete);
            czytelnikDB.SaveChanges();
            GetCzytelnik();
        }



        private void refreshDB(object sender, RoutedEventArgs e)
        {
            GetCzytelnik();
        }

    }
}

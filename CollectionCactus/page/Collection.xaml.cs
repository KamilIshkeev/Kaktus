﻿using CollectionCactus.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using CollectionCactus;
using System.Collections;


namespace CollectionCactus.page
{
    /// <summary>
    /// Логика взаимодействия для Collection.xaml
    /// </summary>
    public partial class Collection : Page
    {
        static MainWindow _mainWinsow;
        public Collection(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWinsow = mainWindow;
            ListCollection.ItemsSource = connect.db.Collection1.ToList();
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (ListCollection.SelectedItem != null)
            {
                int idSelectedCollection = (ListCollection.SelectedItem as Collection1).id_collection;
                Collection1 collect = (from r in connect.db.Collection1 where r.id_collection == idSelectedCollection select r).SingleOrDefault();
                connect.db.Collection1.Remove(collect);
                connect.db.SaveChanges();
                ListCollection.ItemsSource = connect.db.Collection1.ToList();
                MessageBox.Show("Коллекция удалена");
            }
            else
            {
                MessageBox.Show("Для удаления выберите строку");

            }


        }



    }

   
}

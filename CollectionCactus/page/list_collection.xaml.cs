using CollectionCactus.BC;
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
using CollectionCactus.page;

namespace CollectionCactus.page
{
    /// <summary>
    /// Логика взаимодействия для list_collection.xaml
    /// </summary>
    public partial class list_collection : Page
    {
        static MainWindow _mainWinsow;
        public list_collection(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWinsow = mainWindow;
            Lisstcollect.ItemsSource = connect.db.list_collection1.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {


            if (Lisstcollect.SelectedItem != null)
            {
                int idSelectedLisstcollect = (Lisstcollect.SelectedItem as list_collection1).id_list_collection;
                list_collection1 listcollect = (from r in connect.db.list_collection1 where r.id_list_collection == idSelectedLisstcollect select r).SingleOrDefault();
                connect.db.list_collection1.Remove(listcollect);
                connect.db.SaveChanges();
                Lisstcollect.ItemsSource = connect.db.list_collection1.ToList();
                MessageBox.Show("Инструкция удалена");
            }
            else
            {
                MessageBox.Show("Для удаления выберите строку");

            }

        }

    }
}

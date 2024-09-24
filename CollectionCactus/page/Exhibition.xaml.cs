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

namespace CollectionCactus.page
{
    /// <summary>
    /// Логика взаимодействия для Exhibition.xaml
    /// </summary>
    public partial class Exhibition : Page
    {
        static MainWindow _mainWinsow;

        public Exhibition(MainWindow mainWindow)
        { 
            InitializeComponent();
            _mainWinsow = mainWindow;
            ListExhibition.ItemsSource = connect.db.Exhibition1.ToList();
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (ListExhibition.SelectedItem != null)
            {
                int idSelectedExhibition = (ListExhibition.SelectedItem as Exhibition1).id_exhibition;
                Exhibition1 exhibition = (from r in connect.db.Exhibition1 where r.id_exhibition == idSelectedExhibition select r).SingleOrDefault();
                connect.db.Exhibition1.Remove(exhibition);
                connect.db.SaveChanges();
                ListExhibition.ItemsSource = connect.db.Exhibition1.ToList();
                MessageBox.Show("Выставка удалена");
            }
            else
            {
                MessageBox.Show("Для удаления выберите строку");

            }


        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListExhibition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

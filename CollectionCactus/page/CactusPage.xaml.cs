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
    /// Логика взаимодействия для CactusPage.xaml
    /// </summary> ааарпр
    public partial class CactusPage : Page
    {

        static MainWindow _mainWinsow;
        public CactusPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWinsow = mainWindow;

            

            ListCactus.ItemsSource = connect.db.Cactus.ToList();
        }

        private void ListCactus_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var temp = (Cactus)ListCactus.SelectedItem;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (ListCactus.SelectedItem != null)
            {
                int idSelectedPerson = (ListCactus.SelectedItem as Cactus).id_cactus;
                Cactus cactus = (from r in connect.db.Cactus where r.id_cactus == idSelectedPerson select r).SingleOrDefault();
                connect.db.Cactus.Remove(cactus);
                connect.db.SaveChanges();
                ListCactus.ItemsSource = connect.db.Cactus.ToList();
                MessageBox.Show("Кактус удален");
            }
            else
            {
                MessageBox.Show("Для удаления выберите строку");

            }

            //ListCactus.Items.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            //ListCactus.Items.Add();
        }
    }




}




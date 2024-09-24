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
    /// Логика взаимодействия для list_exhibition.xaml
    /// </summary>
    public partial class list_exhibition : Page
    {
        static MainWindow _mainWinsow;
        public list_exhibition(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWinsow = mainWindow;
            Listexhibitions.ItemsSource = connect.db.list_exhibition1.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (Listexhibitions.SelectedItem != null)
            {
                int idSelectedLisstexhibition = (Listexhibitions.SelectedItem as list_exhibition1).id_list_exhibition;
                list_exhibition1 listexhibition = (from r in connect.db.list_exhibition1 where r.id_list_exhibition == idSelectedLisstexhibition select r).SingleOrDefault();
                connect.db.list_exhibition1.Remove(listexhibition);
                connect.db.SaveChanges();
                Listexhibitions.ItemsSource = connect.db.list_exhibition1.ToList();
                MessageBox.Show("Инструкция удалена");
            }
            else
            {
                MessageBox.Show("Для удаления выберите строку");

            }

        }
    }
}

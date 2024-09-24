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

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (ListCactus.SelectedItem != null)
            {
                int idSelectedCactus = (ListCactus.SelectedItem as Cactus).id_cactus;
                Cactus cactus = (from r in connect.db.Cactus where r.id_cactus == idSelectedCactus select r).SingleOrDefault();
                connect.db.Cactus.Remove(cactus);
                connect.db.SaveChanges();
                ListCactus.ItemsSource = connect.db.Cactus.ToList();
                MessageBox.Show("Кактус удален");
            }
            else
            {
                MessageBox.Show("Для удаления выберите строку");

            }


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var idkak = Convert.ToInt32(id_kak.Text);
            string names = name_kak.Text;
            string typs = type.Text;
            string proish = prois.Text;
            var agess = Convert.ToInt32(ages.Text);
            var pricesss = Convert.ToInt32(prices.Text);
            var numsss_instr = Convert.ToInt32(num_instr.Text);

            var kak = connect.db.Cactus.FirstOrDefault(id => id.id_cactus == idkak && id.name == names && id.price == pricesss && id.age == agess && id.origin == proish && id.id_instruction == numsss_instr && id.tipe == typs);

            var kakTus = new Cactus()
            {
                id_cactus = idkak,
                name = names,
                price = pricesss,
                origin = proish,
                age = agess,
                tipe = typs,
                id_instruction = numsss_instr
            };

            connect.db.Cactus.Add(kakTus);
            connect.db.SaveChanges();
            MessageBox.Show("Кактус успешно был добавлен");
            return;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (ListCactus.SelectedItem != null)
            {
                int i = 0;
                if (i == 0)
                {
                    int id_selcactus = (ListCactus.SelectedItem as Cactus).id_cactus;
                    id_kak.Text = Convert.ToString(id_selcactus);
                    i++;
                }
                else if (i == 1)
                {
                    if (ListCactus.SelectedItem != null)
                    {

                        //id_kak.Text = id_cactus;
                        int idSelectedCactus = (ListCactus.SelectedItem as Cactus).id_cactus;
                        Cactus cactus = (from r in connect.db.Cactus where r.id_cactus == idSelectedCactus select r).SingleOrDefault();
                        connect.db.Cactus.Remove(cactus);
                        connect.db.SaveChanges();
                        ListCactus.ItemsSource = connect.db.Cactus.ToList();

                        var idkak = Convert.ToInt32(id_kak.Text);
                        string names = name_kak.Text;
                        string typs = type.Text;
                        string proish = prois.Text;
                        var agess = Convert.ToInt32(ages.Text);
                        var pricesss = Convert.ToInt32(prices.Text);
                        var numsss_instr = Convert.ToInt32(num_instr.Text);

                        var kak = connect.db.Cactus.FirstOrDefault(id => id.id_cactus == idkak && id.name == names && id.price == pricesss && id.age == agess && id.origin == proish && id.id_instruction == numsss_instr && id.tipe == typs);

                        var kakTus = new Cactus()
                        {
                            id_cactus = idkak,
                            name = names,
                            price = pricesss,
                            origin = proish,
                            age = agess,
                            tipe = typs,
                            id_instruction = numsss_instr
                        };
                        connect.db.Cactus.Add(kakTus);
                        connect.db.SaveChanges();
                        MessageBox.Show("Кактус был успешно редактирован");
                        return;
                    }

                }
            }
          

           
        }
    }

    } 




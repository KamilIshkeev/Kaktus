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
using CollectionCactus.page;
using CollectionCactus.BC;

namespace CollectionCactus.page
{
    /// <summary>
    /// Логика взаимодействия для Instruction.xaml
    /// </summary>
    /// 
    public partial class Instruction : Page
    {
        static MainWindow _mainWinsow;
        public Instruction(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWinsow = mainWindow;
            Instructio.ItemsSource = connect.db.instruction.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (Instructio.SelectedItem != null)
            {
                int idSelectedinstruction = (Instructio.SelectedItem as instruction).id_instruction;
                instruction instruction = (from r in connect.db.instruction where r.id_instruction == idSelectedinstruction select r).SingleOrDefault();
                connect.db.instruction.Remove(instruction);
                connect.db.SaveChanges();
                Instructio.ItemsSource = connect.db.instruction.ToList();
                MessageBox.Show("Инструкция удалена");
            }
            else
            {
                MessageBox.Show("Для удаления выберите строку");

            }


        }

    }


}

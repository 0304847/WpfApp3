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

namespace WpfApp8.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage18.xaml
    /// </summary>
    public partial class TaskPage18 : Page
    {
        public TaskPage18()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №18",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;

            }
            else
            {
                double y = Convert.ToDouble(Tby.Text);

                MessageBox.Show($" Z ={3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1)}",
                                "Задание №18",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;


            }
        }
    }
}

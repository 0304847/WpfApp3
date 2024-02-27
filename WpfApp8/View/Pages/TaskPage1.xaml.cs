using System;
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
    /// Логика взаимодействия для TaskPage1.xaml
    /// </summary>
    public partial class TaskPage1 : Page
    {
        public TaskPage1()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbt.Text) | string.IsNullOrEmpty(Tbl.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №1",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbt.Text = string.Empty;
                Tbl.Text = string.Empty;
            }
            else
            {
                double t = Convert.ToDouble(Tbt.Text), l = Convert.ToDouble(Tbl.Text);

                MessageBox.Show($" R ={3 * Math.Pow(t, 2) + 3 * Math.Pow(l, 3) + 4.9}",
                                "Задание №1",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbt.Text = string.Empty;
                Tbl.Text = string.Empty;

            }
        }
    }
}

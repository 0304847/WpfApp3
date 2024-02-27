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
    /// Логика взаимодействия для TaskPage12.xaml
    /// </summary>
    public partial class TaskPage12 : Page
    {
        public TaskPage12()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbt.Text) | string.IsNullOrEmpty(Tbx.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №12",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbt.Text = string.Empty;
                Tbx.Text = string.Empty;
            }
            else
            {
                double t = Convert.ToDouble(Tbt.Text), x = Convert.ToDouble(Tbx.Text);

                MessageBox.Show($" K ={7 * Math.Pow(t, 2) + 3 * Math.Sin(Math.Pow(x, 3)) + 9.2}",
                                "Задание №12",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbt.Text = string.Empty;
                Tbx.Text = string.Empty;

            }
        }
    }
}

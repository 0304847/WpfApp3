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
    /// Логика взаимодействия для TaskPage4.xaml
    /// </summary>
    public partial class TaskPage4 : Page
    {
        public TaskPage4()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tba.Text) | string.IsNullOrEmpty(Tbt.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №4",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tba.Text = string.Empty;
                Tbt.Text = string.Empty;
            }
            else
            {
                double a = Convert.ToDouble(Tba.Text), t = Convert.ToDouble(Tbt.Text);

                MessageBox.Show($" D ={9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t, 5))}",
                                "Задание №4",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tba.Text = string.Empty;
                Tbt.Text = string.Empty;

            }
        }
    }
}

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
    /// Логика взаимодействия для TaskPage10.xaml
    /// </summary>
    public partial class TaskPage10 : Page
    {
        public TaskPage10()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbk.Text)| string.IsNullOrEmpty(Tbx.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №10",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbk.Text = string.Empty;
                Tbx.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), k = Convert.ToDouble(Tbk.Text), x = Convert.ToDouble(Tbx.Text);

                MessageBox.Show($" U ={Math.Exp(y) + 7.355 * Math.Pow(k, 2) + Math.Pow(Math.Sin(x), 2)}",
                                "Задание №10",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbk.Text = string.Empty;
                Tbx.Text = string.Empty;

            }
        }
    }
}

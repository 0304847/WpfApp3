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
    /// Логика взаимодействия для TaskPage20.xaml
    /// </summary>
    public partial class TaskPage20 : Page
    {
        public TaskPage20()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbk.Text) | string.IsNullOrEmpty(Tbx.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №20",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbk.Text = string.Empty;
                Tbx.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), k = Convert.ToDouble(Tbk.Text), x = Convert.ToDouble(Tbx.Text);

                MessageBox.Show($" U ={Math.Exp(k + y) + Math.Tan(x) * Math.Sqrt(y)}",
                                "Задание №20",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbk.Text = string.Empty;
                Tbx.Text = string.Empty;

            }
        }
    }
}

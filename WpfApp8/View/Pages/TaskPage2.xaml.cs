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
    /// Логика взаимодействия для TaskPage2.xaml
    /// </summary>
    public partial class TaskPage2 : Page
    {
        public TaskPage2()
        {
            InitializeComponent();
        }

        private void BtnTasck2_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbp.Text) | string.IsNullOrEmpty(Tby.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №2",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbp.Text = string.Empty;
                Tby.Text = string.Empty;
            }
            else
            {
                double p = Convert.ToDouble(Tbp.Text), y = Convert.ToDouble(Tby.Text);

                MessageBox.Show($" K ={Math.Log10(Math.Pow(p, 2) + Math.Pow(y, 3)) + Math.Exp(p)}",
                                "Задание №2",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbp.Text = string.Empty;
                Tby.Text = string.Empty;

            }
        }
    }
}

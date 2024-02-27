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
    /// Логика взаимодействия для TaskPage28.xaml
    /// </summary>
    public partial class TaskPage28 : Page
    {
        public TaskPage28()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbh.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №28",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbh.Text = string.Empty;

            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), h = Convert.ToDouble(Tbh.Text);

                MessageBox.Show($" G ={Math.Exp(y + h) + Math.Sqrt(Math.Abs(6.4 * y))}",
                                "Задание №28",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbh.Text = string.Empty;


            }
        }
    }
}

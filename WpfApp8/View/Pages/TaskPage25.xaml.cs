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
    /// Логика взаимодействия для TaskPage25.xaml
    /// </summary>
    public partial class TaskPage25 : Page
    {
        public TaskPage25()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbf.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №25",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbf.Text = string.Empty;

            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), f = Convert.ToDouble(Tbf.Text);

                MessageBox.Show($" G ={Math.Exp(2 * y) + Math.Sin(Math.Pow(f, 2))}",
                                "Задание №25",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbf.Text = string.Empty;


            }
        }
    }
}

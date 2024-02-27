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
    /// Логика взаимодействия для TaskPage19.xaml
    /// </summary>
    public partial class TaskPage19 : Page
    {
        public TaskPage19()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbn.Text) | string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbg.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №19",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbn.Text = string.Empty;
                Tby.Text = string.Empty;
                Tbg.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), n = Convert.ToDouble(Tbn.Text), g = Convert.ToDouble(Tbg.Text);

                MessageBox.Show($" P ={n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g)}",
                                "Задание №19",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbn.Text = string.Empty;
                Tbg.Text = string.Empty;

            }
        }
    }
}

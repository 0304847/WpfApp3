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
    /// Логика взаимодействия для TaskPage16.xaml
    /// </summary>
    public partial class TaskPage16 : Page
    {
        public TaskPage16()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №16",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;

            }
            else
            {
                double y = Convert.ToDouble(Tby.Text);

                MessageBox.Show($" S ={Math.Sqrt(Math.Cos(4 * Math.Pow(y, 2)) + 7.151)}",
                                "Задание №16",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;


            }
        }
    }
}

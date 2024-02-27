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
    /// Логика взаимодействия для TaskPage5.xaml
    /// </summary>
    public partial class TaskPage5 : Page
    {
        public TaskPage5()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №5",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbx.Text = string.Empty;
               
            }
            else
            {
                double x = Convert.ToDouble(Tbx.Text);

                MessageBox.Show($" L ={1.51 * Math.Cos(Math.Pow(x, 2) + 2 * Math.Pow(x, 3))}",
                                "Задание №5",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx.Text = string.Empty;
               

            }
        }
    }
}

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
    /// Логика взаимодействия для TaskPage21.xaml
    /// </summary>
    public partial class TaskPage21 : Page
    {
        public TaskPage21()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbh.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №21",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbh.Text = string.Empty;
                
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), h = Convert.ToDouble(Tbh.Text);

                MessageBox.Show($" P ={Math.Exp(y + 5.5) + 9.1 * Math.Pow(h, 3)}",
                                "Задание №21",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbh.Text = string.Empty;
             

            }
        }
    }
}

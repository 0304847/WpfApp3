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
    /// Логика взаимодействия для TaskPage27.xaml
    /// </summary>
    public partial class TaskPage27 : Page
    {
        public TaskPage27()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbv.Text) | string.IsNullOrEmpty(Tbx.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №27",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbv.Text = string.Empty;
                Tbx.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), v = Convert.ToDouble(Tbv.Text), x = Convert.ToDouble(Tbx.Text);

                MessageBox.Show($" W ={1.03 * v + Math.Exp(2 * y) + Math.Tan(Math.Abs(x))}",
                                "Задание №27",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbv.Text = string.Empty;
                Tbx.Text = string.Empty;

            }
        }
    }
}

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
    /// Логика взаимодействия для TaskPage8.xaml
    /// </summary>
    public partial class TaskPage8 : Page
    {
        public TaskPage8()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №8",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;

            }
            else
            {
                double y = Convert.ToDouble(Tby.Text);

                MessageBox.Show($" T ={Math.Sqrt(Math.Abs(6 * Math.Pow(y, 2) - 0.1 * y + 4))}",
                                "Задание №8",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;


            }
        }
    }
}

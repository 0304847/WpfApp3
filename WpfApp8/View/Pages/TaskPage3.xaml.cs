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
    /// Логика взаимодействия для TaskPage3.xaml
    /// </summary>
    public partial class TaskPage3 : Page
    {
        public TaskPage3()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbn.Text) | string.IsNullOrEmpty(Tby.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №3",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbn.Text = string.Empty;
                Tby.Text = string.Empty;
            }
            else
            {
                double n = Convert.ToDouble(Tbn.Text), y = Convert.ToDouble(Tby.Text);

                MessageBox.Show($" G ={ n * y + n * 3.5 + Math.Sqrt(y)}",
                                "Задание №3",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbn.Text = string.Empty;
                Tby.Text = string.Empty;

            }
        }
    }
}

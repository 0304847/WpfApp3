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
    /// Логика взаимодействия для TaskPage26.xaml
    /// </summary>
    public partial class TaskPage26 : Page
    {
        public TaskPage26()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbp.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №26",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbp.Text = string.Empty;
                

            }
            else
            {
                double p = Convert.ToDouble(Tbp.Text);

                MessageBox.Show($" Z ={Math.Sin(Math.Pow(Math.Pow(p, 2) + 0.4, 3))}",
                                "Задание №26",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbp.Text = string.Empty;
             


            }
        }
    }
}

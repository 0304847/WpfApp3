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
    /// Логика взаимодействия для TaskPage7.xaml
    /// </summary>
    public partial class TaskPage7 : Page
    {
        public TaskPage7()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Tbm.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №7",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbm.Text = string.Empty;
                
            }
            else
            {
                double m = Convert.ToDouble(Tbm.Text);

                MessageBox.Show($" N ={Math.Pow(m, 2) + 2.8 * Math.Abs(m) + 0.55}",
                                "Задание №7",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbm.Text = string.Empty;
                

            }
        }
    }
}

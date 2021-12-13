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

namespace Pract_10G
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        List<int> array = new List<int>(10);

        private void FillList_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array.Add(random.Next(-100, 100));
                values.Items.Add(array[i]);
            }
        }

        private void FindAverage_Click(object sender, RoutedEventArgs e)
        {
            resultMaxValue.Text = array.Where(x => x < 0).Max().ToString();
            resultIndex.Text = array.IndexOf(array.Where(x => x < 0).Max()).ToString();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Дроздов Г. ИСП-34", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

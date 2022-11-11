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

namespace WPF_FILIPPOV_PR4
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
        private void Sgen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(101);
            lab.Text = i.ToString();
        }

        private void Ugaday_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(lab.Text);
            int test = Convert.ToInt32(Chislo.Text);

            if (i == test)
            {
                MessageBox.Show("Угадал, bruh");
            }
            else if (i > test)
            {
                MessageBox.Show("Маленькое число");
            }
            else
            {
                MessageBox.Show("Большое число");
            }
        }
    }
}

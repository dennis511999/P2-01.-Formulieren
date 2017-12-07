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
using System.Windows.Shapes;

namespace Formulier
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            
        }

        

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void GoatClip_Click(object sender, RoutedEventArgs e)
        {
            Goat.Visibility = Visibility.Visible;
            Goat.Play();

        }

        private void btnCloseMedia_Click(object sender, RoutedEventArgs e)
        {
            Goat.Stop();
            Goat.Visibility = Visibility.Hidden;
        }
    }
}

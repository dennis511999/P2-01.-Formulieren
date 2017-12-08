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

        

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnGoatClip_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMedia.Visibility = Visibility.Visible;
            metGoat.Visibility = Visibility.Visible;
            metGoat.Play();

        }

        private void btnCloseMedia_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMedia.Visibility = Visibility.Hidden;

            metGoat.Stop();
            metGoat.Visibility = Visibility.Hidden;

            metSpongebob.Stop();
            metSpongebob.Visibility = Visibility.Hidden;

            metLionKing.Stop();
            metLionKing.Visibility = Visibility.Hidden;

            metTrump.Stop();
            metTrump.Visibility = Visibility.Hidden;            
        }

        private void btnSpongebob_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMedia.Visibility = Visibility.Visible;
            metSpongebob.Visibility = Visibility.Visible;
            metSpongebob.Play();
        }

        private void btnLionKingClip_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMedia.Visibility = Visibility.Visible;
            metLionKing.Visibility = Visibility.Visible;
            metLionKing.Play();
        }

        private void btnTrumpClip_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMedia.Visibility = Visibility.Visible;
            metTrump.Visibility = Visibility.Visible;
            metTrump.Play();
            
        }
    }
}

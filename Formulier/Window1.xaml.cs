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
using System.Media;

namespace Formulier
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void playCryCar()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\Girl_cries_like_a_supercar_original_.wav");
            simpleSound.Play();
        }

       

        private void PlaySound_Click(object sender, RoutedEventArgs e)
        {
            this.playCryCar();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}

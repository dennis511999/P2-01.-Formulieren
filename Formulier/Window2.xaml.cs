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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        public void playBoomSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\boom.wav");
            simpleSound.Play();
        }

        public void playSkrrrSound()
        {
            SoundPlayer skrrrSound = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\skrrrrrr_pop_pop_hq.wav");
            skrrrSound.Play();
        }

        public void playTheThingGoes()
        {
            SoundPlayer theThingGoes = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\the_ting_go_skrra.wav");
            theThingGoes.Play();
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ButtonBoomSound_Click(object sender, RoutedEventArgs e)
        {
            this.playBoomSound();
        }

        private void ButtonSoundskrrrr_Click(object sender, RoutedEventArgs e)
        {
            this.playSkrrrSound();
        }

        private void ButtonTheThingGoes_Click(object sender, RoutedEventArgs e)
        {
            this.playTheThingGoes();
        }
    }
}

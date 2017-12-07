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
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\Sounds\Car\Girl_cries_like_a_supercar_original_.wav");
            simpleSound.Play();
        }

        public void playCarAlarm()
        {
            SoundPlayer CarAlarm = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\Sounds\Car\Car+Alarm.wav");
            CarAlarm.Play();
        }

        public void playCarDoor()
        {
            SoundPlayer CarDoor = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\Sounds\Car\car+door.wav");
            CarDoor.Play();
        }
       
        public void playCarStart()
        {
            SoundPlayer CarStart = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\Sounds\Car\carstartgarage.wav");
            CarStart.Play();
        }

        public void playCarDrive()
        {
            SoundPlayer CarDrive = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\Sounds\Car\CAR+Peels+Out.wav");
            CarDrive.Play();
        }

        public void playCarHorn()
        {
            SoundPlayer CarHorn = new SoundPlayer(@"C:\Users\Dennis\Desktop\Projecten\Periode 2\Formulier\Formulier\Images and Souds\Sounds\Car\car+horn+x.wav");
            CarHorn.Play();
        }

        

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void PlaySound_Click(object sender, RoutedEventArgs e)
        {
            this.playCryCar();
        }

        private void CarAlarm_Click(object sender, RoutedEventArgs e)
        {
            this.playCarAlarm();
        }

        private void CarDoors_Click(object sender, RoutedEventArgs e)
        {
            this.playCarDoor();
        }

        private void CarStart_Click(object sender, RoutedEventArgs e)
        {
            this.playCarStart();
        }

        private void CarDrive_Click(object sender, RoutedEventArgs e)
        {
            this.playCarDrive();
        }

        private void CarHorn_Click(object sender, RoutedEventArgs e)
        {
            this.playCarHorn();
        }
    }
}

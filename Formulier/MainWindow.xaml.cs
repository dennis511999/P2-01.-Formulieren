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

namespace Formulier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            

            if (TextBox1.Text != "")
            {
                string strUserName = Console.ReadLine();

                ListBox1.Items.Add(TextBox1.Text);                
                TextBox1.Text = strUserName;
            }
        }

        private void Button2_click(object sender, RoutedEventArgs e)
        {


        }

        private void Button3_click(object sender, RoutedEventArgs e)
        {


        }
        private void Button4_click(object sender, RoutedEventArgs e)
        {


        }

    }
}


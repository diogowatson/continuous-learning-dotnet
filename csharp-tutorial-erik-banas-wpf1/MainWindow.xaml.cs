using Microsoft.Win32;
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

namespace WpfTutorial
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        string usersName = "";//a string to hold the users name;

        public MainWindow()
        {
            InitializeComponent();//initialize and display the window

            //change the title
            this.Title = "Hello World";
            //every time the program starts I want the window to be located in the center
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; 
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //change the xy position and show it on the title
            Title = e.GetPosition(this).ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //every time the user clicks here I want to say that I'm closing the aplication 
            //and then the aplication should close
            MessageBox.Show("App is closing");
            this.Close();
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        private void buttonSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        ////private void button_Click_2(object sender, RoutedEventArgs e)
        ////{
        ////    usersName = UserName.Text;

        ////        MessageBox.Show($"Hello {usersName}");

        ////}
    }
}

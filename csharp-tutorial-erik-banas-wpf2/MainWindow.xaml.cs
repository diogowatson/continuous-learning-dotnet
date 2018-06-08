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

namespace WpfTutorial2
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

       
        //close the app
        private void menuExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //opend the dialog
        private void menuOpenClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        //opens the save dialog
        private void menuSaveClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        //unchecks fonta and changes for the text box
        private void MenuFontTimes_Click(object sender, RoutedEventArgs e)
        {
            menuFontCourier.IsChecked = false;
            menuFontArial.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Times New Roman");
        }

        private void MenuFontCourier_Click(object sender, RoutedEventArgs e)
        {
            menuFontTimes.IsChecked = false;
            menuFontArial.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Courier");
        }

        private void MenuFontArial_Click(object sender, RoutedEventArgs e)
        {
            menuFontCourier.IsChecked = false;
            menuFontTimes.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Arial");
        }

    }
}

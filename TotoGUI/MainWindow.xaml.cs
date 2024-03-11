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

namespace TotoGUI
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

        private void Eredmenyek_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            List<char> wrongChars = new List<char>();
            foreach (var i in Eredmenyek.Text)  {   if ("12Xx".IndexOf(i) == -1) wrongChars.Add(i);  }

            TextLengthCBox.Content = $"Karakterlánc hossza: {Eredmenyek.Text.Length}";
            TextLengthCBox.IsChecked = Eredmenyek.Text.Length == 14;

            IncorrectCharCBox.IsChecked = wrongChars.Count == 0;
            if(IncorrectCharCBox.IsChecked == true) { IncorrectCharCBox.Content = "Helytelen karakter az eredményekben: Nincs"; }
            else { IncorrectCharCBox.Content = $"Helytelen karakter az eredményekben: {string.Join(";", wrongChars)}"; }

            if(IncorrectCharCBox.IsChecked == true & TextLengthCBox.IsChecked == true) { SubmitBtn.IsEnabled = true; }
            else { SubmitBtn.IsEnabled = false; }
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

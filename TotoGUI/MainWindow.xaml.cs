﻿using System;
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Eredmenyek_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextLengthCBox.Content = "Megfelelő a karakterlánc hossza: ";
            if (Eredmenyek.Text.Length == 14)
            {
                TextLengthCBox.IsChecked = true;
                TextLengthCBox.Content += $"{Eredmenyek.Text.Length + " " + ((char)0x221A).ToString()}";
            }

            else
            {

            }
        }
    }
}

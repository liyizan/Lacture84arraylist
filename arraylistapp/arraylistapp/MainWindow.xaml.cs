﻿using System;
using System.Collections;
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

namespace arraylistapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arraylist;
        public MainWindow()
        {
            InitializeComponent();
            arraylist = new ArrayList();
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            arraylist.Add(txtdata.Text);
            MessageBox.Show("add " + txtdata.Text + " in to List");
        }

        private void removebutton_Click(object sender, RoutedEventArgs e)
        {
            arraylist.Remove(txtdata.Text);
            MessageBox.Show("remove " + txtdata.Text + " out of list");
        }
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            foreach(string data in arraylist)
            {
               
                MessageBox.Show(data);
            }
        }

        
    }
}

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
using Application;


namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NewOrderWindow orderwin = new NewOrderWindow();
        NewCustomerWindow customerwin = new NewCustomerWindow();
        Controller control = new Controller();
        
        public MainWindow()
        {
            InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
          
            try
            {
                if (control.CheckCustomerID(int.Parse(Textbox1.Text)) == true)
                {
                    
                    orderwin.Show();
                    this.Close();
                }
                else
                {
                    customerwin.Show();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hov hov, du skal skrive et tal brormand");
            }
          
            
            

                
		}

		
	}
}

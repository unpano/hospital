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
using System.Windows.Shapes;

namespace HCI_wpf_Andjela_Paunovic
{
    /// <summary>
    /// Interaction logic for Reply.xaml
    /// </summary>
    public partial class Reply : Window
    {
        public Reply()
        {
            InitializeComponent();
        }

        private void replyClick(object sender, RoutedEventArgs e)
        {
            //Questions list
            Questions que = new Questions();
            que.Show();
            this.Close();
        }

        
    }
}

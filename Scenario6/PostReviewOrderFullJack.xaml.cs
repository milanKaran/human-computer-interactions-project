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

namespace _481Project
{
    /// <summary>
    /// Interaction logic for reviewOrderFull.xaml
    /// </summary>
    public partial class PostReviewOrderFullJack : Window
    {
        public PostReviewOrderFullJack()
        {
            InitializeComponent();
        }

        private void Reduce(object sender, RoutedEventArgs e)
        {

        }

        private void ShowRec(object sender, RoutedEventArgs e)
        {
            Rec1.Visibility = Visibility.Visible;
            Rec2.Visibility = Visibility.Visible;
            Rec3.Visibility = Visibility.Visible;
        }
    }
}

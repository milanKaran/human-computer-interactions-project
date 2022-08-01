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
using System.Windows.Threading;

namespace _481Project
{
    /// <summary>
    /// Interaction logic for reviewOrder.xaml
    /// </summary>
    public partial class ReviewOrderJack : Window
    {

        public ReviewOrderJack()
        {
            InitializeComponent();
        }

        private void ToFullScreenJack(object sender, RoutedEventArgs e)
        {
            var reviewOrder = new ReviewOrderFullJack();
            reviewOrder.Top = this.Top;
            reviewOrder.Left = this.Left;
            reviewOrder.Show();
            this.Close();
        }

        private void ConfirmPopUp(object sender, RoutedEventArgs e)
        {
            var reviewOrder = new ReviewOrderFullJack();
            reviewOrder.Top = this.Top;
            reviewOrder.Left = this.Left;
            reviewOrder.Show();
            this.Close();
        }

        private void toMain1(object sender, RoutedEventArgs e)
        {
            var reviewOrder = new MainScreenJack();
            reviewOrder.Top = this.Top;
            reviewOrder.Left = this.Left;
            reviewOrder.Show();
            this.Close();
        }

        private void toMain2(object sender, RoutedEventArgs e)
        {
            var reviewOrder = new MainScreenJack();
            reviewOrder.Top = this.Top;
            reviewOrder.Left = this.Left;
            reviewOrder.Show();
            this.Close();
        }
    }
}

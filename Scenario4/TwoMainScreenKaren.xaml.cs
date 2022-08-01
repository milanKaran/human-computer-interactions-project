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

namespace _481Project
{
    /// <summary>
    /// Interaction logic for mainScreen.xaml
    /// </summary>
    public partial class TwoMainScreenKaren : Window
    {
        public static TwoReviewOrderKaren ReviewWindow = new TwoReviewOrderKaren();
        public TwoMainScreenKaren()
        {
            InitializeComponent();
        }

        private void PartialReviewView(object sender, RoutedEventArgs e)
        {
            ReviewWindow.Top = this.Top;
            ReviewWindow.Left = this.Left;
            ReviewWindow.aTabControl.SelectedIndex = 1;
            ReviewWindow.aTabControl.SelectedItem = mainsTab;
            ReviewWindow.mainsTab.IsSelected = true;
            ReviewWindow.Show();
            this.Close();
        }

        private void IncrementSpaghetti(object sender, RoutedEventArgs e) {
            spaghettiCounter.Text = "1";
            priceTotal.Text = "11.95";
        }
        private void DecrementSpaghetti(object sender, RoutedEventArgs e){
            spaghettiCounter.Text = "0";
            priceTotal.Text = "0.00";
        }


        private void RemoveOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Hidden;
            overlay2.Visibility = Visibility.Hidden;
            overlay3.Visibility = Visibility.Hidden;
            overlay4.Visibility = Visibility.Hidden;
            ArrowAdd.Visibility = Visibility.Hidden;
            ArrowRemove.Visibility = Visibility.Hidden;
            ArrowWaiter.Visibility = Visibility.Hidden;
            ArrowReviewOrder.Visibility = Visibility.Hidden;
            overlaySplash.Visibility = Visibility.Hidden;
        }

        private void ShowOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Visible;
            overlay2.Visibility = Visibility.Visible;
            overlay3.Visibility = Visibility.Visible;
            overlay4.Visibility = Visibility.Visible;
            ArrowAdd.Visibility = Visibility.Visible;
            ArrowRemove.Visibility = Visibility.Visible;
            ArrowWaiter.Visibility = Visibility.Visible;
            ArrowReviewOrder.Visibility = Visibility.Visible;
            overlaySplash.Visibility = Visibility.Visible;
        }

        private void SalmonIncrement(object sender, RoutedEventArgs e)
        {
            SalmonCounter.Text = "1";
            priceTotal.Text = "10.99";
        }

        private void SalmonDecrement(object sender, RoutedEventArgs e)
        {
            SalmonCounter.Text = "0";
            priceTotal.Text = "0.00";
        }


        private void CallWaiter(object sender, RoutedEventArgs e)
        {
            var CallStaff = new WaiterNotification()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };
            CallStaff.Show();
        }
    }
}

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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainscreenJohn : Window
    {
        public static ReviewOrderJohn ReviewOrderScreenWindow = new ReviewOrderJohn();
        private static int numberOfShrimpBurgers = 0;
        private static int numberOfPopcornShrimps = 0;
        private static int numberOfButterBuiscuits = 0;
        private static Double PriceTally = 0.0;
        public MainscreenJohn()
        {
            InitializeComponent();
        }
        private void IncrementSpaghetti(object sender, RoutedEventArgs e)
        {
            spaghettiCounter.Text = "1";
            priceTotal.Text = "11.95";
        }
        private void DecrementSpaghetti(object sender, RoutedEventArgs e)
        {
            spaghettiCounter.Text = "0";
            priceTotal.Text = "0.00";
        }

        private void ReviewOrderScreen(object sender, RoutedEventArgs e)
        {
            ReviewOrderScreenWindow.Top = this.Top;
            ReviewOrderScreenWindow.Left = this.Left;
            ReviewOrderScreenWindow.SubTotalCounter.Text = "4";
            ReviewOrderScreenWindow.SubtotalPrice.Text = "$" + GetPriceTally();
            ReviewOrderScreenWindow.PriceTotal.Text = GetPriceTally();
            ReviewOrderScreenWindow.NumOfBurgers.Text = "2";
            ReviewOrderScreenWindow.NumOfPopcornShrimp.Text = "1";
            ReviewOrderScreenWindow.NumOfButterBuiscuits.Text = "1";
            ReviewOrderScreenWindow.aTabControl.SelectedIndex = 3;
            ReviewOrderScreenWindow.aTabControl.SelectedItem = sidesTab;
            ReviewOrderScreenWindow.sidesTab.IsSelected = true;
            ReviewOrderScreenWindow.Show();
            this.Close();
        }
        private void RemoveOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Hidden;
            overlay2.Visibility = Visibility.Hidden;
            overlay3.Visibility = Visibility.Hidden;
            overlay4.Visibility = Visibility.Hidden;
            ArrowWaiter.Visibility = Visibility.Hidden;
            ArrowAdd.Visibility = Visibility.Hidden;
            ArrowRemove.Visibility = Visibility.Hidden;
            ArrowReviewOrder.Visibility = Visibility.Hidden;
            overlaySplash.Visibility = Visibility.Hidden;
        }

        private void ShowOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Visible;
            overlay2.Visibility = Visibility.Visible;
            overlay3.Visibility = Visibility.Visible;
            overlay4.Visibility = Visibility.Visible;
            overlaySplash.Visibility = Visibility.Visible;
        }

        private void IncrementShrimpBurger(object sender, RoutedEventArgs e)
        {
            numberOfShrimpBurgers += 1;
            PriceTally += 7.50;
            numShrimpBurgers.Text = numberOfShrimpBurgers.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
        }

        private void IncrementPopcornShrimp(object sender, RoutedEventArgs e)
        {
            numberOfPopcornShrimps += 1;
            PriceTally += 1.50;
            numPopcornShrimp.Text = numberOfPopcornShrimps.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
        }

        private void IncrementButterBuiscuit(object sender, RoutedEventArgs e)
        {
            numberOfButterBuiscuits += 1;
            PriceTally += 2.50;
            numButterBuiscuits.Text = numberOfButterBuiscuits.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
        }
        public String GetNumberOfShrimpBurgers() {
            return numberOfShrimpBurgers.ToString();
        }
        public String GetNumberOfPopcornShrimps()
        {
            return numberOfPopcornShrimps.ToString();
        }
        public String GetNumberOfButterBuiscuits()
        {
            return numberOfButterBuiscuits.ToString();
        }
        public String GetPriceTally()
        {
            return String.Format("{0:00.00}", PriceTally);
        }
        public void AddToTotalPrice(double addedPrice) 
        {
            PriceTally += addedPrice;

        }
        public ReviewOrderJohn GetReviewOrderScreen()
        {
            return ReviewOrderScreenWindow;
        }
        
    }
}

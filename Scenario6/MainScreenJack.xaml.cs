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
    public partial class MainScreenJack : Window
    {
        private static int numberOfShrimpMilkshake = 0;
        private static int numberOfShrimpIceCream = 0;
        private static int numberOfShrimpBurger = 0;
        private static int numberOfShrimpFries = 0;
        private static Double PriceTally = 0.0;
        public MainScreenJack() 
        {
            InitializeComponent();
        }

        private void PartialReviewViewJack(object sender, RoutedEventArgs e)
        {
            var reviewOrder = new ReviewOrderJack();
            reviewOrder.Top = this.Top;
            reviewOrder.Left = this.Left;
            reviewOrder.Show();
            this.Close();
        }

        

        private void MilkshakeDec(object sender, RoutedEventArgs e)
        {
            MilkshakeCount.Text = "0";
            priceTotal.Text = "0";
        }

        private void IncBurger(object sender, RoutedEventArgs e)
        {
            numberOfShrimpBurger += 1;
            PriceTally += 15.50;
            BurgerCount.Text = numberOfShrimpBurger.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
        }

        private void DecBurger(object sender, RoutedEventArgs e)
        {
            BurgerCount.Text = "0";
            priceTotal.Text = "4.50";
        }

        private void IncFries(object sender, RoutedEventArgs e)
        {
            numberOfShrimpFries += 1;
            PriceTally += 3.00;
            FriesCount.Text = numberOfShrimpFries.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
        }

        private void DecFries(object sender, RoutedEventArgs e)
        {
            BurgerCount.Text = "0";
            priceTotal.Text = "20.00";
        }

        private void IncMilkShake(object sender, RoutedEventArgs e)
        {
            numberOfShrimpMilkshake += 1;
            PriceTally += 4.50;
            MilkshakeCount.Text = numberOfShrimpMilkshake.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
        }

        private void IncIceCream(object sender, RoutedEventArgs e)
        {
            numberOfShrimpIceCream += 1;
            PriceTally += 3.00;
            IceCreamCount.Text = numberOfShrimpIceCream.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
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
    }
}

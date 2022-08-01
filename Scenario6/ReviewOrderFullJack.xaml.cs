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
    /// Interaction logic for reviewOrderFull.xaml
    /// </summary>
    public partial class ReviewOrderFullJack : Window
    {
        private static DispatcherTimer _timer1;
        private static TimeSpan _time1;
        private static int numberOfShrimpMilkshake = 2;
        private static Double PriceTally = 42.50;
        public ReviewOrderFullJack()
        {
            InitializeComponent();
        }

        private void Reduce(object sender, RoutedEventArgs e)
        {

        }
        private void DoStuff(object sender, RoutedEventArgs e) 
        {
            Check1.Visibility = Visibility.Visible;
            Check2.Visibility = Visibility.Visible;
            Check3.Visibility = Visibility.Visible;

            Rec1.Visibility = Visibility.Visible;
            Rec2.Visibility = Visibility.Visible;
            Rec3.Visibility = Visibility.Visible;


            Plus1.Visibility = Visibility.Hidden;
            Plus2.Visibility = Visibility.Hidden;
            Plus3.Visibility = Visibility.Hidden;

            Minus1.Visibility = Visibility.Hidden;
            Minus2.Visibility = Visibility.Hidden;
            Minus3.Visibility = Visibility.Hidden;

        }
        private void ToPostConfirm(object sender, RoutedEventArgs e)
        {

            var ConfirmedPopUp = new PlacedOrderJack()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };
            _time1 = TimeSpan.FromSeconds(3);

            _timer1 = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                if (_time1 == TimeSpan.Zero)
                {
                    _timer1.Stop();
                    returnButton.Content = "Confirm Order";
                    SubTotal.Text = "$0.00";
                    ConfirmedPopUp.Show();
                    ConfirmedPopUp.okButton.Click += DoStuff;

                }
                _time1 = _time1.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer1.Start();
            returnButton.Content = "Processing Order...";
        }

        private void toReviewOrder(object sender, RoutedEventArgs e)
        {
            var reviewOrder = new ReviewOrderJack();
            reviewOrder.Top = this.Top;
            reviewOrder.Left = this.Left;
            reviewOrder.Show();
            this.Close();
        }

        private void IncMilkshake(object sender, RoutedEventArgs e)
        {
            numberOfShrimpMilkshake += 1;
            PriceTally += 4.50;
            MilkshakeCount.Text = numberOfShrimpMilkshake.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
            SubTotal.Text = String.Format("{0:00.00}", PriceTally);
        }

        private void DecMilkshake(object sender, RoutedEventArgs e)
        {
            numberOfShrimpMilkshake -= 1;
            PriceTally -= 4.50;
            MilkshakeCount.Text = numberOfShrimpMilkshake.ToString();
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
            SubTotal.Text = String.Format("{0:00.00}", PriceTally);
        }
        private void DoSomeStuff(object sender, RoutedEventArgs e) 
        {
            DelTxt.Visibility = Visibility.Hidden;
            DelButton.Visibility = Visibility.Hidden;
            delPrice.Visibility = Visibility.Hidden;
            delQty.Visibility = Visibility.Hidden;
            delPlus.Visibility = Visibility.Hidden;
            DelMinus.Visibility = Visibility.Hidden;

            PriceTally = PriceTally-15.00 ;
            priceTotal.Text = String.Format("{0:00.00}", PriceTally);
            SubTotal.Text = String.Format("{0:00.00}", PriceTally);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ConfirmedPopUp = new CancelItemJack()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };

            ConfirmedPopUp.Show();
            //do below when button is clicked
            ConfirmedPopUp.YesButton.Click += DoSomeStuff;
        }

        private void OverLayClose(object sender, RoutedEventArgs e)
        {
            OverLayReviewOrderFull.Visibility = Visibility.Hidden;
            OverLayTxt1.Visibility = Visibility.Hidden;
            OverLayTxt2.Visibility = Visibility.Hidden;
            OverLayTxt3.Visibility = Visibility.Hidden;
            Arrow1.Visibility = Visibility.Hidden;
            Arrow2.Visibility = Visibility.Hidden;
            Arrow3.Visibility = Visibility.Hidden;
        }
    }
}

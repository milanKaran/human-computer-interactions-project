using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class ReviewOrderThomas : Window
    {
        public static MainscreenJohn fromMainScreen = new MainscreenJohn();
        public ReviewOrderThomas()
        {
            InitializeComponent();
        }

        private void returnButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            var ConfirmedPopUp = new CancelledOrderThomas()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };
            ConfirmedPopUp.Show();
            SubtotalPrice.Text = "0.00";
            SubTotalCounter.Text = "0";
            PriceTotal.Text = "0.00";
            itemName.Text = "";
            itemCount.Text = "";
            itemPrice.Text = "";
            itemChecked.Visibility = Visibility.Hidden;
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            var ws = new WelcomeScreen();    //create your new form.
            ws.Show();                     //show the new form.
            this.Close();                       //only if you want to close the current form.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var CallStaff = new WaiterNotificationThomas()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };
            CallStaff.Show();
        }

        private void closeReview_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainScreenThomas();
            newForm.Show();
            this.Close();
        }
    }

}

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
using System.Diagnostics;
using System.Windows.Threading;
using System.Data.SqlClient;
using System.Windows.Navigation;

namespace SoppingManaage
{
    /// <summary>
    /// Interaction logic for UserHomepage.xaml
    /// </summary>
    public partial class UserHomepage : Window
    {
        public UserHomepage()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Start();
            InitializeComponent();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            txtdate.Text = string.Format("{0:h:mm:ss tt}", DateTime.Now);
            //txtdate.Text = string.Format("{0:h:mm:ss:ff}", DateTime.Now);
        }

        private void logout_menuitem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
            //this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();
        }

      

        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
        }

        private void account_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Account acunt = new Account();
            acunt.Show();
        }

        private void viewsell_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sale_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Admin_Sale ass = new Admin_Sale();
            ass.Show();
        }
        private void request_website(Object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
        }
    }
}

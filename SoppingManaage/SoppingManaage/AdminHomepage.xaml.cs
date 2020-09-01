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
    /// Interaction logic for AdminHomepage.xaml
    /// </summary>
    public partial class AdminHomepage : Window
    {
        public AdminHomepage()
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
        }

        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Product_user product1 = new Product_user();
            product1.Show();
        }
        private void request_website(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
        }

        private void sale_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            User_Sale us = new User_Sale();
            us.Show();
        }
    }
}

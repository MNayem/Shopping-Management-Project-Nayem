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

namespace SoppingManaage
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
        }

       

        private void Account_homemenuitem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employee em = new Employee();
            em.Show();
        }

        private void Account_homemenuitem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            UserHomepage uhp = new UserHomepage();
            uhp.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btn_employee_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Employee_Cost ec = new Employee_Cost();
            ec.Show();
        }
        private void btn_product_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Total_Buy_Product tbp = new Total_Buy_Product();
            tbp.Show();
        }

        private void Buylist_Click(object sender, RoutedEventArgs e)
        {
            Daily_Buy db = new Daily_Buy();
            db.Show();
        }

        private void btn_weekly_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_monthly_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_yearly_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_daily_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_loss_or_profit_Click(object sender, RoutedEventArgs e)
        {
            Profit_Loss pl = new Profit_Loss();
            pl.Show();
        }
    }
}

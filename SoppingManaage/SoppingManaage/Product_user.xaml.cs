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
    /// Interaction logic for Product_user.xaml
    /// </summary>
    public partial class Product_user : Window
    {
        public Product_user()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AdminHomepage ahp = new AdminHomepage();
            ahp.Show();
        }

        private void Availableproduct_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Available ap = new Available();
            ap.Show();
        }
    }
}

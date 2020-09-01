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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Threading;
using System.Data.SqlClient;

namespace SoppingManaage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Select_Type.Text == "Admin")
            {
                string constring = @"Data Source=DESKTOP-38D6V65;Initial Catalog=admin_login1;Integrated Security=True";
                SqlConnection con = new SqlConnection(constring);
                con.Open();

                string cmdstring = "select * from admin_login1 where user_name = '" + txt_username.Text + "' and passward = '" + txt_password.Password + "' and typee = '" + Select_Type.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdstring, con);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                //con.Close();

                int count = 0;
                
                while (dr.Read())
                {
                    count += 1;
                }
                //con.Close();
                if (count == 1)
                {

                   // MessageBox.Show("Welcome, you are successfully logged in as an admin !!!");
                    this.Hide();
                    UserHomepage uhp = new UserHomepage();
                    uhp.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Password or User Name !!!");
                }
            }
            else if(Select_Type.Text == "User")
            {
                string constring = @"Data Source=DESKTOP-38D6V65;Initial Catalog=admin_login1;Integrated Security=True";
                SqlConnection con = new SqlConnection(constring);
                con.Open();

                string cmdstring = "select * from admin_login1 where user_name = '" + txt_username.Text + "' and passward = '" + txt_password.Password + "' and typee = '" + Select_Type.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdstring, con);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                //con.Close();

                int count = 0;
                    
                 while (dr.Read())
                   {
                       count += 1;
                   }
                 //con.Close();
                 if (count == 1)
                   {
                        //MessageBox.Show("Welcome, you are successfully logged in as an user !!!");
                        this.Hide();
                        AdminHomepage ahp = new AdminHomepage();
                        ahp.Show();
                   }
                 else
                 {
                     MessageBox.Show("Invalid Password or User Name !!!");
                 }
                }
            else
            {
                MessageBox.Show("A field is empty, please fill the all field");
            }
            
            txt_username.Text = "";
            txt_password.Password = "";
            Select_Type.Text = "";
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

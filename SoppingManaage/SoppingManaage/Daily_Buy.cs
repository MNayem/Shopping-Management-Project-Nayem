using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SoppingManaage
{
    public partial class Daily_Buy : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;      //Represent a set of data commands and a database connection
        DataTable dt;
        public Daily_Buy()
        {
            InitializeComponent();
        }

        private void btn_show_daily_buy_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-38D6V65;Initial Catalog=product_total;Integrated Security=True";
            SqlConnection conDatabase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from product_total_available where Entry_date =  CAST(GETDATE() AS DATE)", conDatabase);

            try
            {
                sda = new SqlDataAdapter();   //new () = Initialize a new instances of the system
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show_weekly_buy_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-38D6V65;Initial Catalog=product_total;Integrated Security=True";
            SqlConnection conDatabase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from product_total_available where Entry_date between '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'", conDatabase);

            try
            {
                sda = new SqlDataAdapter();   //new () = Initialize a new instances of the system
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show_monthly_buy_Click(object sender, EventArgs e)
        {

        }
    }
}

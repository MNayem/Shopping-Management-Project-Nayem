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
    public partial class Total_Buy_Product : Form
    {
        // SqlConnection con;
        //Double toatlcost;
        SqlCommand cmd;
        SqlDataAdapter sda;      //Represent a set of data commands and a database connection
        DataTable dt;
        public Total_Buy_Product()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Account acunt = new Account();
            acunt.Show();
        }

        private void btn_total_buy_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-38D6V65;Initial Catalog=total_product;Integrated Security=True";
            SqlConnection conDatabase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from total_available_product", conDatabase);

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

        private void btn_total_product_cost_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[3].Value);
            }
            label2.Text = B.ToString();
            //toatlcost = B;
        }
    }
}

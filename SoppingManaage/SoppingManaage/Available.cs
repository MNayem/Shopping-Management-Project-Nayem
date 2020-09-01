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
    public partial class Available : Form
    {
        public Available()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;      //Represent a set of data commands and a database connection
        DataTable dt;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_user pp = new Product_user();
            pp.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.;Initial Catalog=product_total;Integrated Security=True";
            SqlConnection conDatabase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from product_total_available", conDatabase);

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

        private void btn_insert_Click(object sender, EventArgs e)
        {
            /*con = new SqlConnection(@"Data Source=.;Initial Catalog=product_total;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into total_available_product VALUES('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_catagory.Text + "','" + txt_price.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "')", con);
            cmd.ExecuteNonQuery();  //controls number of rows affected
            con.Close();
            MessageBox.Show("A product is inserted successfully !!! ");

            txt_id.Text = "";
            txt_name.Text = "";
            txt_catagory.Text = "";
            txt_price.Text = "";*/
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.;Initial Catalog=product_total;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("delete from product_total_available WHERE Product_id ='"+ txt_id.Text +"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("A product is Deleted Successfully !!!");
            txt_id.Text = "";
        }
    }
}

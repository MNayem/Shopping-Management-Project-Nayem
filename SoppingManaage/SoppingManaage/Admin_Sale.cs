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
    public partial class Admin_Sale : Form
    {
        SqlConnection con;
        SqlCommand cmd;     //store procedure to execute
        SqlDataAdapter sda;
        DataTable dt;

        public Admin_Sale()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            UserHomepage uhp = new UserHomepage();
            uhp.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
           try
           {
               SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=product_total;Integrated Security=True");
               string sql = "select * from product_total_available where Product_id = '"+ txt_id.Text +"'";
               if(con.State != ConnectionState.Open)
               {
                   con.Open();
               }
               cmd = new SqlCommand(sql, con);
               SqlDataReader dr = cmd.ExecuteReader();
               dr.Read();
               if(dr.HasRows)
               {
                   txt_name.Text = dr[1].ToString();
                   txt_catagory.Text = dr[2].ToString();
                   txt_buy_price.Text = dr[3].ToString();
                   txt_sale_price.Text = dr[4].ToString();
                   //dateTimePicker1.Text = dr[5].ToString("MM/dd/yyyy");
               }
               else
               {
                   MessageBox.Show("This does not exist in the Records !!!");
               }
               con.Close();
           }
            catch(Exception ex)
           {
               con.Close();
               MessageBox.Show(ex.Message);
           }
        }

        private void btn_show_sale_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-38D6V65;Initial Catalog=sale1;Integrated Security=True";
            SqlConnection conDatabase = new SqlConnection(constring);
            cmd = new SqlCommand("select * from sale_table1",conDatabase);
            try
            {
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
                sda.Update(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void btn_sale_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-38D6V65;Initial Catalog=sale1;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("insert into sale_table1 VALUES('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_catagory.Text + "','" + txt_buy_price.Text + "','"+ txt_sale_price.Text +"','"+ dateTimePicker1.Value.ToString("MM/dd/yyyy") +"')", con);
                cmd.ExecuteNonQuery();  //Controls number of affected rows
                con.Close();
                MessageBox.Show("A Product has been sale !!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_id.Text = "";
            txt_name.Text = "";
            txt_catagory.Text = "";
            txt_buy_price.Text = "";
            txt_sale_price.Text ="";
        }
    }
}

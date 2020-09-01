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
using System.Data.OleDb;

namespace SoppingManaage
{
    public partial class Profit_Loss : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;      //Represent a set of data commands and a database connection
        DataTable dt;
        public Profit_Loss()
        {
            InitializeComponent();
        }

        private void btn_show_loss_profit_betwwen_two_date_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-38D6V65;Initial Catalog=sale1;Integrated Security=True";
            SqlConnection conDatabase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from sale_table1 where Sale_date between '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and  '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'", conDatabase);

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

                int A = 0, B = 0;
                for (A = 0; A < dataGridView1.Rows.Count; ++A)
                {
                    B += Convert.ToInt32(dataGridView1.Rows[A].Cells[4].Value);
                }
                txt_total_sale_btn_two_date.Text = B.ToString();

                int C = 0, D = 0;
                for (C = 0; C < dataGridView1.Rows.Count; ++C)
                {
                    D += Convert.ToInt32(dataGridView1.Rows[C].Cells[3].Value);
                }
                textBox8.Text = D.ToString();

                txt_profit_btn_two_date.Text = (B - D).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
        }

        private void btn_show_monthly_profit_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_daily_profit_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-38D6V65;Initial Catalog=sale1;Integrated Security=True";
            SqlConnection conDatabase = new SqlConnection(constring);
            cmd = new SqlCommand("select *from sale_table1 where Sale_date =  CAST(GETDATE() AS DATE)", conDatabase);

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

                int A = 0, B = 0;
                for (A = 0; A < dataGridView1.Rows.Count; ++A)
                {
                    B += Convert.ToInt32(dataGridView1.Rows[A].Cells[4].Value);
                }
                textBox3.Text = B.ToString();

                int C = 0, D = 0;
                for (C = 0; C < dataGridView1.Rows.Count; ++C)
                {
                    D += Convert.ToInt32(dataGridView1.Rows[C].Cells[3].Value);
                }
                textBox7.Text = D.ToString();

                txt_daily_profit.Text = (B - D).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
using System.IO;

namespace SoppingManaage
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-38D6V65;Initial Catalog=employee1;Integrated Security=True");
        SqlCommand cmd;     //store procedure to execute
        string imgloc;
        public Employee()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Account acunt = new Account();
            acunt.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = ("insert into employee_table1 VALUES('" + txt_Emid.Text + "','" + txt_Emname.Text + "','" + txt_Emqulification.Text + "','" + txt_Emaddress.Text + "','" + txt_Empost.Text + "','" + txt_Emjoindate.Text + "','"+ txt_Emsalary.Text +"',@img)");
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new SqlCommand(sql,con);
                cmd.Parameters.Add(new SqlParameter("@img",img));
                int x = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(x.ToString() + "Record(s) saved successfully !!!");

                txt_Emid.Text = "";
                txt_Emname.Text = "";
                txt_Emqulification.Text = "";
                txt_Emaddress.Text = "";
                txt_Empost.Text = "";
                txt_Emjoindate.Text = "";
                txt_Emsalary.Text = "";
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fdl = new OpenFileDialog();
                fdl.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.* ";
                fdl.Title = "Select employee Picture";
                if (fdl.ShowDialog() == DialogResult.OK)     //specifies identifires to execute the value of dialog box
                {
                    imgloc = fdl.FileName.ToString();
                    employeePicture.ImageLocation = imgloc;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from employee_table1 WHERE Employee_id = '"+ txt_Emid.Text +"'";
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new SqlCommand(sql,con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                
                if(dr.HasRows)
                {
                    txt_Emname.Text = dr[1].ToString();
                    txt_Emqulification.Text = dr[2].ToString();
                    txt_Emaddress.Text = dr[3].ToString();
                    txt_Empost.Text = dr[4].ToString();
                    txt_Emjoindate.Text = dr[5].ToString();
                    txt_Emsalary.Text = dr[6].ToString();
                    byte[] img = (byte[]) (dr[7]);

                    if(img == null)
                    {
                        employeePicture.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        employeePicture.Image = Image.FromStream(ms);
                    }
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //con = new SqlConnection(@"Data Source=DESKTOP-38D6V65;Initial Catalog=employee1;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("delete from employee_table1 WHERE Employee_id ='" + txt_Emid.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("An Employee record ha been Deleted Successfully !!!");
            txt_Emid.Text = "";
        }
    }
}

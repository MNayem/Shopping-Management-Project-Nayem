﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoppingManaage
{
    public partial class User_Sale : Form
    {
        public User_Sale()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminHomepage ahp = new AdminHomepage();
            ahp.Show();
        }
    }
}

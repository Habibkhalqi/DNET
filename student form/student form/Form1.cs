﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace student_form
{
    public partial class Form1 : Form
    {
        string mycon = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string query = "insert into student values('"+txt_name.Text+"','"+txt_fathername.Text+"','"+txt_cnic.Text+"','"+txt_age.Text+"')".ToString();
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record save successfuly ");
        }
    }
}

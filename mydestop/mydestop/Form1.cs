using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydestop
{
    public partial class Form1 : Form
    {
        string mycon = System.Configuration.ConfigurationManager.ConnectionStrings["MYConstring"].ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "insert into student values('" + txt_name.Text + "','" + txt_fathername.Text + "','" + txt_cnic.Text + "','" + txt_age.Text + "')";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("details save sucessfully ");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentformDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentformDataSet.student);

        }
    }
}

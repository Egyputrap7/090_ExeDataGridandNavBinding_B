using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EXE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=LAPTOP-GHEF0MBM\\EGY;database=register;User ID=sa;Password=egyputradbncr78");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter db = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            

            if (txtusername.Text == "admin" && txtxpass.Text == "123")
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password Or User Name, Please try again", "Login Failed" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtusername.Text = "";
                txtxpass.Text = "";
                txtusername.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtxpass.Text = "";
            txtusername.Focus();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new registerform().Show();
            this.Hide();
        }

        private void chcPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPass.Checked)
            {
                txtxpass.PasswordChar = '\0';
                

            }
            else
            {
                txtxpass.PasswordChar = '*';
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

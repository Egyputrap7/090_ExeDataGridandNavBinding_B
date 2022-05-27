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
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=LAPTOP-GHEF0MBM\\EGY;database = register;User ID=sa;Password=egyputradbncr78");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter db = new SqlDataAdapter();

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtUser.Text == "" && txtPass.Text=="" && txtComPass.Text == "")
            {
                MessageBox.Show("Username and Password Fields are empty", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == txtComPass.Text)
            {
                con.Open();
                string register = "INSERT INTO daftar (username,password) VALUES ('" + TxtUser.Text + "' , '" + txtPass.Text + "')";
                cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                TxtUser.Text = "";
                txtPass.Text = "";
                txtComPass.Text = "";

                MessageBox.Show("Your Account has been successfully","Register succes", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not match, please Re-Enter", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtComPass.Text = "";
                txtPass.Focus();
            }
            
           
           
        }

        private void ckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtComPass.PasswordChar = '\0';

            }
            else
            {
                txtPass.PasswordChar = '*';
                txtComPass.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtUser.Text = "";
            txtPass.Text = "";
            txtComPass.Text = "";
            TxtUser.Focus();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void registerform_Load(object sender, EventArgs e)
        {

        }
    }
}

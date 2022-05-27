using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXE2
{
    public partial class gridView : Form
    {
        public gridView()
        {
            InitializeComponent();
        }

        

        private void gridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRODIDataSet1.tampil_mahasiswa' table. You can move, or remove it, as needed.
            this.tampil_mahasiswaTableAdapter.Fill(this.pRODIDataSet1.tampil_mahasiswa);

        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataView dv = new dataView();

            dv.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dv.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dv.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dv.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dv.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dv.textBox6.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dv.textBox7.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dv.textBox8.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();

            dv.ShowDialog();
            this.Hide();

        }
    }
}

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
    public partial class navigation : Form
    {
        public navigation()
        {
            InitializeComponent();
        }

        private void navigation_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRODIDataSet3.tampil_mahasiswa' table. You can move, or remove it, as needed.
            this.tampil_mahasiswaTableAdapter.Fill(this.pRODIDataSet3.tampil_mahasiswa);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }
    }
}

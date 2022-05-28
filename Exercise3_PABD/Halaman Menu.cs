using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3_PABD
{
    public partial class Halaman_Menu : Form
    {
        public Halaman_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Halaman_Data_Mahasiswa().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Halaman_Binding_Navigation().Show();
        }
    }
}

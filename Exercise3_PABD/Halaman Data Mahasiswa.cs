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
    public partial class Halaman_Data_Mahasiswa : Form
    {
        public Halaman_Data_Mahasiswa()
        {
            InitializeComponent();
        }

        private void Halaman_Data_Mahasiswa_Load(object sender, EventArgs e)
        {
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Halaman_Menu().Show();

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("zaki") && textBox2.Text.Equals("123"))
            {
                new Halaman_Menu().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Periksa kembali Username dan Id anda");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

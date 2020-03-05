using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MayınTarlası
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.Color;
            this.Size = Properties.Settings.Default.Size;
            this.Location = Properties.Settings.Default.Location;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="" && comboBox1.Text=="5")
            {
                Form2 New = new Form2(this);    
                this.Hide();
                New.ShowDialog();
            }
            else
            {
                MessageBox.Show("Gerekli Yerleri Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}

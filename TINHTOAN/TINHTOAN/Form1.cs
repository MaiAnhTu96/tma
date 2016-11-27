using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TINHTOAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t;
            t = Convert.ToString(textBox1.Text);
            if (t == "")
            {
                MessageBox.Show("CHUA NHAP GI !!! ", "MESSENGER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }
            else
            {
                int sum;
                sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox3.Text = sum.ToString();
                btnC.Enabled = false;
            }          
         }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult h= MessageBox.Show("BAN MUON THOAT HAY KHONG", "THOAT", MessageBoxButtons.YesNo);
            if (h==DialogResult.Yes)
                this.Close();
            else
                this.textBox1.Focus();
        }
        //THAO TAC TINH TOAN
        private void button2_Click(object sender, EventArgs e)
        {
            int tru;
            tru = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            textBox3.Text = tru.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nhan;
            nhan = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            textBox3.Text = nhan.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float chia;
            chia = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
            textBox3.Text = chia.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            btnC.Enabled = true;
        }

       
    }
}

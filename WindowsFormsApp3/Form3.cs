using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        kargo kargo = new kargo();
        private void btngiris_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            if (k.kadi == textBox1.Text && k.ksifre == textBox2.Text)
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı yada şifre hatalı");
            }
            //k.kadi = textBox1.Text;
            //k.ksifre = textBox2.Text;
            //Form4 f4 = new Form4();
            //f4.Show();
            //this.Hide();
            //if(textBox1.Text=="seda" && textBox2.Text == "123")
            //{
            //    Form4 f4 = new Form4();
            //    f4.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı adı yada şifre hatalı");
            //}
        }
    }
}

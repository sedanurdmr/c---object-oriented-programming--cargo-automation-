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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kargo kargocontext = new kargo();
            dataGridView1.DataSource = kargocontext.kargotakip.ToList();

            kargo kc = new kargo();
            var kargot = from gonderen in kc.gonderen
                      select gonderen.gid;
            comboBox1.DataSource = kargot.ToList();

            dataGridView1.Columns[4].Visible = false;
        }
        void listele()
        {
            dataGridView1.DataSource = kargo.kargotakip.ToList();
        }
        kargo kargo = new kargo();

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kargotakip kt = new kargotakip();
            kt.ktyer = comboBox2.Text;
            kt.ktdurum = comboBox3.Text;
            kt.gid =Convert.ToInt32(comboBox1.Text);
            kargo.kargotakip.Add(kt);
            kargo.SaveChanges();
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int kargotakipid = Convert.ToInt32(tbguncelle.Text);
            kargotakip a = kargo.kargotakip.Where(x => x.ktid == kargotakipid).FirstOrDefault();
            //if (a != null)
            //{
            kargo.kargotakip.Remove(a);
                kargo.SaveChanges();
            //}
            //else
            //{
            //    MessageBox.Show("ID'ye ait veri bulunamadı");
            //}

            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int kargotakipid = Convert.ToInt32(tbguncelle.Text);
            kargotakip a = kargo.kargotakip.Where(x => x.ktid == kargotakipid).FirstOrDefault();
            a.ktyer = comboBox2.Text;
            a.ktdurum = comboBox3.Text;
            a.gid = Convert.ToInt32(comboBox1.Text);
            kargo.SaveChanges();
            listele();

        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbguncelle.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

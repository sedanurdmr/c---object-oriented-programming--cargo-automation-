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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kargo kargocontext = new kargo();
            dataGridView1.DataSource = kargocontext.gonderen.ToList();
            dataGridView2.DataSource = kargocontext.alici.ToList();
            dataGridView3.DataSource = kargocontext.kargoozellik.ToList();

            kargo kc = new kargo();
            var gon = from gonderen in kc.gonderen
                      select gonderen.gid;
            comboBox1.DataSource = gon.ToList();


            //comboBox1.ValueMember = "gid";
            //comboBox1.DisplayMember = "gadi";
            //comboBox1.DataSource = kargo.gonderen.ToList();

            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView3.Columns[6].Visible = false;
        }
        void listele()
        {
            dataGridView1.DataSource = kargo.gonderen.ToList();
            dataGridView2.DataSource = kargo.alici.ToList();
            dataGridView3.DataSource = kargo.kargoozellik.ToList();
        }
        kargo kargo = new kargo();
        private void btngkaydet_Click(object sender, EventArgs e)
        {
            gonderen g = new gonderen();
            g.gtc = tbgtc.Text;
            g.gadi = tbgadi.Text;
            g.gsoyadi = tbgsoyadi.Text;
            g.gtelefon = tbgtelefon.Text;
            g.gbayi = cbgbayi.Text;
            g.gtarih = tarih.Text;
            g.gadres = tbgadres.Text;
            kargo.gonderen.Add(g);
            kargo.SaveChanges();
            listele();
        }

        private void btngsil_Click(object sender, EventArgs e)
        {
            int gonderenid = Convert.ToInt32(tbgguncelle.Text);
            gonderen g = kargo.gonderen.Where(x => x.gid == gonderenid).FirstOrDefault();
            //if (g != null)
            ////{
            kargo.gonderen.Remove(g);
                kargo.SaveChanges();
            //}
            //else
            //{
               // MessageBox.Show("ID'ye ait veri bulunamadı");
            //}

            listele();
        }

        private void btngguncelle_Click(object sender, EventArgs e)              
        {
            int gonderenid = Convert.ToInt32(tbgguncelle.Text);
            gonderen g = kargo.gonderen.Where(x => x.gid == gonderenid).FirstOrDefault();
            g.gtc = tbgtc.Text;
            g.gadi = tbgadi.Text;
            g.gsoyadi = tbgsoyadi.Text;
            g.gtelefon = tbgtelefon.Text;
            g.gbayi = cbgbayi.Text;
            g.gtarih = tarih.Text;
            g.gadres = tbgadres.Text;
            kargo.SaveChanges();
            listele();
        }

        private void btngyenikayit_Click(object sender, EventArgs e)
        {
            tbgtc.Text = "";
            tbgadi.Text = "";
            tbgsoyadi.Text = "";
            tbgtelefon.Text = "";
            cbgbayi.Text = "";
            tarih.Text = "";
            tbgadres.Text = "";
        }

        private void btnakaydet_Click(object sender, EventArgs e)
        {
            alici a = new alici();
            a.atc = tbatc.Text;
            a.aadi = tbaadi.Text;
            a.asoyadi = tbasoyadi.Text;
            a.atelefon = tbatelefon.Text;
            a.abayi = cbabayi.Text;
            a.aadres = tbaadres.Text;
            kargo.alici.Add(a);
            kargo.SaveChanges();
            listele();
        }

        private void btnasil_Click(object sender, EventArgs e)
        {
            int aliciid = Convert.ToInt32(tbaguncelle.Text);
            alici a = kargo.alici.Where(x => x.aid == aliciid).FirstOrDefault();
            //if (a != null)
            //{
            kargo.alici.Remove(a);
            kargo.SaveChanges();
            //}
            //else
            //{
               //MessageBox.Show("ID'ye ait veri bulunamadı");
            //}

            listele();
        }

        private void btnaguncelle_Click(object sender, EventArgs e)
        {
            int aliciid = Convert.ToInt32(tbaguncelle.Text);
            alici a = kargo.alici.Where(x => x.aid == aliciid).FirstOrDefault();
            a.atc = tbatc.Text;
            a.aadi = tbaadi.Text;
            a.asoyadi = tbasoyadi.Text;
            a.atelefon = tbatelefon.Text;
            a.abayi = cbabayi.Text;
            a.aadres = tbaadres.Text;
            kargo.SaveChanges();
            listele();
        }

        private void btnayenikayit_Click(object sender, EventArgs e)
        {
            tbatc.Text = "";
            tbaadi.Text = "";
            tbasoyadi.Text = "";
            tbatelefon.Text = "";
            cbabayi.Text = "";
            tbaadres.Text = "";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kargoozellik ko = new kargoozellik();
            //gonderen go = new gonderen();
            ko.kurun =Convert.ToString( cburun.Text);
            ko.kadet = tbadet.Text;
            ko.kagirlik = tbagırlık.Text;
            ko.kucret = tbucret.Text;
            ko.gid = (int)comboBox1.SelectedValue;
            //ko.gid = Convert.ToInt32(comboBox1.Text);
            //go.gadi = Convert.ToString(comboBox1.Text);
            kargo.kargoozellik.Add(ko);
            kargo.SaveChanges();
            listele();

            //kargo kc = new kargo();
            //var gon = from gonderen in kc.gonderen
            //          select gonderen.gadi;
            //comboBox1.DataSource = gon.ToList();

            //var al = from alici in kc.alici
            //         select alici.aadi;
            //comboBox2.DataSource = al.ToList();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int kargoozellikid = Convert.ToInt32(tbguncelle.Text);
            kargoozellik a = kargo.kargoozellik.Where(x => x.kid == kargoozellikid).FirstOrDefault();
            //if (a != null)
            //{
                kargo.kargoozellik.Remove(a);
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
            int kargoozellikid = Convert.ToInt32(tbguncelle.Text);
            kargoozellik a = kargo.kargoozellik.Where(x => x.kid == kargoozellikid).FirstOrDefault();
            a.kurun = cburun.Text;
            a.kadet = tbadet.Text;
            a.kagirlik = tbagırlık.Text;
            a.kucret = tbucret.Text;
            a.gid = Convert.ToInt32(comboBox1.Text);
            kargo.SaveChanges();
            listele();
        }
        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            cburun.Text = "";
            tbadet.Text = "";
            tbagırlık.Text = "";
            tbucret.Text = "";
            comboBox1.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbgguncelle.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbgtc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbgadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbgsoyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbgtelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbgbayi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbgadres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbaguncelle.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            tbatc.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            tbaadi.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            tbasoyadi.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            tbatelefon.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            cbabayi.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            tbaadres.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbguncelle.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            cburun.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            tbadet.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            tbagırlık.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            tbucret.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string aranan = textBox1.Text;
            //var query = from k in kargo.gonderen
            //            where k.gadi.Contains(aranan)
            //            select k;
            //dataGridView1.DataSource = query;

            //var blogs = from b in kargo.gonderen
            //            where b.gadi.StartsWith(textBox1.Text)
            //            select b;
            //dataGridView1.DataSource = blogs;


        }
    }
}

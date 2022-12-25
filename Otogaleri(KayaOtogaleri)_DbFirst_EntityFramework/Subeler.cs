using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otogaleri_KayaOtogaleri__DbFirst_EntityFramework
{
    public partial class Subeler : Form
    {
        public Subeler()
        {
            InitializeComponent();
        }
        

        GaleriEntities2 con = new GaleriEntities2();

        public void Liste()
        {
            dataGridView1.DataSource = con.SubeBilgileris.ToList();
        }

        private void polikliniklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subeler go = new Subeler();
            go.Show();
            this.Hide();
        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Araclar go = new Araclar();
            go.Show();
            this.Hide();
        }

        private void hastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteriler go = new Musteriler();
            go.Show();
            this.Hide();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar();
            go.Show();
            this.Hide();
        }

        private void Subeler_Load(object sender, EventArgs e)
        {

            comboBox1.DataSource = con.SubeBilgileris.ToList();
            comboBox1.ValueMember = "SubeNo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubeBilgileri save = new SubeBilgileri();

            save.SubeAdi = textBox2.Text;
            save.CalisanSayisi = Convert.ToInt32(textBox3.Text);
            save.SubeCiro = Convert.ToDecimal(textBox4.Text);
            save.MusteriNo = Convert.ToInt32(comboBox1.Text);
            con.SubeBilgileris.Add(save);
            con.SaveChanges();
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["SubeNo"].Value.ToString();
            textBox2.Text = satir.Cells["SubeAdi"].Value.ToString();
            textBox3.Text = satir.Cells["CalisanSayisi"].Value.ToString();
            textBox4.Text = satir.Cells["SubeCiro"].Value.ToString();
            comboBox1.Text = satir.Cells["MusteriNo"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int subeno = Convert.ToInt32(textBox1.Text);
            var yenile = con.SubeBilgileris.Where(x => x.SubeNo == subeno).FirstOrDefault();
            yenile.SubeAdi = textBox2.Text;
            yenile.CalisanSayisi = Convert.ToInt32(textBox3.Text);
            yenile.SubeCiro = Convert.ToDecimal(textBox4.Text);
            yenile.MusteriNo = Convert.ToInt32(comboBox1.Text);


            con.SaveChanges();
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Liste();
        }
    }
}

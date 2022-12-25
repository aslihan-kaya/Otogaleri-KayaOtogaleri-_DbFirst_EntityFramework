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
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }
        GaleriEntities2 con = new GaleriEntities2();
        public void Liste()
        {
            dataGridView1.DataSource = con.AracBilgileris.ToList();
        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Araclar go = new Araclar();
            go.Show();
            this.Hide();
        }

        private void polikliniklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subeler go = new Subeler();
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

        private void Araclar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracBilgileri save = new AracBilgileri();
            save.AracFiyat = Convert.ToDecimal(textBox2.Text);
            save.AracAdet = Convert.ToInt32(textBox3.Text);
            save.AracMarka = textBox4.Text;
            save.AracModel = textBox5.Text;
            save.AracYil = textBox6.Text;
            save.AracOzellik = textBox7.Text;
            save.AracMotor = textBox8.Text;
            save.AracPaket = textBox9.Text;
            save.AracRenk = textBox10.Text;
            save.SubeNo = Convert.ToInt32(comboBox1.Text);

            con.AracBilgileris.Add(save);
            con.SaveChanges();
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["AracNo"].Value.ToString();
            textBox2.Text = satir.Cells["AracFiyat"].Value.ToString();
            textBox3.Text = satir.Cells["AracAdet"].Value.ToString();
            textBox4.Text = satir.Cells["AracMarka"].Value.ToString();
            textBox5.Text = satir.Cells["AracModel"].Value.ToString();
            textBox6.Text = satir.Cells["AracYil"].Value.ToString();
            textBox7.Text = satir.Cells["AracOzellik"].Value.ToString();
            textBox8.Text = satir.Cells["AracMotor"].Value.ToString();
            textBox9.Text = satir.Cells["AracPaket"].Value.ToString();
            textBox10.Text = satir.Cells["AracRenk"].Value.ToString();
            comboBox1.Text = satir.Cells["SubeNo"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(textBox1.Text);
            var yenile = con.AracBilgileris.Where(x => x.AracNo == ano).FirstOrDefault();
            yenile.AracFiyat = Convert.ToDecimal(textBox2.Text);
            yenile.AracAdet = Convert.ToInt32(textBox3.Text);
            yenile.AracMarka = textBox4.Text;
            yenile.AracModel = textBox5.Text;
            yenile.AracYil = textBox6.Text;
            yenile.AracOzellik = textBox7.Text;
            yenile.AracMotor = textBox8.Text;
            yenile.AracPaket = textBox9.Text;
            yenile.AracRenk = textBox10.Text;
            yenile.SubeNo = Convert.ToInt32(comboBox1.Text);


            con.SaveChanges();
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Liste();
        }
    }
}

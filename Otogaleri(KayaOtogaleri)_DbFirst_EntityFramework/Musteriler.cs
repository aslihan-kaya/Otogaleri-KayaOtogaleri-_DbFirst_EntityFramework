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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        GaleriEntities2 con = new GaleriEntities2();
        public void Liste()
        {
            dataGridView1.DataSource = con.MusteriBilgileris.ToList();
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

        private void Musteriler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriBilgileri save = new MusteriBilgileri();

            save.MusteriAdSoyad = textBox2.Text;
            save.MusteriTelefon = maskedTextBox1.Text;
            save.MusteriYas = Convert.ToInt32(textBox3.Text);
            save.MusteriBakiye = Convert.ToDecimal(textBox4.Text);
            con.MusteriBilgileris.Add(save);
            con.SaveChanges();
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mno = Convert.ToInt32(textBox1.Text);
            var yenile = con.MusteriBilgileris.Where(x => x.MusteriNo == mno).FirstOrDefault();
            yenile.MusteriAdSoyad = textBox2.Text;
            yenile.MusteriTelefon = maskedTextBox1.Text;
            yenile.MusteriYas = Convert.ToInt32(textBox3.Text);
            yenile.MusteriBakiye = Convert.ToDecimal(textBox4.Text);


            con.SaveChanges();
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Liste();
        }
    }
}

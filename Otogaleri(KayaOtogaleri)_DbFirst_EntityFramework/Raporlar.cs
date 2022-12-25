using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otogaleri_KayaOtogaleri__DbFirst_EntityFramework
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Server=MSI;Database=Galeri;Integrated Security=true");

        public void method(string scode)
        {
            SqlDataAdapter dp = new SqlDataAdapter(scode, baglan); //parametre alınmış
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

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

        private void button1_Click(object sender, EventArgs e)
        {
            method("select* from AracBilgileri order by AracModel desc");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            method("select Sum(AracFiyat) from AracBilgileri group by AracMarka");
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }
    }
}

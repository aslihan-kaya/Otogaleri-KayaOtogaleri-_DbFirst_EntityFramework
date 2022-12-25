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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GaleriEntities2 con = new GaleriEntities2();

        private bool Giris(string ad, string sifre)
        {
            var sorgu = from p in con.Kullanicilars
                        where p.KullaniciAdi == ad && p.Sifre == sifre
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanicilar save = new Kullanicilar();
            save.KullaniciAdi = textBox4.Text;
            save.Sifre = textBox3.Text;
            save.Telefon = textBox5.Text;
            save.Mail = textBox6.Text;
            con.Kullanicilars.Add(save);
            con.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Giris(textBox1.Text, textBox2.Text))
            {
                Subeler anasayfagit = new Subeler();
                anasayfagit.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre hatalı");
            }
        }
    }
}

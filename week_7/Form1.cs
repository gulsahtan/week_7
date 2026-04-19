using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace week_7
{
    public partial class Form1 : Form
    {
        public class Student
        {
            public int Id { get; set; }
            public int Numara { get; set; }
            public string AdSoyad { get; set; }
            public string Bolum { get; set; }
            
        }

        private List<Student> ogrenciler = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBolum.Items.Add("YBS");
            comboBolum.Items.Add("Bilg.");
            comboBolum.Items.Add("End.");

            ogrenciler.Add(new Student { Id = 1, Numara = 101, AdSoyad = "Ali Yılmaz", Bolum = "BST" });
            ogrenciler.Add(new Student { Id = 2, Numara = 102, AdSoyad = "Ayşe Demir", Bolum = "Bilg." });
            ogrenciler.Add(new Student { Id = 3, Numara = 103, AdSoyad = "Mehmet Kaya", Bolum = "End." });

            ListeyiYenile();

            listBoxOgrenciler.SelectedIndexChanged += listBoxOgrenciler_SelectedIndexChanged;
        }
        private Student SeciliOgrenciyiGetir()
        {
            int index = listBoxOgrenciler.SelectedIndex;

            if (index == -1)
                return null;

            return ogrenciler[index];
        }
        private void ListeyiYenile()
        {
            listBoxOgrenciler.Items.Clear();

            foreach (var ogr in ogrenciler)
            {
                listBoxOgrenciler.Items.Add(
                    ogr.Numara + " - " + ogr.AdSoyad + " (" + ogr.Bolum + ")"
                );
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumara.Text, out int numara))
            {
                MessageBox.Show("Numara sayısal olmalı");
                return;
            }

            Student yeni = new Student
            {
                Id = ogrenciler.Count + 1,
                Numara = numara,
                AdSoyad = txtAdSoyad.Text,
                Bolum = comboBolum.Text
            };

            ogrenciler.Add(yeni);
            ListeyiYenile();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Student secili = SeciliOgrenciyiGetir();

            if (secili == null)
            {
                MessageBox.Show("Öğrenci seçiniz");
                return;
            }

            if (!int.TryParse(txtNumara.Text, out int numara))
            {
                MessageBox.Show("Numara sayısal olmalı");
                return;
            }

            secili.Numara = numara;
            secili.AdSoyad = txtAdSoyad.Text;
            secili.Bolum = comboBolum.Text;

            ListeyiYenile();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = listBoxOgrenciler.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Öğrenci seçiniz");
                return;
            }

            ogrenciler.RemoveAt(index);
            ListeyiYenile();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizleGiris();
        }

        private void listBoxOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student secili = SeciliOgrenciyiGetir();

            if (secili == null)
                return;

            txtNumara.Text = secili.Numara.ToString();
            txtAdSoyad.Text = secili.AdSoyad;
            comboBolum.Text = secili.Bolum;
        }

        private void TemizleGiris()
        {
            txtNumara.Clear();
            txtAdSoyad.Clear();
            comboBolum.SelectedIndex = -1;
            listBoxOgrenciler.ClearSelected();
            txtNumara.Focus();
        }

        private void txtNumara_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxOgrenciler_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication35
{
    public partial class Muammer : Form
    {
        Bitmap kaynak, islem;
        public Muammer()
        {
            InitializeComponent();
        }

        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                ResimKutusu1.Image = kaynak;
            }
        }

        private void bT709AlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = (int)((double)(renkliRenk.R * 0.2125) + (double)(renkliRenk.G * 0.7154) + (double)(renkliRenk.B * 0.072));
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);


                }

                ResimKutusu2.Image = islem;

            }
        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = (int)(double)((renkliRenk.R * 0.3) + (renkliRenk.G * 0.59) + (renkliRenk.B * 0.11));
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);


                }

                ResimKutusu2.Image = islem;
            }
        }

        private void açıklıkYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int genislik = kaynak.Width;
            int yukseklik = kaynak.Height;


            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Math.Max(renkliRenk.B, (Math.Max(renkliRenk.R, renkliRenk.G)) + Math.Min(renkliRenk.B, Math.Min(renkliRenk.R, renkliRenk.G))) / 2;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);


                }

                ResimKutusu2.Image = islem;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = (renkliRenk.R | renkliRenk.G | renkliRenk.B);
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);


                }

                ResimKutusu2.Image = islem;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariOdev
{
    public partial class Form1 : Form
    {
        int koltuknotemp;

        public Form1()
        {
            InitializeComponent();
        }

        LinkedList biletler  = new LinkedList();

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            koltuknotemp = Convert.ToInt32(b.Text);
            //1.Ad soyad ilk sec
            //2.koltuk seç
            if (b.BackColor == Color.Red) // Dolu, silme işlemi yap
            {
                //silme işleminde sorun var

               // MessageBox.Show("Silindi");
                b.BackColor = Color.Lime;
                biletler.DeletePos(koltuknotemp);
              
            }
            else // Boş, ekleme yap
            {
                //MessageBox.Show("Eklendi");
                b.BackColor = Color.Red;
                Bilet bilet = new Bilet();
                bilet.musteri = new Musteri(txtAd.Text,txtSoyad.Text);
                bilet.SecilenKoltuk = koltuknotemp;
                biletler.InsertPos(koltuknotemp, bilet);
               
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtSoyad.Text = "";
        }

        private void biletal(string isim,string soyisim,int koltukno)
        {
            MessageBox.Show("isim:" + isim + " soyisim:" + soyisim + " " + "koltuk no:" + koltukno);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            Node current = new Node();
            current = biletler.Head;
            if (current == null)
                return;

            lstboxListe.Items.Clear();

            do
            {
                Musteri m = current.Data.musteri;
                lstboxListe.Items.Add(
                    "koltuk: " + current.Data.SecilenKoltuk + " " + m.Ad + " " + m.Soyad
                );
                if (current.Next == null)
                    break;
                else
                    current = current.Next;
                
            } while (true);

        }
    }
}

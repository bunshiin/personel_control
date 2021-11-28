using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personel_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Evrensel Diziler
        string[] tcno;
        string[] ad;
        string[] soyad;
        string[] birim;
        string[] bastarih;
        string[] dogumyer;
        string[] dogumtarih;
        //Evrensel Değişkenler
        int primliMaas;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void personel_btn_Click(object sender, EventArgs e)
        {
            tcno = new string[100];
            ad = new string[100];
            soyad = new string[100];
            birim = new string[100];
            bastarih = new string[100];
            dogumyer = new string[100];
            dogumtarih = new string[100];

            tcno[0] = textBox1.Text;
            ad[0] = textBox2.Text;
            soyad[0] = textBox3.Text;
            birim[0] = comboBox1.Text;
            bastarih[0] = textBox8.Text;
            dogumyer[0] = comboBox2.Text;
            dogumtarih[0] = textBox9.Text;
            personelBox1.Items.Add("Tc: " + tcno[0] + " Ad: " + ad[0] + " Soyad: " + soyad[0] + " Birim: " + birim[0] + " İşe Katılma: " + bastarih[0] + " Memleket: " + dogumyer[0] + " Doğum Tarihi: " + dogumtarih[0]);
            
        }

        private void prim_btn_Click(object sender, EventArgs e)
        {
          int kiralananEv = int.Parse(textBox4.Text);
          int satılanEv = int.Parse(textBox5.Text);

          kiralananEv *= 250;
          satılanEv *= 500;

          primliMaas = (kiralananEv + satılanEv) + 4000;
          primlimaas_lbl.Text = primliMaas.ToString();
        }

        private void tazminat_btn_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                error_lbl.Text = "Gerekli alanlar boş bırakılmamalı";
                return;
            }
            if (textBox7.Text == "")
            {
                error_lbl.Text = "Gerekli alanlar boş bırakılmamalı";
                return;
            }
            int yıl,baslamazamanı;
            yıl = int.Parse(textBox6.Text);
            baslamazamanı = int.Parse(textBox7.Text);

            

            if (yıl - baslamazamanı > 5)
            {
                primliMaas += 7000;
                tanzimatpara_lbl.Text = primliMaas.ToString();
           
            }
            else
            {
                error_lbl.Text = "Yıllık Tazminat Başvurusu Yapmak İçin 5 Yıldır Aynı Kamuda Görev Yapıyor Olmuş Olmanız Gerekir";
            }
            
        }
    }
}

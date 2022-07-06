using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolbar.Busnies;
using toolbar.Entities;

namespace toolbar
{
    public partial class Form1 : Form
    {
        public TimeSpan fark;
        public Form1()
        {
            InitializeComponent();
        }

        private int saniye = 60;
        int dakika = 0;
        int saat = 0;
        int gün = 0;
        public void btnHesapla_Click(object sender, EventArgs e)
        {
            int baslangic = dtBaslangic.Date.DayOfYear;
            int bitis = dtBitis.Value.DayOfYear;
            int cnt=0;

            for (int k = baslangic; k < bitis+(dtBitis.Value.Year-dtBaslangic.Date.Year)*365; k++)
            {
                DayOfWeek dayOfWeek = new DateTime(dtBaslangic.Date.Year, 1, 1).AddDays(k - 1).DayOfWeek;

                if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)  
                {
                    
                }
                else
                {
                    cnt++;
                }
            }
            Console.WriteLine(dtBaslangic.Date.Year + " " + cnt);

            dateTimeSettings(baslangic, DateTime.Now, bitis);

        }

        void dateTimeSettings(int baslangic, DateTime simdi, int bitis)
        {
            int tatil = 0;
            int tatil2 = 0;
            for (int i = baslangic; i < bitis; i++)
            {
                DayOfWeek dayOfWeek = new DateTime(simdi.Year, 1, 1).AddDays(i - 1).DayOfWeek;

                if (dayOfWeek == DayOfWeek.Saturday)
                {
                    tatil += 1;
                    if (i < simdi.DayOfYear)
                    {
                        tatil2 += 1;
                    }
                }
                else if (dayOfWeek == DayOfWeek.Sunday)
                {
                    tatil += 1;
                    if (i < simdi.DayOfYear)
                    {
                        tatil2 += 1;
                    }
                }
            }
            int aralık = bitis - baslangic - tatil;
            if (aralık != 0)
            {
                int bolum = 100 / aralık;
                int bar = bolum * (simdi.DayOfYear - baslangic - tatil2);
                progressBar1.Value = bar ;
            }
            else
            {
                progressBar1.Value = 100;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            fark = DateTime.Parse(dtBitis.Text) - DateTime.Parse(dtBaslangic.Text);
            txtBGün.Text = fark.TotalDays.ToString();
            txtBSaat.Text = fark.TotalHours.ToString();
            txtBDakika.Text = fark.TotalMinutes.ToString();

            timer1.Start();

            dakika = Convert.ToInt32(txtBDakika.Text);
            saat = Convert.ToInt32(txtBSaat.Text);
            gün = Convert.ToInt32(txtBDakika.Text);
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval= 1;
            saniye = saniye - 1;
            

            txtBSaniye.Text = saniye.ToString();
            txtBDakika.Text = (dakika - 1).ToString();
            txtBSaat.Text = (saat - 1).ToString();
            //txtBGün.Text= (gün -1).ToString();
            if (saniye== 0)
            {
                dakika = dakika - 1;
                txtBDakika.Text = dakika.ToString();
                saniye = 60;
            }
            if (dakika == 0)
            {
                saat = saat -1;
                txtBSaat.Text = saat.ToString();
                dakika = 1440;
            }
            if (saat == 0)
            {
                gün = gün -1;
                txtBGün.Text = gün.ToString();
            }
            if (gün == 0)
            {
                timer1.Stop();
                progressBar1.BackColor= Color.Red;
            }
            if (txtBDakika.Text=="-1")
            {
                timer1.Stop();
                txtBDakika.Text = "0";
                txtBSaat.Text = "0";
                txtBGün.Text="0";
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
             Application.Restart();
        }
    }
}

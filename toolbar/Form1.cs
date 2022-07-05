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
        MyTimesManager _myTimesManager = new MyTimesManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            label1.Text = dtBaslangic.Value.DayOfYear.ToString();
            label2.Text = dtBitis.Value.DayOfYear.ToString();
            DateTime now = DateTime.Now;

            Int32 baslangic = dtBaslangic.Value.DayOfYear;
            Int32 bitis = dtBitis.Value.DayOfYear;
            Int32 tatil = 0;
            for (int i = baslangic; i < bitis; i++)
            {
                
                if (new DateTime(now.Year, 1, 1).AddDays(i - 1).DayOfWeek == DayOfWeek.Saturday)
                {
                    tatil += 1;
                } 
                else if (new DateTime(now.Year, 1, 1).AddDays(i - 1).DayOfWeek == DayOfWeek.Sunday)
                {
                    tatil += 1;
                }
            }

            Int32 fark = bitis - baslangic - tatil;
            if (fark != 0)
            {
                Int32 bolum = 100 / fark;
                Int32 bar = bolum * (now.DayOfYear - dtBaslangic.Value.DayOfYear);
                progressBar1.Value = bar;
            }
            else
            {
                progressBar1.Value = 100;
            }
            
        }
    }
}

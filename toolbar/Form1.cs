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
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int baslangic = dtBaslangic.Value.DayOfYear;
            int bitis = dtBitis.Value.DayOfYear;

            dateTimeSettings(baslangic, DateTime.Now, bitis);
            
=======
>>>>>>> 5d90d1759aac1aeec6da9a647d0d9ec44cf795f8
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

            int fark = bitis - baslangic - tatil;
            if (fark != 0)
            {
                int bolum = 100 / fark;
                int bar = bolum * (simdi.DayOfYear - baslangic - tatil2);
                progressBar1.Value = bar;
            }
            else
            {
                progressBar1.Value = 100;
            }
        }
    }
}

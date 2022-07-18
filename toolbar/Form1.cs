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
using System.Runtime.InteropServices;


namespace toolbar
{
    public partial class Form1 : Form
    {
        public TimeSpan fark;
        public Form1()
        {
            InitializeComponent();
        }

        private int saniye = 0;
        
        int temp = 0;

        int totalDaysOfWeeks = 0;
        int shiftTime = 10;
        public void btnHesapla_Click(object sender, EventArgs e)
        {

            DateTime d1 = this.dtBaslangic.Value.Date;
            DateTime d2 = this.dtBitis.Value.Date;

            int sumDays = Convert.ToInt32((d2 - d1).TotalDays);


           int kalan1 = 8 - dayToInt((d1.DayOfWeek));
           int kalan2 = dayToInt((d2.DayOfWeek));
           int sumWeek = ((sumDays + 8 - kalan1 - kalan2) * (5)/7)-5;
           
           Console.WriteLine(sumWeek);
           Console.WriteLine(" sumDays = " + sumDays + " kalan1 = " + kalan1 + " kalan2 = " + kalan2);

            int firstWeek = 0;
           int lastWeek = 0;
           if (d1.DayOfWeek == DayOfWeek.Saturday || d1.DayOfWeek == DayOfWeek.Sunday)
           {
               firstWeek = 0;
           }
           else
           {
               firstWeek = 6 - dayToInt((d1.DayOfWeek));
            }

           if (d2.DayOfWeek == DayOfWeek.Saturday || d2.DayOfWeek == DayOfWeek.Sunday)
           {
               lastWeek = 5;
           }
           else
           {
               lastWeek = dayToInt((d2.DayOfWeek));
           }
           
           totalDaysOfWeeks = firstWeek + lastWeek + sumWeek;

           Console.WriteLine("firstWeek = " + firstWeek + "  lastWeek = " + lastWeek + "sumDay = " + sumDays + " sumWeek = " + sumWeek + "  totalDaysOfWeeks = " + totalDaysOfWeeks);
           Console.WriteLine(" sumDays = " + sumDays + " kalan1 = " + kalan1 + " kalan2 = " + kalan2 + " d1 day = " + d1.DayOfWeek + " d2 day = " +d2.DayOfWeek);

           saniye = totalDaysOfWeeks * 3600 * shiftTime;
           Console.WriteLine(saniye + " " + totalDaysOfWeeks);

            int shiftHour = 17;
            int shiftMinute = 40;
            int shiftWorkingSecond = (shiftHour * 3600) + (shiftMinute * 60);
            int nowSecond = (DateTime.Now.Hour * 3600) + (DateTime.Now.Minute * 60);

            Console.WriteLine(shiftWorkingSecond- nowSecond);
            if (nowSecond> shiftWorkingSecond )
            {
                saniye = (totalDaysOfWeeks - 1) * 3600 * shiftTime;
            }
            else
            {
                saniye = ((totalDaysOfWeeks - 1) * 3600 * shiftTime) + (shiftWorkingSecond - nowSecond);
            }
            temp = saniye;

            
            timer1.Start();
            
        
        }

        public int dayToInt(DayOfWeek varDate)
        {

            if (varDate == DayOfWeek.Monday)
            {
                return 1;
            }

            if (varDate == DayOfWeek.Tuesday)
            {
                return 2;
            }

            if (varDate == DayOfWeek.Wednesday)
            {
                return 3;
            }

            if (varDate == DayOfWeek.Thursday)
            {
                return 4;
            }

            if (varDate == DayOfWeek.Friday)
            {
                return 5;
            }

            if (varDate == DayOfWeek.Saturday)
            {
                return 6;
            }

            if (varDate == DayOfWeek.Sunday)
            {
                return 7;
            }
            return 8;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;

            saniye = saniye - 10;

            //Console.WriteLine(saniye);

            if (saniye <= 0)
            {
                saniye = 0;
                txtBSaniye.Text = (saniye % 60).ToString();
                timer1.Stop();
                progressBar1.ForeColor = Color.Red;
            }
           

            txtBSaniye.Text = (saniye%60).ToString();
            txtBDakika.Text = ((saniye%3600)/60).ToString();
            txtBSaat.Text = ((saniye%(3600*shiftTime))/3600).ToString();
            txtBGün.Text = ((saniye/(shiftTime*3600))).ToString();


            progressBar1.Value = (((temp) - saniye) * 1000) / (temp);

            lblPercentage.Text = " %" + ((((temp) - saniye) * 100) / (temp)).ToString();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 50;
            
        }

        private void chbDone_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.ForeColor = Color.Red;
        }
    }
}












        


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void threadbtn1_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false; // Threadlerin kontrolünü bu kısımda tamamen elimize alıyoruz.
            
            //Threadleri Tanımlıyoruz
            Thread thr1 = new Thread(new ThreadStart(threadFunc1));
            Thread thr2 = new Thread(new ThreadStart(threadFunc2));
            Thread thr3 = new Thread(new ThreadStart(threadFunc3));
            Thread thr4 = new Thread(new ThreadStart(threadFunc4));
            //Threadleri göreve çağrıyoruz
            thr1.Start();
            thr2.Start();
            thr3.Start();
            thr4.Start();
     
        }   

        public void threadFunc1()
        {
            int i = 0;
            while (i<1000000)
            {
                if (i % 2 == 1)
                {
                    txtTekSayi.Text = txtTekSayi.Text + Convert.ToString(i) + "\n";
                }
                i++;
            }
            Thread.Sleep(0);
        }
        public void threadFunc2()
        {
            int i = 0;
            while (i < 1000000)
            {
                if (i % 2 == 0)
                {
                    txtCiftSayi.Text = txtCiftSayi.Text + Convert.ToString(i) + "\n";
                }
                i++;
            }
            Thread.Sleep(0);
            
        }
        public void threadFunc3()
        {
            //Bu threadimiz 0 ile 500.000 arasındaki asal sayıları bulmakla mükelleftir.
            int kontrol = 0;
            int sayac = 0;
            for (int i = 2; i <= 500000; i++)
            {
                kontrol = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol++;
                        break;
                    }
                }
                if (kontrol == 0)
                {
                    sayac++;
                    txtAsalSayi.Text += Convert.ToString(i) + "\n";
                }
            }
            Thread.Sleep (0);
        }
        public void threadFunc4()
        {
            //Bu threadimiz 500.000 ile 1.000.000 arasındaki asal sayıları bulmakla mükelleftir.
            int kontrol = 0;
            int sayac = 0;
            for (int i = 500000; i <= 1000000; i++)
            {
                kontrol = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol++;
                        break;
                    }
                }
                if (kontrol == 0)
                {
                    sayac++;
                    txtAsalSayi2.Text += Convert.ToString(i) + "\n";
                }
            }
            Thread.Sleep(0);
        }
    }
}
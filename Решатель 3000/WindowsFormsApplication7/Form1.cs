using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        int a, b, c, max,k1,k2;
        string info;
        double S,p,Hight;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void butDiagnosis_Click(object sender, EventArgs e)
        {
            if ((a + b > c) && (a + c> b)&& (b + c > a) )
                test();
            else
                {
                MessageBox.Show("Треугольника не существует");
                labExist.Visible = false;
                panel1.Visible = false;
                return;
            }
        }
        private void test()
        {
                pictureBox1.Refresh();
                info = "Треугольник существует";
                #region поиск max
                max = (a > b) ? a : b;
                max = (max > c) ? max : c;
                if (a == max)
                {
                    if (c < b)
                    {
                        k1 = c;
                        k2 = b;
                    }
                    else
                    {
                        k1 = b;
                        k2 = c;
                    }
                }
                else if (b == max)
                {
                    if (a < c)
                    {
                        k1 = a;
                        k2 = c;
                    }
                    else
                    {
                        k1 = c;
                        k2 = a;
                    }
                    
                }
                else
                {
                    if (a < b)
                    {
                        k1 = a;
                        k2 = b;
                    }
                    else
                    {
                        k1 = b;
                        k2 = a;
                    }
                    
                }
                #endregion
                if (max * max == k1 * k1 + k2 * k2)
                    info = info + "\n Он прямоугольный ";
                else if (max * max > k1 * k1 + k2 * k2)
                    info = info + "\n Он тупоугольный ";
                else info = info + "\n Он остроугольный ";
                if ((k1 == k2) || (k1 == max) || (k2 == max))
                    info = info + "и равнобедренный";
                else if ((k1 != k2) && (k1 != max) && (k2 != max))
                    info = info + "и разносторонний";
                else if ((k1 == k2) && (k1 == max))
                    info = info + "и равносторонний";

                label4.Text = k1 + " см";
                label5.Text = k2 + " см";
                label6.Text = max + " см";
                
                height();
        }

        private void height()// не нужно но оставь
        {
            p = (double)(max+ k1 + k2) / 2;
            S = Math.Sqrt(p * (p - k1) * (p - k2) * (p - max));
            Hight = 2 * S / max;
            Construction();
        }
        private void Construction()
        {
            panel1.Visible = true;
            labExist.Visible = true;
            

            int intLength = 200;
            double sin = (2 * S) / (max * k1);
            double cos = Math.Cos(Math.Asin(sin));
            double scale = intLength / max;

            Pen MyPen = new Pen(Color.Gold, 4);
            Bitmap btmBack = new Bitmap(250, 280);      //изображение
            Graphics grBack = Graphics.FromImage(btmBack); //лучше объявить заранее глобально.
            pictureBox1.BackgroundImage = btmBack;

            int x1 = 0;
            int y1 = 175;
            int x2 = x1 + intLength;
            int y2 = y1;
            grBack.DrawLine(MyPen, x1, y1, x2, y2);

            x2 = (int)(x1 + (k1 * cos * scale));
            y2 = (int)(y1 - (k1 * sin * scale));
            grBack.DrawLine(MyPen, x1, y1, x2, y2);

            label4.Location = new Point((x2 - x1) / 2, y1-(y1 - y2) / 2);

            x2 = x1 + intLength;
            y2 = y1;
            x1 = (int)(x1 + (k1 * cos * scale));
            y1 = (int)(y1 - (k1 * sin * scale));
            grBack.DrawLine(MyPen, x1, y1, x2, y2);
            label5.Location = new Point(x1 + (x2 - x1) / 2, 175- (y2 - y1) / 2);

            info += "\nПлощадь = " + Math.Round(S, 2)  + "\nПолупериметр = " + Math.Round(p, 2) + "\nВысота = " + Math.Round(Hight, 2);
            labExist.Text = info;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text ="A = "+ trackBar1.Value + " см";
            a = trackBar1.Value;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = "B = " + trackBar2.Value + " см";
            b = trackBar2.Value;
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = "C = " + trackBar3.Value + " см";
            c = trackBar3.Value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "A = " + 1 + " см"; a = 1;
            label2.Text = "B = " + 1 + " см"; b = 1;
            label3.Text = "C = " + 1 + " см"; c = 1;
        }

    }
}

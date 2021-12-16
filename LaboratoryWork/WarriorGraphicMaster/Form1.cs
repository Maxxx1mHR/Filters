﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarriorGraphicMaster
{
    public partial class Form1 : Form
    {
        #region data
        byte[, ,] PicArray = new byte[640, 480, 3];
        byte[, ,] TempArray = new byte[640, 480, 3];
        int[, ,] V = new int[640, 480, 3];
        double[] N = new double[256];
        Color rgb;
        int b;
        int c;

        #endregion

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    rgb = (pictureBox.Image as Bitmap).GetPixel(i, j);
                    PicArray[i, j, 0] = rgb.R;
                    PicArray[i, j, 1] = rgb.G;
                    PicArray[i, j, 2] = rgb.B;
                }
            }

        }



        //Изменение яркости изображения
        private void buttonBright_Click(object sender, EventArgs e)
        {
            b=Convert.ToInt32(numericUpDown1.Value);
            for(int i=0; i<640; i++)
            {
                for(int j=0; j<480;j++)
                {
                    V[i, j, 0] = (int)PicArray[i, j, 0] + b;
                    if (V[i, j, 0] > 255)
                    {
                        V[i, j, 0] = 255;
                    }
                    if (V[i, j, 0] < 0)
                    {
                        V[i, j, 0] = 0;
                    }
                    V[i,j,1]=(int)PicArray[i,j,1]+b;
                    if (V[i, j, 1] > 255)
                    {
                        V[i, j, 1] = 255;
                    }
                    if (V[i, j, 1] < 0)
                    {
                        V[i, j, 1] = 0;
                    }
                    V[i,j,2]=(int)PicArray[i,j,2]+b;
                    if (V[i, j, 2] > 255)
                    {
                        V[i, j, 2] = 255;
                    }
                    if (V[i, j, 2] < 0)
                    {
                        V[i, j, 2] = 0;
                    }
                    (pictureBox.Image as Bitmap).SetPixel(i, j, Color.FromArgb(255, (byte)V[i, j, 0], (byte)V[i, j, 1], (byte)V[i, j, 2]));
                }
            }
            pictureBox.Refresh();
       
        }


        //Реализация фильтра негатив
        private void buttonNegative_Click(object sender, EventArgs e)
        {
            //if (NF == true)
            {
                for (int i = 0; i < 640; i++)
                {
                    for (int j = 0; j < 480; j++)
                    {
                        V[i, j, 0] = (int)(255 - PicArray[i, j, 0]);
                        V[i, j, 1] = (int)(255 - PicArray[i, j, 1]);
                        V[i, j, 2] = (int)(255 - PicArray[i, j, 2]);
                        (pictureBox.Image as Bitmap).SetPixel(i, j, Color.FromArgb(255, (byte)V[i, j, 0], (byte)V[i, j, 1], (byte)V[i, j, 2]));
                    }
                }
                pictureBox.Refresh();
            }
        }


        //Реализация бинарного фильтра
        private void buttonBinColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    if ((int)((PicArray[i, j, 0] + PicArray[i, j, 1] + PicArray[i, j, 2]) / 3) < 38)
                    {
                        (pictureBox.Image as Bitmap).SetPixel(i, j, Color.FromArgb(255, 0, 0, 0));
                    }
                    else
                    {
                        (pictureBox.Image as Bitmap).SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                    }
                }
            }
            pictureBox.Refresh();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        //Частичный срез яркости. 
        private void buttonCutBright_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt32(numericUpDown2.Value);
            if(radioButton1.Checked)
            {
                GetText(radioButton1);
                for (int i = 0; i < 640; i++)
                {
                    for (int j = 0; j < 480; j++)
                    {
                        if ((int)((PicArray[i, j, 0] + PicArray[i, j, 1] + PicArray[i, j, 2]) / 3) > c)
                        {
                            (pictureBox.Image as Bitmap).SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                        }
                    }
                }
                pictureBox.Refresh();
            }
            else
            {
                GetText(radioButton2);
                for (int i = 0; i < 640; i++)
                {
                    for (int j = 0; j < 480; j++)
                    {
                        if ((int)((PicArray[i, j, 0] + PicArray[i, j, 1] + PicArray[i, j, 2]) / 3) < c)
                        {
                            (pictureBox.Image as Bitmap).SetPixel(i, j, Color.FromArgb(255, 0, 0, 0));
                        }
                    }
                }
                pictureBox.Refresh();
            }
           
        }

        //Просто сообщение при срабатывании радио-кнопки. 
        private void GetText(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                MessageBox.Show(rdoButton.Text);
            }
        }


    }
}

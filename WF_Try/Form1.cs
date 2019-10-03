using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Bitmap myB, myBack;
        protected float[,] kernel = null;

        //------------------------------openFileDialog------------------------------
        public OpenFileDialog Open()
        {
            ofd.Filter = "Image Files (*.JPG)|*.JPG;|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch // error
                {
                    MessageBox.Show("It is impossible to open file", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            return ofd;
        }

        //------------------------------uploadPicture-------------------------------
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ofd = Open();
            if (pictureBox1.Image != null)
            {
                myB = new Bitmap(ofd.FileName);
                myBack = new Bitmap(ofd.FileName);
            }
        }
        //------------------------------returnBack----------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                myB = new Bitmap(myBack);
                pictureBox1.Image = myB;
            }
            else
                MessageBox.Show("Please upload some picture!", "EMPTY");
        }
        //------------------------------InvertPicture-------------------------------
        private void changeColor_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                for (int x = 0; x < myB.Width; x++)
                {
                    for (int y = 0; y < myB.Height; y++)
                    {
                        Color oldColor = myB.GetPixel(x, y);
                        Color newColor;
                        newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R,
                            255 - oldColor.G, 255 - oldColor.B);
                        myB.SetPixel(x, y, newColor);
                        pictureBox1.Image = myB;
                    }
                    Application.DoEvents();
                }
            }
        }
        //------------------------------intoGray------------------------------------
        private void Gray_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                for (int x = 0; x < myB.Width; x++)
                {
                    for (int y = 0; y < myB.Height; y++)
                    {
                        int R, G, B;
                        Color oldColor = myB.GetPixel(x, y);
                        Color newColor;
                        R = G = B = (oldColor.R + oldColor.G + oldColor.B) / 3;
                        newColor = Color.FromArgb(oldColor.A, R, G, B);
                        myB.SetPixel(x, y, newColor);
                        pictureBox1.Image = myB; //
                    }
                    Application.DoEvents();
                }
            }
        }
        //------------------------------intoBlackAndWhite---------------------------
        private void BlackWhite_Click(object sender, EventArgs e) //
        {
            if (pictureBox1.Image != null)
            {
                for (int x = 0; x < myB.Width; x++)
                {
                    for (int y = 0; y < myB.Height; y++)
                    {
                        int R, G, B;
                        Color oldColor = myB.GetPixel(x, y);
                        Color newColor;

                        if ((oldColor.R + oldColor.G + oldColor.B) / 3 <= 120)
                            R = G = B = 0;
                        else
                            R = G = B = 255;

                        newColor = Color.FromArgb(oldColor.A, R, G, B);
                        myB.SetPixel(x, y, newColor);
                        pictureBox1.Image = myB;
                    }
                    Application.DoEvents();
                }
            }
        }
        //------------------------------save----------------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.OverwritePrompt = true; // проверка на существование файла с таким именем
                sfd.Filter = "Image Files (*.JPG)|*.JPG;|All Files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("It is impossible to open file", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }
        //------------------------------inRed---------------------------------------
        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                for (int x = 0; x < myB.Width; x++)
                {
                    for (int y = 0; y < myB.Height; y++)
                    {
                        Color oldColor = myB.GetPixel(x, y);
                        Color newColor;
                        newColor = Color.FromArgb(oldColor.A, oldColor.R, 0, 0);
                        myB.SetPixel(x, y, newColor);
                        pictureBoxRed.Image = myB;
                    }
                    Application.DoEvents();
                }

                myB = new Bitmap(myBack);
            }
        }
        //------------------------------inGreen-------------------------------------
        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                for (int x = 0; x < myB.Width; x++)
                {
                    for (int y = 0; y < myB.Height; y++)
                    {
                        Color oldColor = myB.GetPixel(x, y);
                        Color newColor;
                        newColor = Color.FromArgb(oldColor.A, 0, oldColor.G, 0);
                        myB.SetPixel(x, y, newColor);
                        pictureBoxGreen.Image = myB;
                    }
                    Application.DoEvents();
                }

                myB = new Bitmap(myBack);
            }
        }
        //------------------------------inBlue--------------------------------------
        private void pictureBoxBlue_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                for (int x = 0; x < myB.Width; x++)
                {
                    for (int y = 0; y < myB.Height; y++)
                    {
                        Color oldColor = myB.GetPixel(x, y);
                        Color newColor;
                        newColor = Color.FromArgb(oldColor.A, 0, 0, oldColor.B);
                        myB.SetPixel(x, y, newColor);
                        pictureBoxBlue.Image = myB;
                    }
                    Application.DoEvents();
                }

                myB = new Bitmap(myBack);
            }
        }
        //------------------------------mainForm------------------------------------
        private void Form1_Load(object sender, EventArgs e) { }
        //------------------------------MedianFilter--------------------------------
        private void MedianFilter_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int rad = 1; // it can be change
                int k;
                for (int x = rad * 2; x < myB.Width - rad * 2 - 1; x++)
                {
                    for (int y = rad * 2; y < myB.Height - rad * 2 - 1; y++)
                    {
                        int n;
                        int medianR, medianB, medianG;     // искомые медианные значения
                        k = 0;             // counter

                        n = (2 * rad + 1) * (2 * rad + 1);  // rad - радиус "воздействия" медианного фильтра

                        int[] cR = new int[n];
                        int[] cB = new int[n];
                        int[] cG = new int[n];

                        for (int i = x - rad; i < x + rad + 1; i++)
                        {
                            for (int j = y - rad; j < y + rad + 1; j++)
                            {
                                System.Drawing.Color color = myB.GetPixel(i, j);
                                cR[k] = Convert.ToInt32(color.R);
                                cG[k] = Convert.ToInt32(color.G);
                                cB[k] = Convert.ToInt32(color.B);
                                k++;
                            }
                        }

                        Array.Sort(cR); Array.Sort(cG); Array.Sort(cB);
                        int n_ = (int)(n / 2);
                        medianR = cR[n_]; medianG = cG[n_]; medianB = cB[n_];

                        myB.SetPixel(x, y, System.Drawing.Color.FromArgb(medianR, medianG, medianB));
                    }
                }
                pictureBox1.Image = myB;
            }
            MessageBox.Show("All");
        }
        //------------------------------makeNoise-----------------------------------
        private void Noise_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Random rnd = new Random();
                for (int a = 0; a < myB.Width; a++)
                {
                    for (int p = 0; p < myB.Height; p++)
                    {
                        Color color = myB.GetPixel(a, p);
                        byte r = (byte)((rnd.Next(0, 2) == 1) ? color.R : ((rnd.Next(0, 2) == 1) ? 0 : 255));
                        byte b = (byte)((rnd.Next(0, 2) == 1) ? color.B : ((rnd.Next(0, 2) == 1) ? 0 : 255));
                        byte g = (byte)((rnd.Next(0, 2) == 1) ? color.G : ((rnd.Next(0, 2) == 1) ? 0 : 255));

                        myB.SetPixel(a, p, Color.FromArgb(255, r, g, b));
                        pictureBox1.Image = myB;
                    }
                    Application.DoEvents();
                }
            }
        }
        
        //------------------------------mainPictureWithoutRed-----------------------
        private void buttonNoRed_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                for (int x = 0; x < myB.Width; x++)
                {
                    for (int y = 0; y < myB.Height; y++)
                    {
                        Color oldColor = myB.GetPixel(x, y);
                        Color newColor;
                        newColor = Color.FromArgb(oldColor.A, 0, oldColor.G, oldColor.B);
                        myB.SetPixel(x, y, newColor);
                        pictureBoxRed.Image = myB;
                    }
                    Application.DoEvents();
                }
                //myB = new Bitmap(myBack);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //myB = 
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        //------------------------------Glass---------------------------------------
        private void GaussFilter_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //float[,] kernel = null;
                //CreateGKernel(7, 2);

                int rad = 2;
                float sig = 2; int k;
                float sumR, sumG, sumB;

                int size = 2 * rad + 1;
                kernel = new float[size, size];
                float norm = 0;

                if (true)
                {
                    for (int i = 0; i < 2 * rad + 1; i++)
                        for (int j = 0; j < 2 * rad + 1; j++)
                        {
                            kernel[i, j] = (float)(Math.Exp(-(i * i + j * j) / (sig * sig)));

                            norm += kernel[i, j];
                        }

                    for (int i = 0; i < size; i++)
                        for (int j = 0; j < size; j++)
                            kernel[i, j] /= norm;
                }

                int cR, cB, cG; int rx = rad, ry;

                for (int x = rad; x < myB.Width - rad - 2; x++){
                    for (int y = rad; y < myB.Height - rad - 2; y++){
                        //if (false) {
                        //    kernel[0, 0] = 0.025F; kernel[0, 4] = 0.025F;
                        //    kernel[4, 0] = 0.025F; kernel[4, 4] = 0.025F;
                        //    kernel[0, 1] = 0F; kernel[1, 0] = 0F; kernel[1, 1] = 0F;
                        //    kernel[0, 3] = 0F; kernel[1, 3] = 0F; kernel[1, 4] = 0F;
                        //    kernel[3, 0] = 0F; kernel[3, 1] = 0F; kernel[4, 1] = 0F;
                        //    kernel[3, 3] = 0F; kernel[4, 3] = 0F; kernel[3, 4] = 0F;
                        //    kernel[2, 0] = 0.05F; kernel[2, 2] = 0.05F;
                        //    kernel[2, 3] = 0.05F; kernel[2, 4] = 0.05F;
                        //    kernel[0, 2] = 0.05F; kernel[1, 2] = 0.05F;
                        //    kernel[3, 2] = 0.05F; kernel[4, 2] = 0.05F;
                        //    kernel[3, 3] = 0.05F;
                        //}

                        sumR = 0; sumG = 0; sumB = 0;

                        rx = rad;
                        for (int i = 0; i < 2 * rad + 1; i++){
                            ry = rad;
                            for (int j = 0; j < 2 * rad + 1; j++) { 
                                System.Drawing.Color color = myB.GetPixel(x - rx, y - ry);

                                cR = Convert.ToInt32(color.R);
                                cG = Convert.ToInt32(color.G);
                                cB = Convert.ToInt32(color.B);

                                sumR += kernel[i, j] * (float)cR;
                                sumG += kernel[i, j] * (float)cG;
                                sumB += kernel[i, j] * (float)cB;
                                ry--;
                            }
                            rx--;
                        }

                        Color newColor;
                        newColor = Color.FromArgb(255, (int)sumR, (int)sumG, (int)sumB);
                        myB.SetPixel(x, y, newColor);
                        pictureBox1.Image = myB;
                    }

                }
            }
        }

        private void Blur_Click(object sender, EventArgs e)
        {

        }
    }
}


//namespace Sav
//{
//    abstract class Filtres
//    {

//    }
//}




//------------------------------createGKernel--------------------------------
//public void CreateGKernel(int rad, float sig)
//{
//    int size = 2 * rad + 1;
//    kernel = new float[size, size];
//    float norm = 0;

//    for (int i = -rad; i <= rad; i++)
//        for (int j = -rad; j <= rad; j++)
//        {
//            kernel[i + rad, j + rad] = (float)(Math.Exp(-(i * i + j * j) / (sig * sig)));
//            norm += kernel[i + rad, j + rad];
//        }

//    for (int i = 0; i < size; i++)
//        for (int j = 0; j < size; j++)
//            kernel[i, j] /= norm;
//}
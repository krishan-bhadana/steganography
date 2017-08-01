using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonbrowsefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter="Image Files (*.png,*.jpg)|*.png; *.jpg";
            openDialog.InitialDirectory = @"C:\Users\bhada\Desktop";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxfilepath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxfilepath.Text;
            }
        }

        private void buttonencode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxfilepath.Text);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < textBoxmessage.TextLength)
                    {
                        char letter = Convert.ToChar(textBoxmessage.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter); 
                        img.SetPixel(i,j,Color.FromArgb(pixel.R,pixel.G,value));
                    }
                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBoxmessage.TextLength));
                    }
                }
              
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.png,*.jpg)|*.png,*.jpg";
            saveFile.InitialDirectory = @"C:\Users\bhada\Desktop";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBoxfilepath.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = textBoxfilepath.Text;
                img.Save(textBoxfilepath.Text);
            }
        }

        private void buttondecode_Click(object sender, EventArgs e)
        {

            Bitmap img = new Bitmap(textBoxfilepath.Text);
            string message = "";
            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msglength = lastpixel.B;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < msglength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                        message = message + letter;
                    }
                }

            }
            textBoxmessage.Text = message;
        } 
    }
}

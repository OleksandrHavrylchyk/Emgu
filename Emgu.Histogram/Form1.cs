using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace Emgu.Histogram
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> image;
        private Image<Gray, byte> redChannel;
        private Image<Gray, byte> greenChannel;
        private Image<Gray, byte> blueChannel;
        public Form1()
        {
            InitializeComponent();
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                imageBox1.Image = redChannel;

                histogramBox1.ClearHistogram();

                histogramBox1.GenerateHistograms(redChannel, 256);

                histogramBox1.Refresh();
            }
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                image = new Image<Bgr, byte>(openFile.FileName);

                blueChannel = image[0];
                greenChannel = image[1];
                redChannel = image[2];

                imageBox1.Image = new Image<Gray, byte>(image.ToBitmap());
            }
        }

        private void blueChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                imageBox1.Image = blueChannel;

                histogramBox1.ClearHistogram();

                histogramBox1.GenerateHistograms(blueChannel, 256);

                histogramBox1.Refresh();
            }
        }

        private void greenChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                imageBox1.Image = greenChannel;

                histogramBox1.ClearHistogram();

                histogramBox1.GenerateHistograms(greenChannel, 256);

                histogramBox1.Refresh();
            }
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                var grayImage = new Image<Gray, byte>(image.ToBitmap());
                imageBox1.Image = grayImage;

                histogramBox1.ClearHistogram();

                histogramBox1.GenerateHistograms(grayImage, 256);

                histogramBox1.Refresh();
            }
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                var img = new Image<Gray, byte>(image.ToBitmap());
                var equalized = new Image<Gray, byte>(image.ToBitmap());

                CvInvoke.cvEqualizeHist(img.Ptr, equalized.Ptr);

                imageBox2.Image = equalized;


                histogramBox2.ClearHistogram();

                histogramBox2.GenerateHistograms(equalized, 256);

                histogramBox2.Refresh();
            }
        }

        private void normalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                image._EqualizeHist();
                imageBox3.Image = new Image<Gray, byte>(image.ToBitmap());

                histogramBox3.ClearHistogram();

                histogramBox3.GenerateHistograms(new Image<Gray, byte>(image.ToBitmap()), 256);

                histogramBox3.Refresh();
            }
        }
    }
}
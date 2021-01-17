using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Emgu.ObjectRecognition
{
    public partial class Form1 : Form
    {
        private Mat image;
        private const int minRectDim = 5;
        private const int maxRectDim = 45;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                image = new Mat(openFile.FileName);

                pictureBox1.Image = image.ToBitmap();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < image.Rows; y++)
            {
                for (int x = 0; x < image.Cols; x++)
                {
                    var value = image.At<byte>(x, y); 
                    if (value == 255)
                    {
                        Rect rectangle = new Rect();

                        Cv2.FloodFill(image, new OpenCvSharp.Point(x, y), new Scalar(200), out rectangle, null, null, FloodFillFlags.Link8);

                        if (rectangle.Width >= minRectDim && rectangle.Width <= maxRectDim
                                && rectangle.Height >= minRectDim && rectangle.Height <= maxRectDim)

                        {
                            var xCenter = rectangle.X + rectangle.Width / 2;
                            var yCenter = rectangle.Y + rectangle.Height / 2;
                            var radius = (rectangle.Width + rectangle.Height) / 4;

                            Cv2.Circle(image, xCenter, yCenter, radius, new Scalar(255, 0, 100));
                        }
                    }
                }
            }

            pictureBox1.Image = image.ToBitmap();
        }
    }
}
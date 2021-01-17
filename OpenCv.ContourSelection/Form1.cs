using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Windows.Forms;

namespace OpenCv.ContourSelection
{
    public partial class Form1 : Form
    {
        private Mat image;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                image = new Mat(openFile.FileName);

                pictureBoxIpl1.Image = image.ToBitmap();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var output = image;
            Cv2.Sobel(image, output, MatType.CV_16SC1, 1, 1);

            //Cv2.CvtColor(image, output, ColorConversionCodes.GRAY2BGR);
            Mat edges = new Mat();
            Cv2.Canny(output, edges, 1, 1);

            Cv2.FindContours(image, out _, edges, RetrievalModes.CComp, ContourApproximationModes.ApproxSimple);

            pictureBoxIpl1.Image = image.ToBitmap();
        }
    }
}
# №7 Acquaintance with the library
Purpose: To get acquainted with the OpenCV library. Learn how to upload images using OpenCV.

To study OpenCV I found Emgu - wrapper that allows to work with OpenCV using .NET and C#, so I desided to use it.

Emgu.Acquaintance - project in which I installed and created simple picture loading with preview.
For setting up Emgu for project I used official  [documentation][doc]

There I also found simple example with picture loading

            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> myImage = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = myImage.ToBitmap();
            }
            
[image]

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax) 
            
[image](./pictures/1.jpg)
[doc]: <http://www.emgu.com/wiki/index.php/Setting_up_EMGU_C_Sharp>
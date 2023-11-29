using ImageApp.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImageProcessor processor = new ImageProcessor();

            Image image1 = new Image("Image1", 200, 150, 2);
            Image image2 = new Image("Image2", 300, 200, 3, new Color(255, 255, 255));
            Image image3 = new Image("Image3", 400, 250, 1, new Color(0, 0, 255));

            processor.AddImage(image1);
            processor.AddImage(image2);

            processor.RemoveImage(image3);

            processor.Rotate(180, image1);
            processor.ZoomIn(4, image2);

            processor.ProcessImages();


            Console.ReadKey();
        }
    }
}

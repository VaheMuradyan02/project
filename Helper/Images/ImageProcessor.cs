using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Helper.Images
{
    internal class ImageProcessor : IFunctions<Image>
    {
        private readonly List<Image> _images = new List<Image>();

        public void AddImage(Image image)
        {
            _images.Add(image);
        }

        public void RemoveImage(Image image)
        {
            _images.Remove(image);
        }

        public void ProcessImages()
        {
            foreach (var image in _images)
            {
                image.DisplayInfo();
            }
        }

        public void Resize(int width, int height, Image name)
        {
            Console.WriteLine($"Image of Size: {width}x{height}");
        }

        public void Rotate(int degree, Image name)
        {
            Console.WriteLine($"Image of move : {degree}");
        }

        public void ZoomIn(int scale, Image name)
        {
            Console.WriteLine($"Image of zoom in : {scale}");
        }

        public void ZoomOut(int scale, Image name)
        {
            Console.WriteLine($"Image of zoom out: {scale}");
        }

        public void Move(int right, int left, int top, int down, Image name)
        {
            Console.WriteLine($"Image of move : {right},{left},{top},{down}");
        }
    }
}

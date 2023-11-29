using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Helper;

namespace Helper.Image
{

    public enum FileType
    {   
        Jpeg,
        Jpg,
        Png,
        Svg
    }

    public class Image
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color ImageColor { get; set; }
        public  FileType Type { get; set; }

        public Image(string name, int width, int height, int type)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
            this.Type = (FileType)type;
        }

        public Image(string name, int width, int height, int type, Color imageColor)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
            this.Type = (FileType)type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Image: {Name}, Size: {Width}x{Height}");
        }
    }
}

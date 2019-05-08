using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    public delegate void CropHandler();

    class Program
    {
        static void Main(string[] args)
        {
            GhImage im1 = new GhImage();
            im1.Height = 50;
            im1.Width = 100;
            Console.WriteLine(im1.GetPixels());

            im1.CropEvent += new CropHandler(im1.PerformCrop);
            //im1.CropEvent -= new CropHandler(im1.Crop);
            im1.PerformCrop();

            Console.WriteLine(im1.GetPixels());

            Console.ReadLine();
        }
    }

    public class GhImage
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int GetPixels()
        {
            return Height * Width;
        }

        public void PerformCrop()
        {
            if (CropEvent != null)
            {
                Height -= 10;
                Width -= 10;
            }
        }
        public event CropHandler CropEvent;
    }
}

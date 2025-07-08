using Aspose.Imaging;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Svg;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
    internal class CommonGraphicsEngineForSvgEmfWmf
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_PNG();

            Console.WriteLine("Running example CommonGraphicsEngineForSvgEmfWmf");

            var filePath = Path.Combine(dataDir, "test.svg");
            
            using (var vectorImage = (VectorImage)new SvgImage(100, 100))
            {
                var g = new Graphics(vectorImage);
                g.FillRectangle(new SolidBrush(Color.LightYellow), 10, 10, 80, 80);
                g.DrawRectangle(new Pen(Color.Red, 4), 10, 10, 80, 80);
                g.FillEllipse(new SolidBrush(Color.LightGreen), 20, 20, 60, 60);
                g.DrawEllipse(new Pen(Color.Green, 2), 20, 20, 60, 60);
                g.FillPie(new SolidBrush(Color.LightBlue), new Rectangle(30, 30, 40, 40), 0, 45);
                g.DrawPie(new Pen(Color.Blue, 1), new Rectangle(30, 30, 40, 40), 0, 45);
                g.DrawLine(new Pen(Color.DarkRed, 1), 10, 20, 90, 20);
                g.DrawLines(new Pen(Color.DarkRed, 1), new PointF[] { new PointF(10, 90), new PointF(20, 80), new PointF(30, 90) });
                g.DrawPolygon(new Pen(Color.DarkRed, 1), new PointF[] { new PointF(90, 90), new PointF(80, 80), new PointF(70, 90) });
                g.DrawString("Hello World!", new Font("Arial", 14), new SolidBrush(Color.DarkBlue), new PointF(10, 50));
                g.DrawArc(new Pen(Color.Brown, 1), new Rectangle(30, 30, 40, 40), 135, -90);
                vectorImage.Save(filePath);
            }

            File.Delete(filePath);

            Console.WriteLine("Finished example CommonGraphicsEngineForSvgEmfWmf");
        }
    }
}

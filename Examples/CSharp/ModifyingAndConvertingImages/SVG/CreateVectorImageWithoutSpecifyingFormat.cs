using Aspose.Imaging;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
    internal class CreateVectorImageWithoutSpecifyingFormat
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_SVG();

            Console.WriteLine("Running example CreateVectorImageWithoutSpecifyingFormat");

            using (VectorImage image = VectorImage.Create(500, 500, GraphicsUnit.Pixel))
            {
                Graphics deviceContext = new Graphics(image);
                deviceContext.PageUnit = GraphicsUnit.Pixel;

                var brush = new SolidBrush(Color.Yellow);
                var pen = new Pen(Color.Blue);

                deviceContext.FillPie(brush, new RectangleF(10, 10, 80, 80), -270, 270);
                deviceContext.DrawPie(pen, new RectangleF(10, 10, 80, 80), -270, 270);

                deviceContext.DrawArc(pen, new RectangleF(100, 10, 80, 80), 180, 90);

                deviceContext.FillEllipse(brush, new RectangleF(200, 10, 80, 80));
                deviceContext.DrawEllipse(pen, new RectangleF(200, 10, 80, 80));
                deviceContext.FillRectangle(brush, new RectangleF(300, 10, 80, 80));
                deviceContext.FillRectangle(brush, new RectangleF(400, 10, 80, 80));

                deviceContext.DrawString("Hello World!", new Font("Arial", 16, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(10, 110));
                image.Save(dataDir + "output.svg", new SvgOptions() { VectorRasterizationOptions = new VectorRasterizationOptions() { BackgroundColor = Color.Empty } });                
            }

            File.Delete(dataDir + "output.svg");            

            Console.WriteLine("Finished example CreateVectorImageWithoutSpecifyingFormat");
        }
    }
}

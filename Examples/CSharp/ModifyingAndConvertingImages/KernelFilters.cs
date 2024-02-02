using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.ImageFilters.ComplexUtils;
using Aspose.Imaging.ImageFilters.Convolution;
using Aspose.Imaging.ImageFilters.FilterOptions;
using System.IO;

namespace CSharp.ModifyingAndConvertingImages
{
    internal class KernelFilters
    {
        public static void Run()
        {
            Console.WriteLine("Running example KernelFilters");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();            

            const int Size = 5;
            const double Sigma = 1.5, Angle = 45;

            double[,] customKernel = GetRandomKernel(Size, 7, new Random());
            Complex[,] customComplex = ConvolutionFilter.ToComplex(customKernel);
            var kernelFilters = new FilterOptionsBase[]
            {
    // convolution filters
    new ConvolutionFilterOptions(ConvolutionFilter.Emboss3x3),
    new ConvolutionFilterOptions(ConvolutionFilter.Emboss5x5),
    new ConvolutionFilterOptions(ConvolutionFilter.Sharpen3x3),
    new ConvolutionFilterOptions(ConvolutionFilter.GetBlurBox(Size)),
    new ConvolutionFilterOptions(ConvolutionFilter.GetGaussian(Size, Sigma)),
    new ConvolutionFilterOptions(customKernel),
    new GaussianBlurFilterOptions(Size, Sigma),
    new SharpenFilterOptions(Size, Sigma),
    new MedianFilterOptions(Size),
    // deconvolution filters
    new DeconvolutionFilterOptions(ConvolutionFilter.GetGaussian(Size, Sigma)),
    new DeconvolutionFilterOptions(customKernel),
    new DeconvolutionFilterOptions(customComplex),
    new GaussWienerFilterOptions(Size, Sigma),
    new MotionWienerFilterOptions(Size, Sigma, Angle),
            };

            //var templatesFolder = @"c:\Users\USER\Downloads\templates\";
            //var dataDir = templatesFolder;
            var inputPaths = new[]
            {
    Path.Combine(dataDir, "template.png"),    
};

            var outputs = new List<string>();
            foreach (var inputPath in inputPaths)
            {
                for (int i = 0; i < kernelFilters.Length; i++)
                {
                    var options = kernelFilters[i];
                    using (var image = Image.Load(inputPath))
                    {
                        var outputPath = $"{inputPath}-{i}.png";

                        if (image is RasterImage raster)
                        {
                            Filter(raster, options, outputPath);
                        }
                        else if (image is VectorImage vector)
                        {
                            var vectorAsPng = inputPath + ".png";
                            if (!File.Exists(vectorAsPng))
                            {
                                vector.Save(vectorAsPng);
                                outputs.Add(vectorAsPng);
                            }

                            using (var png = Image.Load(vectorAsPng))
                            {
                                Filter(png as RasterImage, options, outputPath);
                            }
                        }
                    }
                }
            }

            outputs.ForEach(p => File.Delete(p));

            Console.WriteLine("Finished example KernelFilters");
        }

        static void Filter(RasterImage raster, FilterOptionsBase options, string outputPath)
        {
            raster.Filter(raster.Bounds, options);
            raster.Save(outputPath);
        }

        static double[,] GetRandomKernel(int cols, int rows, Random random)
        {
            double[,] customKernel = new double[cols, rows];
            for (int y = 0; y < customKernel.GetLength(0); y++)
            {
                for (int x = 0; x < customKernel.GetLength(1); x++)
                {
                    customKernel[y, x] = random.NextDouble();
                }
            }
            return customKernel;
        }
    }
}

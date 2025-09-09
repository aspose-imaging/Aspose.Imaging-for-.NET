using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages
{
    internal class SupportOfDigitalSignature
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_PNG();

            Console.WriteLine("Running example SupportOfDigitalSignature");

            //# Signing limitations:
            //#  - The LSB steganography algorithm requires the image to be at least 8 pixels in width and height, with a minimum of 16,384 total pixels.
            //#  - Password must be at least 4 characters long.

            //            var password = "1234";
            //            var filePath = "c:\sunflower.jpg";

            //#################################### Example 1 ###############################
            //# Faster checking method with partial data extraction.                     #
            //# Set detectionThreasholdPercentage value to 75% (default value).          #
            //##############################################################################

            string filePath = Path.Combine(dataDir, @"00020.png");
            string password = "123456";
            using (var image = (RasterImage)Image.Load(filePath))
            {
                image.EmbedDigitalSignature(password);

                var isSigning = image.IsDigitalSigned(password);
                Console.WriteLine($"Check signing result of file is: {isSigning}");
            }


            Console.WriteLine("Finished example SupportOfDigitalSignature");
        }
    }
}

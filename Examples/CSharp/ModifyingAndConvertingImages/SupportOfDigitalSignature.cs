// GIST-ID: c26a5135de64f09911ec344b49f5d338
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
            
            string filePath = Path.Combine(dataDir, @"00020.png");
            string password = "123456";

            var image = (RasterImage)Aspose.Imaging.Image.Load(filePath);

            // ################## //
            //   EMBEDDING SIGN   //
            // ################## //
            
            // Embed LSB-based data to process signing image
            //
            // Signing limitations:
            //  - The LSB steganography algorithm requires the image to be at least 8
            //        pixels in width and height, with a minimum of 16,384 total pixels.
            //  - The password must be at least 4 characters long.

            EmbedSigning(image, password);
            
            
            // ################## //
            //    VALIDATION      //
            // ################## //
            
            // Validate the embedded digital signature using the provided password.
            // If an incorrect password is supplied, the verification will return false.
            // Only the password owner can successfully verify the image signature.
            
            var isSigning = IsDigitalSigned(image, password);
            Console.WriteLine($"Check signing result of file is: {isSigning}");

            // ################## //
            //  PRECISE CHECKING  //
            // ################## //

            var signingPercentage = AnalyzePercentageDigitalSignature(image, password);
            Console.WriteLine($" Image signing probability percentage is: {signPercentage}")
            
            image.Dispose();

            Console.WriteLine("Finished example SupportOfDigitalSignature");
        }

        /// <summary>
        /// Embeds a digital signature into the specified image using an LSB-based technique.
        /// </summary>
        /// <param name="image">The target <see cref="RasterImage"/> to embed the signature into.</param>
        /// <param name="password">The password used to generate and embed the digital signature.</param>
        public static void EmbedSigning(RasterImage image, string password)
        {
            image.EmbedDigitalSignature(password);
        }

        /// <summary>
        /// Determines whether the specified <see cref="RasterImage"/> contains
        /// a valid embedded digital signature using an LSB-based verification algorithm.
        /// </summary>
        /// <param name="image"> /// The target image to verify. </param>
        /// <param name="password"> /// The password used to validate the embedded digital signature. </param>
        /// <param name="threshold">
        /// The verification confidence threshold (in percent).
        /// Default value is <c>75</c>. Higher values require stricter matching.
        /// </param>
        /// <returns>
        /// <c>true</c> if a valid digital signature is detected and matches
        /// the specified threshold; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks> Faster checking method with partial data extraction. </remarks>
        public static bool IsDigitalSigned(RasterImage image, string password, int threshold = 75)
        {
            return image.IsDigitalSigned(password, threshold);
        }

        /// <summary>
        /// Analyzes the specified <see cref="RasterImage"/> and calculates
        /// the percentage of detected digital signature data embedded
        /// using the LSB-based steganography algorithm.
        /// </summary>
        /// <param name="image"> /// The target image to analyze. /// </param>
        /// <param name="password">The password used to validate and extract the embedded digital signature. </param>
        /// <returns>
        /// An integer value (0–100) representing the percentage of signature consistency detected in the image.
        /// Higher values indicate a stronger match.
        /// </returns>
        public static int AnalyzePercentageDigitalSignature(RasterImage image, string password)
        {
            return image.AnalyzePercentageDigitalSignature(password);
        }
    }
}
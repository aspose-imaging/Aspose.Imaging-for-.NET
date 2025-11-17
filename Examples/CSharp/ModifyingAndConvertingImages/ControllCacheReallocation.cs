// GIST-ID: 3974090787bf21a289ea25a009a2f326
using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ControllCacheReallocation
    {
        public static void Run()
        {
            Console.WriteLine("Running example ControllCacheReallocation");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Cache();

            // By default the cache folder is set to the local temp directory. You can specify a different cache folder from the default this way:
            Cache.CacheFolder = dataDir;

            // Auto mode is flexible and efficient
            Cache.CacheType = CacheType.Auto;

            // The default cache max value is 0, which means that there is no upper limit
            Cache.MaxDiskSpaceForCache = 1073741824; // 1 gigabyte
            Cache.MaxMemoryForCache = 1073741824; // 1 gigabyte

            // We do not recommend that you change the following property because it may greatly affect performance
            Cache.ExactReallocateOnly = false;

            // At any time you can check how many bytes are currently allocated for the cache in memory or on disk by examining the following properties:
            long l1 = Cache.AllocatedDiskBytesCount;
            long l2 = Cache.AllocatedMemoryBytesCount;
            GifOptions options = new GifOptions();
            options.Palette = new ColorPalette(new[] { Color.Red, Color.Blue, Color.Black, Color.White });
            options.Source = new StreamSource(new MemoryStream(), true);
            using (RasterImage image = (RasterImage)Image.Create(options, 100, 100))
            {
                Color[] pixels = new Color[10000];
                for (int i = 0; i < pixels.Length; i++)
                {
                    pixels[i] = Color.White;
                }

                image.SavePixels(image.Bounds, pixels);

                // After executing the code above 40000 bytes are allocated to memory.
                long diskBytes = Cache.AllocatedDiskBytesCount;
                long memoryBytes = Cache.AllocatedMemoryBytesCount;
            }

            // The allocation properties may be used to check whether all Aspose.Imaging objects were properly disposed. 
            // If you've forgotten to call Dispose on an object, the cache values will not be 0.
            l1 = Cache.AllocatedDiskBytesCount;
            l2 = Cache.AllocatedMemoryBytesCount;

            Console.WriteLine("Finished example ControllCacheReallocation");
        }
    }
}
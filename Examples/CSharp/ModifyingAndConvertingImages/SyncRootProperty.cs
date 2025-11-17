// GIST-ID: 73e5438d32fc70cc636540f0ba50fb60
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class SyncRootProperty
    {
        public static void Run()
        {
            // To get proper output, please apply a valid Aspose.Imaging license.
            // You can purchase a full license or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.

            // ExStart: SyncRootProperty

            // Create an instance of the MemoryStream class.
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                // Create an instance of the StreamContainer class and assign the memory stream object.
                using (StreamContainer streamContainer = new StreamContainer(memoryStream))
                {
                    // Check if the access to the stream source is synchronized.
                    lock (streamContainer.SyncRoot)
                    {
                        // Do work.
                        // Now access to the source MemoryStream is synchronized.
                    }
                }
            }

            // ExEnd: SyncRootProperty
        }
    }
}
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
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx."

            // ExStart: SyncRootProperty

            // Create an instance of Memory stream class.
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                // Create an instance of Stream container class and assign memory stream object.
                using (StreamContainer streamContainer = new StreamContainer(memoryStream))
                {
                    // check if the access to the stream source is synchronized.
                    lock (streamContainer.SyncRoot)
                    {
                        // do work
                        // now access to source MemoryStream is synchronized
                    }
                }
            }

            // ExEnd: SyncRootProperty
        }
    }
}

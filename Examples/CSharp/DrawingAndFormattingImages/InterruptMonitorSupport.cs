using Aspose.Imaging;
using Aspose.Imaging.CoreExceptions;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Multithreading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharp.DrawingAndFormattingImages
{
    public class InterruptMonitorSupport
    {
        public static void Run()
        {
            //ExStart:InterruptMonitorSupport
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();
            ImageOptionsBase saveOptions = new PngOptions();
            InterruptMonitor monitor = new InterruptMonitor();
            SaveImageWorker worker = new SaveImageWorker(dataDir + "big.jpg", dataDir + "big_out.png", saveOptions, monitor);

            Thread thread = new Thread(new ThreadStart(worker.ThreadProc));

            try
            {
                thread.Start();

                // The timeout should be less than the time required for full image conversion (without interruption).
                Thread.Sleep(3000);

                // Interrupt the process
                monitor.Interrupt();
                Console.WriteLine("Interrupting the save thread #{0} at {1}", thread.ManagedThreadId, System.DateTime.Now);

                // Wait for interruption...
                thread.Join();
            }
            finally
            {
                // If the file to be deleted does not exist, no exception is thrown.
                File.Delete(dataDir + "big_out.png");
            }
        }

        /// <summary>
        /// Initiates image conversion and waits for its interruption.
        /// </summary>
        private class SaveImageWorker
        {
            /// <summary>
            /// The path to the input image.
            /// </summary>
            private readonly string inputPath;

            /// <summary>
            /// The path to the output image.
            /// </summary>
            private readonly string outputPath;

            /// <summary>
            /// The interrupt monitor.
            /// </summary>
            private readonly InterruptMonitor monitor;

            /// <summary>
            /// The save options.
            /// </summary>
            private readonly ImageOptionsBase saveOptions;

            /// <summary>
            /// Initializes a new instance of the <see cref="SaveImageWorker" /> class.
            /// </summary>
            /// <param name="inputPath">The path to the input image.</param>
            /// <param name="outputPath">The path to the output image.</param>
            /// <param name="saveOptions">The save options.</param>
            /// <param name="monitor">The interrupt monitor.</param>
            public SaveImageWorker(string inputPath, string outputPath, ImageOptionsBase saveOptions, InterruptMonitor monitor)
            {
                this.inputPath = inputPath;
                this.outputPath = outputPath;
                this.saveOptions = saveOptions;
                this.monitor = monitor;
            }

            /// <summary>
            /// Tries to convert image from one format to another. Handles interruption.
            /// </summary>
            public void ThreadProc()
            {
                using (Image image = Image.Load(this.inputPath))
                {
                    InterruptMonitor.ThreadLocalInstance = this.monitor;

                    try
                    {
                        image.Save(this.outputPath, this.saveOptions);
                    }
                    catch (OperationInterruptedException e)
                    {
                        Console.WriteLine("The save thread #{0} finishes at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now);
                        Console.WriteLine(e);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    finally
                    {
                        InterruptMonitor.ThreadLocalInstance = null;
                    }
                }
            }

            //ExEnd:InterruptMonitorSupport
        }
    }
}
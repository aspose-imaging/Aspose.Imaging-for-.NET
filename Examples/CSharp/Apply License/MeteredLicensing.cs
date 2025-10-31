using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.CAD.Examples.CSharp.ApplyLicense
{
    class MeteredLicensing
    {
        public static void Run()
        {
            // ExStart:MeteredLicensing

            // Create an instance of the Aspose.Imaging Metered class.
            Aspose.Imaging.Metered metered = new Aspose.Imaging.Metered();

            // Call SetMeteredKey method and pass the public and private keys as parameters.
            metered.SetMeteredKey("*****", "*****");

            // Get the metered consumption amount before invoking any API.
            decimal amountBefore = Aspose.Imaging.Metered.GetConsumptionQuantity();

            // Display the amount consumed before the operation.
            Console.WriteLine("Amount Consumed Before: " + amountBefore.ToString());

            // Get the metered consumption amount after invoking the API.
            decimal amountAfter = Aspose.Imaging.Metered.GetConsumptionQuantity();

            // Display the amount consumed after the operation.
            Console.WriteLine("Amount Consumed After: " + amountAfter.ToString());

            // ExEnd:MeteredLicensing
        }
    }
}
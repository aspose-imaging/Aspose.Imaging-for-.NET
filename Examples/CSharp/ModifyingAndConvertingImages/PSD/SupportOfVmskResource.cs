using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Layers.LayerResources;
using Aspose.Imaging.FileFormats.Psd.Layers.LayerResources.VectorPaths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class SupportOfVmskResource
    {

        public static void Run() {

            //ExStart:SupportOfVmskResource
            string dataDir = RunExamples.GetDataDir_PSD();

            string sourceFileName = dataDir + "Rectangle.psd";
            string exportPath = dataDir + "Rectangle_changed.psd";

            var im = (PsdImage)Image.Load(sourceFileName);

            using (im)
            {
                var resource = GetVmskResource(im);

                // Reading
                if (resource.IsDisabled != false ||
                    resource.IsInverted != false ||
                    resource.IsNotLinked != false ||
                    resource.Paths.Length != 7 ||
                    resource.Paths[0].Type != VectorPathType.PathFillRuleRecord ||
                    resource.Paths[1].Type != VectorPathType.InitialFillRuleRecord ||
                    resource.Paths[2].Type != VectorPathType.ClosedSubpathLengthRecord ||
                    resource.Paths[3].Type != VectorPathType.ClosedSubpathBezierKnotUnlinked ||
                    resource.Paths[4].Type != VectorPathType.ClosedSubpathBezierKnotUnlinked ||
                    resource.Paths[5].Type != VectorPathType.ClosedSubpathBezierKnotUnlinked ||
                    resource.Paths[6].Type != VectorPathType.ClosedSubpathBezierKnotUnlinked)
                {
                    throw new Exception("VmskResource was read wrong");
                }

                var pathFillRule = (PathFillRuleRecord)resource.Paths[0];
                var initialFillRule = (InitialFillRuleRecord)resource.Paths[1];
                var subpathLength = (LengthRecord)resource.Paths[2];

                // Path fill rule doesn't contain any additional information
                if (pathFillRule.Type != VectorPathType.PathFillRuleRecord ||
                initialFillRule.Type != VectorPathType.InitialFillRuleRecord ||
                initialFillRule.IsFillStartsWithAllPixels != false ||
                subpathLength.Type != VectorPathType.ClosedSubpathLengthRecord ||
                subpathLength.IsClosed != true ||
                subpathLength.IsOpen != false)
                {
                    throw new Exception("VmskResource paths were read wrong");
                }

                // Editing
                resource.IsDisabled = true;
                resource.IsInverted = true;
                resource.IsNotLinked = true;

                var bezierKnot = (BezierKnotRecord)resource.Paths[3];
                bezierKnot.Points[0] = new Point(0, 0);

                bezierKnot = (BezierKnotRecord)resource.Paths[4];
                bezierKnot.Points[0] = new Point(8039797, 10905190);

                initialFillRule.IsFillStartsWithAllPixels = true;
                subpathLength.IsClosed = false;
                im.Save(exportPath);
            }
            //ExEnd:SupportOfVmskResource
        }

        //ExStart:VmskResource
      static VmskResource GetVmskResource(PsdImage image)
        {
            var layer = image.Layers[1];

            VmskResource resource = null;
            var resources = layer.Resources;
            for (int i = 0; i < resources.Length; i++)
            {
                if (resources[i] is VmskResource)
                {
                    resource = (VmskResource)resources[i];
                    break;
                }
            }

            if (resource == null)
            {
                throw new Exception("VmskResource not found");
            }

            return resource;
        }

        //ExEnd:VmskResource
    }
}

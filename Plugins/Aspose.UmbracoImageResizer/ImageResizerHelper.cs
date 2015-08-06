using System;
using System.Drawing;
using System.IO;
using System.Web;
using umbraco.cms.businesslogic;
using umbraco.cms.businesslogic.media;
using umbraco.cms.businesslogic.member;
using umbraco.cms.businesslogic.property;
using umbraco.cms.businesslogic.web;

namespace Aspose.UmbracoImageResizer
{
    /// <summary>
    ///   ImageResizerHelper
    /// </summary>
    public static class ImageResizerHelper
    {
        ///<summary>
        ///  ImageResizer Guid
        ///</summary>
        internal static Guid DataTypeId = new Guid("EF70EC8C-C8C2-4A21-BFE9-7EEFD17F41D6");

        /// <summary>
        /// Gets the size string.
        /// </summary>
        /// <param name="imageUrl">The image URL.</param>
        /// <returns></returns>
        internal static string GetSizeString(string imageUrl)
        {
            try
            {
                var image = Image.FromFile(HttpContext.Current.Server.MapPath(imageUrl));
                return String.Format("{0} x {1}", image.Width, image.Height);
            }
            catch
            {
                return String.Empty;
            }
        }

        /// <summary>
        ///   Resizes the image.
        /// </summary>
        /// <returns></returns>
        internal static string ResizeImage(string imageUrl, int maxHeight, int maxWidth)
        {
            if (imageUrl == String.Empty) return String.Empty;

            var origUrl = imageUrl;
            var origFile = HttpContext.Current.Server.MapPath(origUrl);

            // Get height and width
            var height = maxHeight;
            var width = maxWidth;

            // get orig info
            var origFileNameWithoutExtension = Path.GetFileNameWithoutExtension(origFile);
            var origFileNameWithExtension = Path.GetFileName(origFile);
            var origExtension = Path.GetExtension(origFile);

            // build new file name
            var newFileName = String.Format("{0}_{1}x{2}{3}", origFileNameWithoutExtension, width, height, origExtension);
            var newFile = origFile.Replace(origFileNameWithExtension, newFileName);

            // Resize Image
            using (var image = Aspose.Imaging.Image.Load(origFile))
            {
                image.Resize(width, height, Aspose.Imaging.ResizeType.LanczosResample);
                image.Save(newFile);
            }

            return origUrl.Replace(origFileNameWithExtension, newFileName);
        }

        /// <summary>
        ///   Resizes the image.
        /// </summary>
        /// <param name = "origFile">The original file.</param>
        /// <param name = "newFile">The new file.</param>
        /// <param name = "maxWidth">Maximum Width.</param>
        /// <param name = "maxHeight">Maximum Height.</param>
        /// <param name = "resizeIfWider">if set to <c>true</c> [resize if wider].</param>
        /// <returns></returns>
        private static void ResizeImage(string origFile, string newFile, int maxWidth, int maxHeight, bool resizeIfWider)
        {
            var fullSizeImage = Image.FromFile(origFile);

            // Ensure the generated thumbnail is not being used by rotating it 360 degrees
            fullSizeImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            fullSizeImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

            if (resizeIfWider)
            {
                if (fullSizeImage.Width <= maxWidth)
                {
                    maxWidth = fullSizeImage.Width;
                }
            }

            Image newImage;
            var newWidth = fullSizeImage.Width * maxHeight / fullSizeImage.Height;
            var newHeight = fullSizeImage.Height * maxWidth / fullSizeImage.Width;

            if (fullSizeImage.Height > fullSizeImage.Width)
            {
                // Portait Image
                if (newWidth > maxHeight) // Width resize if necessary
                {
                    maxHeight = fullSizeImage.Height * maxWidth / fullSizeImage.Width;
                    newWidth = maxWidth;
                }
                // Create the new image with the sizes we've calculated
                newImage = fullSizeImage.GetThumbnailImage(newWidth, maxHeight, null, IntPtr.Zero);
            }
            else
            {
                // Landscape Image
                if (newHeight > maxHeight) // Height resize if necessary
                {
                    maxWidth = fullSizeImage.Width * maxHeight / fullSizeImage.Height;
                    newHeight = maxHeight;
                }
                // Create the new image with the sizes we've calculated
                newImage = fullSizeImage.GetThumbnailImage(maxWidth, newHeight, null, IntPtr.Zero);
            }

            fullSizeImage.Dispose();

            try
            {
                if (File.Exists(newFile))
                {
                    File.Delete(newFile);
                }

                newImage.Save(newFile);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Gets the current node id.
        /// </summary>
        /// <value>The current node id.</value>
        internal static int CurrentNodeId
        {
            get
            {
                return Convert.ToInt32(HttpContext.Current.Request.QueryString["id"]);
            }
        }

        /// <summary>
        ///   Gets the image property.
        /// </summary>
        /// <returns></returns>
        internal static string GetOriginalUrl(int nodeId, ImageResizerPrevalueEditor imagePrevalueEditor)
        {
            Property imageProperty;
            var node = new CMSNode(nodeId);
            if (node.nodeObjectType == Document._objectType)
            {
                imageProperty = new Document(nodeId).getProperty(imagePrevalueEditor.PropertyAlias);
            }
            else if (node.nodeObjectType == Media._objectType)
            {
                imageProperty = new Media(nodeId).getProperty(imagePrevalueEditor.PropertyAlias);
            }
            else
            {
                if (node.nodeObjectType != Member._objectType)
                {
                    throw new Exception("Unsupported Umbraco Node type for Image Resizer (only Document, Media and Members are supported.");
                }
                imageProperty = new Member(nodeId).getProperty(imagePrevalueEditor.PropertyAlias);
            }

            try
            {
                return imageProperty.Value.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
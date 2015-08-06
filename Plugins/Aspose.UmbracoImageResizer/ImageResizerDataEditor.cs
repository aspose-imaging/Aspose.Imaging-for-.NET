using System;
using System.Web.UI.WebControls;
using Image = System.Web.UI.WebControls.Image;

namespace Aspose.UmbracoImageResizer
{
    /// <summary>
    ///   This class is used for the actual datatype dataeditor, i.e. the control you will get in the content section of umbraco.
    /// </summary>
    public class ImageResizerDataEditor : Panel
    {
        private Image _imageResizerImage;
        private Literal _imageResizerLabel;
        private HiddenField _propertyAlias;

        /// <summary>
        /// Gets or sets the property alias.
        /// </summary>
        /// <value>The property alias.</value>
        public string PropertyAlias
        {
            get { return _propertyAlias.Value; }
            set { _propertyAlias.Value = value; }
        }

        /// <summary>
        ///   Gets or sets the color text.
        /// </summary>
        /// <value>The color text.</value>
        public string ImageUrl
        {
            get { return _imageResizerImage.ImageUrl; }
            set { _imageResizerImage.ImageUrl = value; }
        }

        /// <summary>
        /// Gets or sets the label text.
        /// </summary>
        /// <value>The label text.</value>
        public string LabelText
        {
            get { return _imageResizerLabel.Text; }
            set { _imageResizerLabel.Text = value; }
        }

        /// <summary>
        ///   Raises the <see cref = "E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name = "e">An <see cref = "T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            EnsureChildControls();
        }

        /// <summary>
        ///   Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
        /// </summary>
        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            // Resized Image
            _imageResizerImage = new Image();

            // Label
            _imageResizerLabel = new Literal { Text = string.Empty };

            _propertyAlias = new HiddenField();

            Controls.Add(_imageResizerImage);
            Controls.Add(_imageResizerLabel);
            Controls.Add(_propertyAlias);
        }

        #region Methods

        /// <summary>
        /// Toggles the specified property ok.
        /// </summary>
        /// <param name="propertyOk">if set to <c>true</c> [property ok].</param>
        internal void Toggle(bool propertyOk)
        {
            if (propertyOk)
            {
                _imageResizerImage.Visible = true;
            }
            else
            {
                _imageResizerImage.Visible = false;
                _imageResizerLabel.Text = "<strong>No image to resize</strong>";
            }
        }

        #endregion
    }
}
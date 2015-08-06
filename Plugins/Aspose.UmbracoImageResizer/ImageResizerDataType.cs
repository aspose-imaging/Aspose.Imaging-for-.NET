using System;
using umbraco.cms.businesslogic.datatype;
using umbraco.interfaces;

namespace Aspose.UmbracoImageResizer
{
    /// <summary>
    ///   This is basicly where you give the datatype it’s name and unique id. 
    ///   The name will show up in the rendercontrol dropdown of the edit datatype page.
    /// </summary>
    public class ImageResizerDataType : AbstractDataEditor
    {
        #region Fields
        private readonly ImageResizerDataEditor _imageResizerDataEditor;
        private ImageResizerPrevalueEditor _imageResizerPrevalueEditor;
        #endregion

        #region Constructor

        /// <summary>
        ///   Initializes a new instance of the <see cref = "Aspose.UmbracoImageResizer" /> class.
        /// </summary>
        public ImageResizerDataType()
        {
            _imageResizerDataEditor = new ImageResizerDataEditor();
            RenderControl = _imageResizerDataEditor;
            _imageResizerDataEditor.PreRender += ImageResizerDataEditorPreRender;
            DataEditorControl.OnSave += DataEditorControl_OnSave;
        }

        #endregion

        #region Event Methods

        /// <summary>
        /// </summary>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void DataEditorControl_OnSave(EventArgs e)
        {
            var prevalueEditor = (ImageResizerPrevalueEditor)PrevalueEditor;
            var imageUrl = ImageResizerHelper.ResizeImage(ImageResizerHelper.GetOriginalUrl(ImageResizerHelper.CurrentNodeId, prevalueEditor), prevalueEditor.MaxHeight, prevalueEditor.MaxWidth);

            _imageResizerDataEditor.ImageUrl = imageUrl;

            base.Data.Value = _imageResizerDataEditor.ImageUrl;
        }

        /// <summary>
        /// Handles the PreRender event of the _colorPickerDataEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ImageResizerDataEditorPreRender(object sender, EventArgs e)
        {
            var prevalueEditor = (ImageResizerPrevalueEditor)PrevalueEditor;

            _imageResizerDataEditor.PropertyAlias = prevalueEditor.PropertyAlias;
            _imageResizerDataEditor.ImageUrl = base.Data.Value.ToString();

            var propertyOk = ImageResizerHelper.GetOriginalUrl(ImageResizerHelper.CurrentNodeId, prevalueEditor) != string.Empty;

            _imageResizerDataEditor.Toggle(propertyOk);
            if (propertyOk)
            {
                _imageResizerDataEditor.LabelText = string.Format("<p>{0}</p>", ImageResizerHelper.GetSizeString(_imageResizerDataEditor.ImageUrl));
            }
        }

        #endregion

        #region Overrides of AbstractDataEditor

        /// <summary>
        ///   Gets the datatype unique id.
        /// </summary>
        /// <value>The id.</value>
        public override Guid Id
        {
            get { return ImageResizerHelper.DataTypeId; }
        }

        /// <summary>
        ///   Gets the datatype unique id.
        /// </summary>
        /// <value>The id.</value>
        public override string DataTypeName
        {
            get { return "Aspose Image Resizer"; }
        }

        /// <summary>
        ///   Gets the prevalue editor.
        /// </summary>
        /// <value>The prevalue editor.</value>
        public override IDataPrevalue PrevalueEditor
        {
            get { return _imageResizerPrevalueEditor ?? (_imageResizerPrevalueEditor = new ImageResizerPrevalueEditor(this)); }
        }

        ///// <summary>
        ///// Gets the render control.
        ///// </summary>
        ///// <value>The render control.</value>
        //public new Control RenderControl
        //{
        //    get { return _imageResizerDataEditor ?? (base.RenderControl = _imageResizerDataEditor = new ImageResizerDataEditor()); }
        //    set { base.RenderControl = value; }
        //}

        #endregion
    }
}
using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbraco.cms.businesslogic.datatype;
using umbraco.interfaces;

[assembly: WebResource("Aspose.UmbracoImageResizer.css.PrevalueEditor.css", "text/css", PerformSubstitution = true)]

namespace Aspose.UmbracoImageResizer
{
    /// <summary>
    ///   This class is used to setup the datatype settings. 
    ///   On save it will store these values (using the datalayer) in the database
    /// </summary>
    public class ImageResizerPrevalueEditor : Control, IDataPrevalue
    {
        #region Fields

        private readonly BaseDataType _dataType;
        private SortedList _preValues;

        #endregion

        #region Controls

        /// <summary>
        /// PropertyAliasTextBox
        /// </summary>
        protected TextBox PropertyAliasTextBox;

        /// <summary>
        ///   MaxHeightTextBox
        /// </summary>
        protected TextBox MaxHeightTextBox;

        /// <summary>
        ///   MaxWidthTextBox
        /// </summary>
        protected TextBox MaxWidthTextBox;

        #endregion

        #region Constructor

        /// <summary>
        ///   Initializes a new instance of the <see cref = "ImageResizerPrevalueEditor" /> class.
        /// </summary>
        /// <param name = "dataType">Type of the data.</param>
        public ImageResizerPrevalueEditor(BaseDataType dataType)
        {
            _dataType = dataType;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the property alias.
        /// </summary>
        /// <value>The property alias.</value>
        public string PropertyAlias
        {
            get
            {
                try
                {
                    return GetPreValue(0);
                }
                catch
                {
                    return "umbracoFile";
                }
            }
        }

        /// <summary>
        ///   Gets the height of the box.
        /// </summary>
        /// <value>The size of the box.</value>
        public int MaxHeight
        {
            get
            {
                try
                {
                    return Convert.ToInt32(GetPreValue(1));
                }
                catch
                {
                    return 600;
                }
            }
        }

        /// <summary>
        ///   Gets the width of the box.
        /// </summary>
        /// <value>The width of the box.</value>
        public int MaxWidth
        {
            get
            {
                try
                {
                    return Convert.ToInt32(GetPreValue(2));
                }
                catch
                {
                    return 800;
                }
            }
        }

        /// <summary>
        ///   Gets the editor pre values.
        /// </summary>
        /// <value>The editor pre values.</value>
        private SortedList EditorPreValues
        {
            get { return _preValues ?? (_preValues = PreValues.GetPreValues(_dataType.DataTypeDefinitionId)); }
        }

        #endregion

        #region Methods

        /// <summary>
        ///   Gets the pre value.
        /// </summary>
        /// <param name = "index">The index.</param>
        /// <returns></returns>
        private string GetPreValue(int index)
        {
            return ((PreValue)EditorPreValues[index]).Value;
        }

        /// <summary>
        ///   Inserts the value.
        /// </summary>
        /// <param name = "index">The index.</param>
        /// <param name = "value">The value.</param>
        /// <returns></returns>
        private void UpdatePreValue(int index, string value)
        {
            if (EditorPreValues.Count >= index + 1)
            {
                //update
                var preValue = (PreValue)EditorPreValues[index];
                preValue.Value = value;
                preValue.Save();
            }
            else
            {
                //insert
                var preValue = PreValue.MakeNew(_dataType.DataTypeDefinitionId, value);
                preValue.Save();
            }
            return;
        }

        #endregion

        #region Implementation of IDataPrevalue

        /// <summary>
        ///   Saves the prevalues to the Umbraco database.
        /// </summary>
        public void Save()
        {
            _dataType.DBType = DBTypes.Nvarchar;

            UpdatePreValue(0, PropertyAliasTextBox.Text);
            UpdatePreValue(1, MaxHeightTextBox.Text);
            UpdatePreValue(2, MaxWidthTextBox.Text);
        }

        /// <summary>
        ///   Gets the editor.
        /// </summary>
        /// <value>The editor.</value>
        public Control Editor
        {
            get { return this; }
        }

        #endregion

        #region Overrides

        /// <summary>
        ///   Raises the <see cref = "E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name = "e">An <see cref = "T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            EnsureChildControls();

            this.AddResourceToClientDependency("Aspose.UmbracoImageResizer.css.PrevalueEditor.css", ClientDependencyType.Css);
        }

        /// <summary>
        ///   Sets up the child controls.
        ///   Creates new instances of the Datatype Controls
        /// </summary>
        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            PropertyAliasTextBox = new TextBox { ID = "txtPropertyAlias" };
            MaxHeightTextBox = new TextBox { ID = "txtMaxHeight", Width = new Unit("25px") };
            MaxWidthTextBox = new TextBox { ID = "txtMaxWidth", Width = new Unit("25px") };

            Controls.Add(MaxHeightTextBox);
            Controls.Add(MaxWidthTextBox);
        }

        /// <summary>
        ///   Raises the <see cref = "E:System.Web.UI.Control.Load" /> event.
        /// </summary>
        /// <param name = "e">The <see cref = "T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PropertyAliasTextBox.Text = PropertyAlias;
            MaxHeightTextBox.Text = MaxHeight.ToString();
            MaxWidthTextBox.Text = MaxWidth.ToString();
        }

        /// <summary>
        ///   Sends server control content to a provided <see cref = "T:System.Web.UI.HtmlTextWriter" /> object, 
        ///   which writes the content to be rendered on the client.
        /// </summary>
        /// <param name = "writer">The <see cref = "T:System.Web.UI.HtmlTextWriter" /> object that receives the server control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "imageResizerPreValues");
            writer.RenderBeginTag(HtmlTextWriterTag.Div); //start 'imageResizerPreValues'
            writer.AddPrevalueHeading("Aspose Image Resizer");
            writer.AddPrevalueRow("Property Alias", "Alias of image property  (eg. 'umbracoFile'):", PropertyAliasTextBox);
            writer.AddPrevalueRow("Width", "Maximum width of generated image", MaxWidthTextBox);
            writer.AddPrevalueRow("Height", "Maximum height of generated image", MaxHeightTextBox);
            writer.AddPrevalueRow("", "<p>Aspect ratio is maintained during image resizing.</br>Landscape will restrict to Width<br/>Portrait will restrict to Height</p>");
            writer.RenderEndTag(); // end 'imageResizerPreValues'
        }

        #endregion
    }
}
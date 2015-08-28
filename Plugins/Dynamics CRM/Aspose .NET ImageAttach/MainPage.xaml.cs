using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Media.Imaging;
using Aspose.ImageAttach.CRMODataService;
using System.Data.Services.Client;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Browser;

namespace Aspose.ImageAttach
{
    public partial class MainPage : UserControl
    {
        string SaveToEntity = "1";
        string LicenseWebResourceName = "Aspose_License.lic";
        string EntityId = "";
        string EntityTypeName = "";
        string OrgName = "";
        string WebResourceName = "";
        string ErrorMessage = "";
        string ImageFileName = "";
        string ThisNoteId = "";
        AsposeCRMContext ThisContext;
        public MainPage()
        {
            InitializeComponent();
            try
            {
                CreateService();
                ReadEntityParameter();
                GenerateImageFileName();
                if (Validate())
                {
                    ShowImage();
                }
                else
                {
                    MessageBox.Show(ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something goes wrong. Details: " + ex.Message);
            }
        }
        private void ShowImage()
        {
            DataServiceQuery<Annotation> NotesQuery = (DataServiceQuery<Annotation>)this.ThisContext
               .AnnotationSet.Where<Annotation>(a => a.FileName == ImageFileName);
            NotesQuery.BeginExecute(ReadNotesCompleted, NotesQuery);
        }
        private void ReadNotesCompleted(IAsyncResult result)
        {
            try
            {
                DataServiceQuery<Annotation> NotesQuery = result.AsyncState as DataServiceQuery<Annotation>;
                ObservableCollection<Annotation> Notes =
                         new DataServiceCollection<Annotation>(NotesQuery.EndExecute(result));
                if (Notes.Count > 0)
                {
                    Annotation Note = Notes[0];
                    ThisNoteId = Note.AnnotationId.ToString();
                    byte[] encodedData = System.Convert.FromBase64String(Note.DocumentBody);
                    MemoryStream str = new MemoryStream(encodedData);
                    BitmapImage bmp = new BitmapImage();
                    bmp.SetSource(str);
                    IMG_Image.Source = bmp;
                    IMG_Image.Height = MainControl.Height;
                    IMG_Image.Width = MainControl.Width;
                }
                else
                    IMG_Image.Source = null;
                ReadConfiguration();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void GenerateImageFileName()
        {
            ImageFileName = "Aspose.ImageAttach_" + OrgName + "_" + EntityTypeName + "_" + EntityId + ((WebResourceName != "") ? "_" + WebResourceName : "");
        }
        private bool Validate()
        {
            //EntityId,EntityType,EntityTypeName,OrgName
            return true;
        }
        private void ReadEntityParameter()
        {
            if (App.Current.Host.InitParams.Keys.Contains("id"))
            {
                EntityId = App.Current.Host.InitParams["id"];
            }
            if (App.Current.Host.InitParams.Keys.Contains("typename"))
            {
                EntityTypeName = App.Current.Host.InitParams["typename"];
            }
            if (App.Current.Host.InitParams.Keys.Contains("orgname"))
            {
                OrgName = App.Current.Host.InitParams["orgname"];
            }
            if (App.Current.Host.InitParams.Keys.Contains("data"))
            {
                string Data = App.Current.Host.InitParams["data"];
                string[] Parameters = Data.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string Parameter in Parameters)
                {
                    if (Parameter.ToLower().Contains("Container".ToLower()))
                    {
                        WebResourceName = Parameter.Replace("Container", "").Replace("container", "").Replace("=", "").Replace(" ", "");
                    }
                }
            }
        }
        private void CreateService()
        {
            SynchronizationContext SyncContext = SynchronizationContext.Current;
            String ServerUrl = GetServerUrlFromContext();
            if (!String.IsNullOrEmpty(ServerUrl))
            {
                ThisContext = new AsposeCRMContext(
                    new Uri(String.Format("{0}/xrmservices/2011/organizationdata.svc/",
                            ServerUrl), UriKind.Absolute));
                ThisContext.IgnoreMissingProperties = true;
            }
        }
        private static String GetServerUrlFromContext()
        {
            ScriptObject xrm = (ScriptObject)HtmlPage.Window.GetProperty("Xrm");
            ScriptObject page = (ScriptObject)xrm.GetProperty("Page");
            ScriptObject pageContext = (ScriptObject)page.GetProperty("context");
            String serverUrl = (String)pageContext.Invoke("getClientUrl");
            if (serverUrl.EndsWith("/"))
            {
                serverUrl = serverUrl.Substring(0, serverUrl.Length - 1);
            }
            return serverUrl;
        }
        private void ReadConfiguration()
        {
            int Value = 100000000; //Aspose.ImageAttach
            DataServiceQuery<aspose_configuration> Configs = (DataServiceQuery<aspose_configuration>)this.ThisContext
                .aspose_configurationSet.Where<aspose_configuration>(a => a.aspose_Type.Value.Value == Value);
            Configs.BeginExecute(ReadConfiguration, Configs);
        }
        private void ReadConfiguration(IAsyncResult result)
        {
            DataServiceQuery<aspose_configuration> results = result.AsyncState as DataServiceQuery<aspose_configuration>;
            ObservableCollection<aspose_configuration> Configs =
                     new DataServiceCollection<aspose_configuration>(results.EndExecute(result));
            foreach (aspose_configuration Config in Configs)
            {
                if (Config.aspose_name.ToLower() == "SaveToEntity".ToLower())
                {
                    SaveToEntity = Config.aspose_Value;
                }
                if (Config.aspose_name.ToLower() == "LicenseWebResourceName".ToLower())
                {
                    LicenseWebResourceName = Config.aspose_Value;
                }
            }
            EnableLicense();
        }
        MemoryStream AsposeImageStream = new MemoryStream();
        string fileExt = "";
        private void BTN_Upload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
                op.Multiselect = false;
                op.ShowDialog();
                if (op.File != null && op.File.Name != "")
                {
                    if (op.File.Length < 1048576)
                    {
                        FileStream stream = op.File.OpenRead();
                        fileExt = op.File.Extension;
                        Aspose.Imaging.Image img = Aspose.Imaging.Image.Load(stream);
                        AsposeImageStream = new MemoryStream();
                        img.Save(AsposeImageStream);
                        BitmapImage bmp = new BitmapImage();
                        bmp.SetSource(AsposeImageStream);
                        IMG_Image.Source = bmp;
                        IMG_Image.Height = MainControl.Height;
                        IMG_Image.Width = MainControl.Width;
                        CreateService();
                        if (ThisNoteId != "")
                        {
                            Annotation DelNote = new Annotation();
                            DelNote.AnnotationId = new Guid(ThisNoteId);
                            ThisContext.AttachTo("AnnotationSet", DelNote);
                            ThisContext.DeleteObject(DelNote);
                            ThisContext.BeginSaveChanges(DeleteAnnotation, DelNote);
                        }
                        else
                            UploadPicture();
                    }
                    else
                    {
                        MessageBox.Show("Max file size is 1 MB");
                    }
                }
                else
                {
                    MessageBox.Show("Select File");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnableLicense()
        {
            if (LicenseWebResourceName != "")
            {
                DataServiceQuery<WebResource> License = (DataServiceQuery<WebResource>)this.ThisContext
                    .WebResourceSet.Where<WebResource>(a => a.Name == LicenseWebResourceName);
                License.BeginExecute(RetrieveLicense, License);
            }
        }
        private void RetrieveLicense(IAsyncResult result)
        {
            //Retrieve the query that was
            DataServiceQuery<WebResource> results = result.AsyncState as DataServiceQuery<WebResource>;
            ObservableCollection<WebResource> Licenses =
                     new DataServiceCollection<WebResource>(results.EndExecute(result));
            if (Licenses.Count > 0)
            {
                try
                {
                    MemoryStream LicenseStream = new MemoryStream(Convert.FromBase64String(Licenses[0].Content));
                    Aspose.Imaging.License Lic = new Imaging.License();
                    Lic.SetLicense(LicenseStream);
                }
                catch (Exception) { }
            }
        }
        private void UploadPicture()
        {
            CreateService();
            if (AsposeImageStream.Length > 0)
            {
                byte[] byteData = AsposeImageStream.ToArray();
                // Encode the data using base64.
                string encodedData = System.Convert.ToBase64String(byteData);
                Annotation NewNote = new Annotation();
                if (SaveToEntity != "0")
                {
                    NewNote.ObjectId = new EntityReference();
                    NewNote.ObjectId.LogicalName = EntityTypeName;
                    NewNote.ObjectId.Id = new Guid(EntityId);
                }
                NewNote.Subject = ImageFileName;
                NewNote.DocumentBody = encodedData;
                NewNote.MimeType = fileExt;
                NewNote.NoteText = "Aspose.ImageAttach For Dynamics CRM";
                NewNote.FileName = ImageFileName;
                ThisContext.AddToAnnotationSet(NewNote);
                ThisContext.BeginSaveChanges(CreateNote, NewNote);
            }
        }
        private void CreateNote(IAsyncResult result)
        {
            try
            {
                ThisContext.EndSaveChanges(result);
                Annotation Note = result.AsyncState as Annotation;
                ThisNoteId = Note.AnnotationId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteAnnotation(IAsyncResult result)
        {
            ThisContext.EndSaveChanges(result);
            Annotation deletedNote = result.AsyncState as Annotation;
            ThisNoteId = "";
            UploadPicture();
        }
        private void BTN_Remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ThisNoteId != "")
                {
                    AsposeImageStream = new MemoryStream();
                    CreateService();
                    Annotation DelNote = new Annotation();
                    DelNote.AnnotationId = new Guid(ThisNoteId);
                    ThisContext.AttachTo("AnnotationSet", DelNote);
                    ThisContext.DeleteObject(DelNote);
                    ThisContext.BeginSaveChanges(DeleteAnnotation, DelNote);
                    IMG_Image.Source = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

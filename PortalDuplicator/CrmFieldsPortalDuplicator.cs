using System;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox.Extensibility.Args;
using DMM365.Helper;
using System.IO;

namespace PortalDuplicator
{
    public partial class CrmFieldsPortalDuplicator : PluginControlBase, IXrmToolBoxPluginControl, IStatusBarMessenger, INoConnectionRequired, IPayPalPlugin, IHelpPlugin
    {
        #region declarations

        //private Settings mySettings;
        public event EventHandler OnRequestConnection;

        private ConnectionDetail sourceDetail;
        private ConnectionDetail targetDetail;
        IOrganizationService sourceService;
        IOrganizationService targetService;

        bool isLog = false;

        #endregion declarations


        #region IPayPalPlugin

        string IPayPalPlugin.DonationDescription => "Thanks in advance";

        string IPayPalPlugin.EmailAccount => "michael.kalinov@gmail.com";

        #endregion IPayPalPlugin


        #region IHelpPlugin

        string IHelpPlugin.HelpUrl => "https://github.com/mkalinov/AttachmentsReversibleCopy";

        #endregion IHelpPlugin


        #region IStatusBarMessenger

        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

        #endregion IStatusBarMessenger


        #region PluginControlBase

        public CrmFieldsPortalDuplicator()
        {
            InitializeComponent();
        }

        private void CrmFieldsPortalDuplicator_Load(object sender, EventArgs e)
        {
            //  ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }


        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrmFieldsPortalDuplicator_OnCloseTool(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName = "", object parameter = null)
        {


        }


        #endregion PluginControlBase


        #region  Portal Douplicator

        private void btnSelectPackage_Click(object sender, EventArgs e)
        {
            fileDialogResult(openFileGetPackage, txtPackageUrl);
        }


        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            groupFinalPackage.Visible = false;

            if (GlobalHelper.isValidString(txtPackageUrl.Text)
                && File.Exists(txtPackageUrl.Text))
            {
                duplicateFileWithNewGuids(txtPackageUrl.Text);
            }
            else
            {
                MessageBox.Show($"File {txtPackageUrl.Text} cannot be found", "No File");
                return;
            }
        }

        private void linkFinalPackgeDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel lb = sender as LinkLabel;
            if (ReferenceEquals(lb, null)) return;

            try
            {
                if (!GlobalHelper.isValidString(lb.Text)) throw new Exception("Cannot process the link");

                System.Diagnostics.Process.Start(Path.GetDirectoryName(lb.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        #endregion Portal Douplicator


        #region Helpers

        private void duplicateFileWithNewGuids(string zipPath)
        {
            try
            {
                //craete dedicated directories: unpack and replace
                string unpackDirName = Path.GetFileNameWithoutExtension(zipPath);
                string targetDirName = "Duplicated_" + Path.GetFileNameWithoutExtension(zipPath) + "_" + DateTime.Now.ToString("MM-dd-yyyy HH:mm").Replace(':', '-');
                string unpackDirPath = Path.Combine(Path.GetDirectoryName(zipPath), unpackDirName);
                string targetDirPath = Path.Combine(Path.GetDirectoryName(zipPath), targetDirName);

                //if directory exists: check with user if ok to delete the content
                if (Directory.Exists(unpackDirPath)) {
                    if (DialogResult.Yes == MessageBox.Show($"The directory {unpackDirPath} already exists. Is it ok to delete the directory?", "Confirm existing directory delete", MessageBoxButtons.YesNo))
                    {
                        Directory.Delete(Path.GetDirectoryName(zipPath));
                    }
                    else
                    {
                        throw new Exception("Please change zip file name to create anoter directory.");
                    }
                }    

                DirectoryInfo unPackDir = IOHelper.createDirectory(unpackDirPath);
                DirectoryInfo targetDir = IOHelper.createDirectory(targetDirPath);


                //unzip package to new dir
                ArchiveHelper.ExtractZipToDirectory(zipPath, unPackDir.FullName);
                ArchiveHelper.ExtractZipToDirectory(zipPath, targetDir.FullName);
                //check if data.xml exists
                string dataXmlPath = Path.Combine(unPackDir.FullName, "data.xml");
                string newDataXmlPath = Path.Combine(targetDir.FullName, "data.xml");
                if (!File.Exists(dataXmlPath)) throw new Exception($"No 'data.xml' found at {unPackDir.FullName}");
                //replace guids and override data.xml in the target folder
                ReplaceIDHelper.replaceGuids(dataXmlPath, newDataXmlPath);
                //create a new zip for import
                string finalZipPath = Path.Combine(Path.GetDirectoryName(zipPath), targetDirName + ".zip");
                ArchiveHelper.CreateZipFromDirectory(targetDir.FullName, finalZipPath);
                //try to delete two unziped folders
                try
                {
                    IOHelper.clearDirectory(unpackDirPath);
                    IOHelper.clearDirectory(targetDirPath);
                    Directory.Delete(unpackDirPath);
                    Directory.Delete(targetDirPath);
                }
                catch (Exception)
                {
                    //cannot delete if no permissions or file is locked
                }
                //set link
                if (File.Exists(finalZipPath))
                {
                    linkFinalPackgeDirectory.Text = finalZipPath;
                    groupFinalPackage.Visible = true;
                    MessageBox.Show($"The package '{targetDirName + ".zip"}' is ready to be imported with Configuration Migration tool");
                }
                else
                {                  
                    throw new Exception("Something went wrong. Zip for import was not created.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void fileDialogResult(OpenFileDialog ofd, TextBox target)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                target.Text = ofd.FileName;
            }
        }



        #endregion Helpers
    }
}
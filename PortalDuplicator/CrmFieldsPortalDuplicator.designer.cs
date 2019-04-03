namespace PortalDuplicator
{
    partial class CrmFieldsPortalDuplicator
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrmFieldsPortalDuplicator));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupIntro = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupSelectFile = new System.Windows.Forms.GroupBox();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnSelectPackage = new System.Windows.Forms.Button();
            this.txtPackageUrl = new System.Windows.Forms.TextBox();
            this.groupFinalPackage = new System.Windows.Forms.GroupBox();
            this.linkFinalPackgeDirectory = new System.Windows.Forms.LinkLabel();
            this.openFileGetPackage = new System.Windows.Forms.OpenFileDialog();
            this.lblTutorial1 = new System.Windows.Forms.Label();
            this.lblTutorial2 = new System.Windows.Forms.Label();
            this.lblTutorial3 = new System.Windows.Forms.Label();
            this.linkFullCopy = new System.Windows.Forms.LinkLabel();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.linkDataUtility = new System.Windows.Forms.LinkLabel();
            this.lblHowTo = new System.Windows.Forms.Label();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.linkPortalManagement = new System.Windows.Forms.LinkLabel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblTutorial4 = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupIntro.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupSelectFile.SuspendLayout();
            this.groupFinalPackage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1791, 27);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(107, 24);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupIntro);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1771, 887);
            this.panel1.TabIndex = 10;
            // 
            // groupIntro
            // 
            this.groupIntro.Controls.Add(this.lblTutorial4);
            this.groupIntro.Controls.Add(this.lblWarning);
            this.groupIntro.Controls.Add(this.linkPortalManagement);
            this.groupIntro.Controls.Add(this.linkHelp);
            this.groupIntro.Controls.Add(this.lblHowTo);
            this.groupIntro.Controls.Add(this.linkDataUtility);
            this.groupIntro.Controls.Add(this.lblIntroduction);
            this.groupIntro.Controls.Add(this.linkFullCopy);
            this.groupIntro.Controls.Add(this.lblTutorial3);
            this.groupIntro.Controls.Add(this.lblTutorial2);
            this.groupIntro.Controls.Add(this.lblTutorial1);
            this.groupIntro.Location = new System.Drawing.Point(17, 17);
            this.groupIntro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupIntro.Name = "groupIntro";
            this.groupIntro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupIntro.Size = new System.Drawing.Size(1717, 484);
            this.groupIntro.TabIndex = 14;
            this.groupIntro.TabStop = false;
            this.groupIntro.Text = "Introduction";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupFinalPackage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupSelectFile, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 524);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.82979F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.17021F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1750, 329);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // groupSelectFile
            // 
            this.groupSelectFile.Controls.Add(this.btnDuplicate);
            this.groupSelectFile.Controls.Add(this.btnSelectPackage);
            this.groupSelectFile.Controls.Add(this.txtPackageUrl);
            this.groupSelectFile.Location = new System.Drawing.Point(4, 4);
            this.groupSelectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSelectFile.Name = "groupSelectFile";
            this.groupSelectFile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSelectFile.Size = new System.Drawing.Size(1713, 193);
            this.groupSelectFile.TabIndex = 15;
            this.groupSelectFile.TabStop = false;
            this.groupSelectFile.Text = "Select Source Configuration Migration Package";
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(795, 98);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(191, 32);
            this.btnDuplicate.TabIndex = 60;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.UseCompatibleTextRendering = true;
            this.btnDuplicate.UseVisualStyleBackColor = false;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // btnSelectPackage
            // 
            this.btnSelectPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectPackage.Location = new System.Drawing.Point(8, 48);
            this.btnSelectPackage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectPackage.Name = "btnSelectPackage";
            this.btnSelectPackage.Size = new System.Drawing.Size(189, 32);
            this.btnSelectPackage.TabIndex = 62;
            this.btnSelectPackage.Text = "Select Data File";
            this.btnSelectPackage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectPackage.UseCompatibleTextRendering = true;
            this.btnSelectPackage.UseVisualStyleBackColor = false;
            this.btnSelectPackage.Click += new System.EventHandler(this.btnSelectPackage_Click);
            // 
            // txtPackageUrl
            // 
            this.txtPackageUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPackageUrl.Location = new System.Drawing.Point(9, 98);
            this.txtPackageUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPackageUrl.Multiline = true;
            this.txtPackageUrl.Name = "txtPackageUrl";
            this.txtPackageUrl.ReadOnly = true;
            this.txtPackageUrl.Size = new System.Drawing.Size(725, 48);
            this.txtPackageUrl.TabIndex = 61;
            // 
            // groupFinalPackage
            // 
            this.groupFinalPackage.Controls.Add(this.linkFinalPackgeDirectory);
            this.groupFinalPackage.Location = new System.Drawing.Point(4, 214);
            this.groupFinalPackage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupFinalPackage.Name = "groupFinalPackage";
            this.groupFinalPackage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupFinalPackage.Size = new System.Drawing.Size(1713, 111);
            this.groupFinalPackage.TabIndex = 8;
            this.groupFinalPackage.TabStop = false;
            this.groupFinalPackage.Text = "Click to open file location";
            this.groupFinalPackage.UseWaitCursor = true;
            this.groupFinalPackage.Visible = false;
            // 
            // linkFinalPackgeDirectory
            // 
            this.linkFinalPackgeDirectory.AutoSize = true;
            this.linkFinalPackgeDirectory.Location = new System.Drawing.Point(28, 52);
            this.linkFinalPackgeDirectory.Name = "linkFinalPackgeDirectory";
            this.linkFinalPackgeDirectory.Size = new System.Drawing.Size(67, 20);
            this.linkFinalPackgeDirectory.TabIndex = 0;
            this.linkFinalPackgeDirectory.TabStop = true;
            this.linkFinalPackgeDirectory.Text = "final zip";
            this.linkFinalPackgeDirectory.UseWaitCursor = true;
            this.linkFinalPackgeDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFinalPackgeDirectory_LinkClicked);
            // 
            // openFileGetPackage
            // 
            this.openFileGetPackage.Filter = "ZIP Files (*.zip)|*.zip";
            this.openFileGetPackage.Title = "Select a zip (by Configuration Migration tool)";
            // 
            // lblTutorial1
            // 
            this.lblTutorial1.AutoSize = true;
            this.lblTutorial1.ForeColor = System.Drawing.Color.Red;
            this.lblTutorial1.Location = new System.Drawing.Point(1057, 163);
            this.lblTutorial1.Name = "lblTutorial1";
            this.lblTutorial1.Size = new System.Drawing.Size(344, 20);
            this.lblTutorial1.TabIndex = 0;
            this.lblTutorial1.Text = "1. Make Full Copy of target crm environment ";
            // 
            // lblTutorial2
            // 
            this.lblTutorial2.AutoSize = true;
            this.lblTutorial2.Location = new System.Drawing.Point(1057, 229);
            this.lblTutorial2.Name = "lblTutorial2";
            this.lblTutorial2.Size = new System.Drawing.Size(511, 40);
            this.lblTutorial2.TabIndex = 1;
            this.lblTutorial2.Text = "2. Create a Configuration Migration package from source crm. \r\n    Mind that the " +
    "package contains all portals residing in source crm";
            // 
            // lblTutorial3
            // 
            this.lblTutorial3.AutoSize = true;
            this.lblTutorial3.Location = new System.Drawing.Point(1057, 313);
            this.lblTutorial3.Name = "lblTutorial3";
            this.lblTutorial3.Size = new System.Drawing.Size(604, 40);
            this.lblTutorial3.TabIndex = 2;
            this.lblTutorial3.Text = "3. Consider to change target portal name by appending a version or another way\r\n " +
    "  Set target portal \"OFF\" in Portal Mangement panel, hit Update button";
            // 
            // linkFullCopy
            // 
            this.linkFullCopy.AutoSize = true;
            this.linkFullCopy.Location = new System.Drawing.Point(1058, 192);
            this.linkFullCopy.Name = "linkFullCopy";
            this.linkFullCopy.Size = new System.Drawing.Size(79, 20);
            this.linkFullCopy.TabIndex = 3;
            this.linkFullCopy.TabStop = true;
            this.linkFullCopy.Text = "Full Copy";
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(9, 124);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(793, 340);
            this.lblIntroduction.TabIndex = 4;
            this.lblIntroduction.Text = resources.GetString("lblIntroduction.Text");
            // 
            // linkDataUtility
            // 
            this.linkDataUtility.AutoSize = true;
            this.linkDataUtility.Location = new System.Drawing.Point(1058, 279);
            this.linkDataUtility.Name = "linkDataUtility";
            this.linkDataUtility.Size = new System.Drawing.Size(272, 20);
            this.linkDataUtility.TabIndex = 5;
            this.linkDataUtility.TabStop = true;
            this.linkDataUtility.Text = "Configuration Migration tool in SDK";
            this.linkDataUtility.Visible = false;
            // 
            // lblHowTo
            // 
            this.lblHowTo.AutoSize = true;
            this.lblHowTo.Location = new System.Drawing.Point(1058, 128);
            this.lblHowTo.Name = "lblHowTo";
            this.lblHowTo.Size = new System.Drawing.Size(67, 20);
            this.lblHowTo.TabIndex = 6;
            this.lblHowTo.Text = "How to:";
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Location = new System.Drawing.Point(209, 71);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(186, 20);
            this.linkHelp.TabIndex = 7;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Read Help section first!";
            // 
            // linkPortalManagement
            // 
            this.linkPortalManagement.AutoSize = true;
            this.linkPortalManagement.Location = new System.Drawing.Point(1058, 364);
            this.linkPortalManagement.Name = "linkPortalManagement";
            this.linkPortalManagement.Size = new System.Drawing.Size(199, 20);
            this.linkPortalManagement.TabIndex = 8;
            this.linkPortalManagement.TabStop = true;
            this.linkPortalManagement.Text = "Portal Management panel";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(209, 35);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(1211, 24);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "Warning: Mind that careless utilization of this tool may corrupt your portal. Pre" +
    "cautions: backup evironments, make tests before use in Production.";
            // 
            // lblTutorial4
            // 
            this.lblTutorial4.AutoSize = true;
            this.lblTutorial4.Location = new System.Drawing.Point(1058, 400);
            this.lblTutorial4.Name = "lblTutorial4";
            this.lblTutorial4.Size = new System.Drawing.Size(578, 60);
            this.lblTutorial4.TabIndex = 10;
            this.lblTutorial4.Text = resources.GetString("lblTutorial4.Text");
            // 
            // CrmFieldsPortalDuplicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrmFieldsPortalDuplicator";
            this.Size = new System.Drawing.Size(1791, 937);
            this.Load += new System.EventHandler(this.CrmFieldsPortalDuplicator_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupIntro.ResumeLayout(false);
            this.groupIntro.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupSelectFile.ResumeLayout(false);
            this.groupSelectFile.PerformLayout();
            this.groupFinalPackage.ResumeLayout(false);
            this.groupFinalPackage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupIntro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupSelectFile;
        private System.Windows.Forms.Button btnSelectPackage;
        private System.Windows.Forms.TextBox txtPackageUrl;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.GroupBox groupFinalPackage;
        private System.Windows.Forms.LinkLabel linkFinalPackgeDirectory;
        private System.Windows.Forms.OpenFileDialog openFileGetPackage;
        private System.Windows.Forms.Label lblTutorial3;
        private System.Windows.Forms.Label lblTutorial2;
        private System.Windows.Forms.Label lblTutorial1;
        private System.Windows.Forms.Label lblHowTo;
        private System.Windows.Forms.LinkLabel linkDataUtility;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.LinkLabel linkFullCopy;
        private System.Windows.Forms.Label lblTutorial4;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.LinkLabel linkPortalManagement;
        private System.Windows.Forms.LinkLabel linkHelp;
    }
}

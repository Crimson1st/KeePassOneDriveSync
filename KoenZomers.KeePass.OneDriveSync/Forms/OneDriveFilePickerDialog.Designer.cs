﻿namespace KoenZomersKeePassOneDriveSync.Forms
{
    partial class OneDriveFilePickerDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneDriveFilePickerDialog));
            this.MyFilesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FilesTabControl = new System.Windows.Forms.TabControl();
            this.MyFilesTabPage = new System.Windows.Forms.TabPage();
            this.CloudLocationPath = new System.Windows.Forms.TextBox();
            this.CloudLocationPicker = new System.Windows.Forms.ListView();
            this.SharedWithMeTabPage = new System.Windows.Forms.TabPage();
            this.SharedWithMeNotAvailableLabel = new System.Windows.Forms.Label();
            this.SharedWithMeUpButton = new System.Windows.Forms.Button();
            this.SharedWithMePath = new System.Windows.Forms.TextBox();
            this.SharedWithMePicker = new System.Windows.Forms.ListView();
            this.SharedWithMeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshSharedWithMeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToSharedWithMeRootTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoUpSharedWithMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyFilesContextMenu.SuspendLayout();
            this.FilesTabControl.SuspendLayout();
            this.MyFilesTabPage.SuspendLayout();
            this.SharedWithMeTabPage.SuspendLayout();
            this.SharedWithMeContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyFilesContextMenu
            // 
            this.MyFilesContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MyFilesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.GoToRootToolStripMenuItem,
            this.goupToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newFolderToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.MyFilesContextMenu.Name = "ListViewContextMenu";
            this.MyFilesContextMenu.Size = new System.Drawing.Size(239, 190);
            this.MyFilesContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ListViewContextMenu_Opening);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // GoToRootToolStripMenuItem
            // 
            this.GoToRootToolStripMenuItem.Name = "GoToRootToolStripMenuItem";
            this.GoToRootToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.GoToRootToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.GoToRootToolStripMenuItem.Text = "&Go to root";
            this.GoToRootToolStripMenuItem.Click += new System.EventHandler(this.GoToRootToolStripMenuItem_Click);
            // 
            // goupToolStripMenuItem
            // 
            this.goupToolStripMenuItem.Enabled = false;
            this.goupToolStripMenuItem.Name = "goupToolStripMenuItem";
            this.goupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.goupToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.goupToolStripMenuItem.Text = "Go &up";
            this.goupToolStripMenuItem.Click += new System.EventHandler(this.GroupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(235, 6);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.newFolderToolStripMenuItem.Text = "&New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.NewFolderToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.renameToolStripMenuItem.Text = "R&ename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "File");
            this.IconsList.Images.SetKeyName(1, "Folder");
            this.IconsList.Images.SetKeyName(2, "RemoteFolder");
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(663, 614);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(108, 49);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(548, 614);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(108, 49);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpButton.Enabled = false;
            this.UpButton.Location = new System.Drawing.Point(681, 3);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(62, 43);
            this.UpButton.TabIndex = 4;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.EnabledChanged += new System.EventHandler(this.UpButton_EnabledChanged);
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExplanationLabel.Location = new System.Drawing.Point(14, 11);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(686, 23);
            this.ExplanationLabel.TabIndex = 8;
            this.ExplanationLabel.Text = "Select where you want to store the KeePass database. Right click for additional o" +
    "ptions.";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameTextBox.Location = new System.Drawing.Point(106, 623);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(433, 26);
            this.FileNameTextBox.TabIndex = 1;
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            this.FileNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FileNameTextBox_KeyUp);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileNameLabel.Location = new System.Drawing.Point(14, 623);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(87, 28);
            this.FileNameLabel.TabIndex = 9;
            this.FileNameLabel.Text = "Filename:";
            // 
            // FilesTabControl
            // 
            this.FilesTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesTabControl.Controls.Add(this.MyFilesTabPage);
            this.FilesTabControl.Controls.Add(this.SharedWithMeTabPage);
            this.FilesTabControl.Location = new System.Drawing.Point(16, 38);
            this.FilesTabControl.Name = "FilesTabControl";
            this.FilesTabControl.SelectedIndex = 0;
            this.FilesTabControl.Size = new System.Drawing.Size(754, 569);
            this.FilesTabControl.TabIndex = 10;
            this.FilesTabControl.SelectedIndexChanged += new System.EventHandler(this.FilesTabControl_SelectedIndexChanged);
            // 
            // MyFilesTabPage
            // 
            this.MyFilesTabPage.Controls.Add(this.CloudLocationPath);
            this.MyFilesTabPage.Controls.Add(this.CloudLocationPicker);
            this.MyFilesTabPage.Controls.Add(this.UpButton);
            this.MyFilesTabPage.Location = new System.Drawing.Point(4, 29);
            this.MyFilesTabPage.Name = "MyFilesTabPage";
            this.MyFilesTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.MyFilesTabPage.Size = new System.Drawing.Size(746, 536);
            this.MyFilesTabPage.TabIndex = 0;
            this.MyFilesTabPage.Text = "My files";
            this.MyFilesTabPage.UseVisualStyleBackColor = true;
            // 
            // CloudLocationPath
            // 
            this.CloudLocationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloudLocationPath.BackColor = System.Drawing.Color.White;
            this.CloudLocationPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CloudLocationPath.Location = new System.Drawing.Point(10, 15);
            this.CloudLocationPath.Name = "CloudLocationPath";
            this.CloudLocationPath.Size = new System.Drawing.Size(668, 19);
            this.CloudLocationPath.TabIndex = 7;
            this.CloudLocationPath.TabStop = false;
            // 
            // CloudLocationPicker
            // 
            this.CloudLocationPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloudLocationPicker.ContextMenuStrip = this.MyFilesContextMenu;
            this.CloudLocationPicker.HideSelection = false;
            this.CloudLocationPicker.LargeImageList = this.IconsList;
            this.CloudLocationPicker.Location = new System.Drawing.Point(6, 54);
            this.CloudLocationPicker.MultiSelect = false;
            this.CloudLocationPicker.Name = "CloudLocationPicker";
            this.CloudLocationPicker.ShowItemToolTips = true;
            this.CloudLocationPicker.Size = new System.Drawing.Size(736, 470);
            this.CloudLocationPicker.SmallImageList = this.IconsList;
            this.CloudLocationPicker.TabIndex = 1;
            this.CloudLocationPicker.TileSize = new System.Drawing.Size(244, 70);
            this.CloudLocationPicker.UseCompatibleStateImageBehavior = false;
            this.CloudLocationPicker.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.CloudLocationPicker_ItemSelectionChanged);
            this.CloudLocationPicker.DoubleClick += new System.EventHandler(this.CloudLocationPicker_DoubleClick);
            this.CloudLocationPicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CloudLocationPicker_KeyUp);
            // 
            // SharedWithMeTabPage
            // 
            this.SharedWithMeTabPage.Controls.Add(this.SharedWithMeUpButton);
            this.SharedWithMeTabPage.Controls.Add(this.SharedWithMePath);
            this.SharedWithMeTabPage.Controls.Add(this.SharedWithMePicker);
            this.SharedWithMeTabPage.Controls.Add(this.SharedWithMeNotAvailableLabel);
            this.SharedWithMeTabPage.Location = new System.Drawing.Point(4, 29);
            this.SharedWithMeTabPage.Name = "SharedWithMeTabPage";
            this.SharedWithMeTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.SharedWithMeTabPage.Size = new System.Drawing.Size(746, 536);
            this.SharedWithMeTabPage.TabIndex = 1;
            this.SharedWithMeTabPage.Text = "Shared with me";
            this.SharedWithMeTabPage.UseVisualStyleBackColor = true;
            // 
            // SharedWithMeNotAvailableLabel
            // 
            this.SharedWithMeNotAvailableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SharedWithMeNotAvailableLabel.Location = new System.Drawing.Point(6, 54);
            this.SharedWithMeNotAvailableLabel.Name = "SharedWithMeNotAvailableLabel";
            this.SharedWithMeNotAvailableLabel.Size = new System.Drawing.Size(732, 471);
            this.SharedWithMeNotAvailableLabel.TabIndex = 10;
            this.SharedWithMeNotAvailableLabel.Text = "Shared with me is not available when using the OneDrive for Business service. Use" +
    " the Graph API service instead to connect to your OneDrive for Business site and" +
    " it will be available.";
            this.SharedWithMeNotAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SharedWithMeUpButton
            // 
            this.SharedWithMeUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SharedWithMeUpButton.Enabled = false;
            this.SharedWithMeUpButton.Location = new System.Drawing.Point(681, 3);
            this.SharedWithMeUpButton.Name = "SharedWithMeUpButton";
            this.SharedWithMeUpButton.Size = new System.Drawing.Size(62, 43);
            this.SharedWithMeUpButton.TabIndex = 9;
            this.SharedWithMeUpButton.Text = "Up";
            this.SharedWithMeUpButton.UseVisualStyleBackColor = true;
            this.SharedWithMeUpButton.Click += new System.EventHandler(this.SharedWithMeUpButton_Click);
            // 
            // SharedWithMePath
            // 
            this.SharedWithMePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SharedWithMePath.BackColor = System.Drawing.Color.White;
            this.SharedWithMePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SharedWithMePath.Location = new System.Drawing.Point(10, 15);
            this.SharedWithMePath.Name = "SharedWithMePath";
            this.SharedWithMePath.Size = new System.Drawing.Size(663, 19);
            this.SharedWithMePath.TabIndex = 8;
            this.SharedWithMePath.TabStop = false;
            // 
            // SharedWithMePicker
            // 
            this.SharedWithMePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SharedWithMePicker.ContextMenuStrip = this.SharedWithMeContextMenu;
            this.SharedWithMePicker.HideSelection = false;
            this.SharedWithMePicker.LargeImageList = this.IconsList;
            this.SharedWithMePicker.Location = new System.Drawing.Point(6, 54);
            this.SharedWithMePicker.MultiSelect = false;
            this.SharedWithMePicker.Name = "SharedWithMePicker";
            this.SharedWithMePicker.ShowItemToolTips = true;
            this.SharedWithMePicker.Size = new System.Drawing.Size(736, 470);
            this.SharedWithMePicker.SmallImageList = this.IconsList;
            this.SharedWithMePicker.TabIndex = 2;
            this.SharedWithMePicker.TileSize = new System.Drawing.Size(244, 70);
            this.SharedWithMePicker.UseCompatibleStateImageBehavior = false;
            this.SharedWithMePicker.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.SharedWithMePicker_ItemSelectionChanged);
            this.SharedWithMePicker.DoubleClick += new System.EventHandler(this.SharedWithMePicker_DoubleClick);
            this.SharedWithMePicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SharedWithMePicker_KeyUp);
            // 
            // SharedWithMeContextMenu
            // 
            this.SharedWithMeContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SharedWithMeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshSharedWithMeFilesToolStripMenuItem,
            this.GoToSharedWithMeRootTtoolStripMenuItem,
            this.GoUpSharedWithMeToolStripMenuItem});
            this.SharedWithMeContextMenu.Name = "ListViewContextMenu";
            this.SharedWithMeContextMenu.Size = new System.Drawing.Size(233, 94);
            this.SharedWithMeContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.SharedWithMeContextMenu_Opening);
            // 
            // RefreshSharedWithMeFilesToolStripMenuItem
            // 
            this.RefreshSharedWithMeFilesToolStripMenuItem.Name = "RefreshSharedWithMeFilesToolStripMenuItem";
            this.RefreshSharedWithMeFilesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RefreshSharedWithMeFilesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.RefreshSharedWithMeFilesToolStripMenuItem.Text = "&Refresh";
            this.RefreshSharedWithMeFilesToolStripMenuItem.Click += new System.EventHandler(this.RefreshSharedWithMeFilesToolStripMenuItem_Click);
            // 
            // GoToSharedWithMeRootTtoolStripMenuItem
            // 
            this.GoToSharedWithMeRootTtoolStripMenuItem.Name = "GoToSharedWithMeRootTtoolStripMenuItem";
            this.GoToSharedWithMeRootTtoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.GoToSharedWithMeRootTtoolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.GoToSharedWithMeRootTtoolStripMenuItem.Text = "&Go to root";
            this.GoToSharedWithMeRootTtoolStripMenuItem.Click += new System.EventHandler(this.GoToSharedWithMeRootTtoolStripMenuItem_Click);
            // 
            // GoUpSharedWithMeToolStripMenuItem
            // 
            this.GoUpSharedWithMeToolStripMenuItem.Enabled = false;
            this.GoUpSharedWithMeToolStripMenuItem.Name = "GoUpSharedWithMeToolStripMenuItem";
            this.GoUpSharedWithMeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.GoUpSharedWithMeToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.GoUpSharedWithMeToolStripMenuItem.Text = "Go &up";
            this.GoUpSharedWithMeToolStripMenuItem.Click += new System.EventHandler(this.GoUpSharedWithMeToolStripMenuItem_Click);
            // 
            // OneDriveFilePickerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 674);
            this.Controls.Add(this.FilesTabControl);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.ExplanationLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "OneDriveFilePickerDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select location";
            this.Load += new System.EventHandler(this.OneDriveFileSaveAsDialog_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OneDriveFileSaveAsDialog_KeyUp);
            this.MyFilesContextMenu.ResumeLayout(false);
            this.FilesTabControl.ResumeLayout(false);
            this.MyFilesTabPage.ResumeLayout(false);
            this.MyFilesTabPage.PerformLayout();
            this.SharedWithMeTabPage.ResumeLayout(false);
            this.SharedWithMeTabPage.PerformLayout();
            this.SharedWithMeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.ContextMenuStrip MyFilesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.ToolStripMenuItem GoToRootToolStripMenuItem;
        private System.Windows.Forms.Label ExplanationLabel;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goupToolStripMenuItem;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TabControl FilesTabControl;
        private System.Windows.Forms.TabPage MyFilesTabPage;
        private System.Windows.Forms.ListView CloudLocationPicker;
        private System.Windows.Forms.TabPage SharedWithMeTabPage;
        private System.Windows.Forms.ListView SharedWithMePicker;
        private System.Windows.Forms.TextBox CloudLocationPath;
        private System.Windows.Forms.ContextMenuStrip SharedWithMeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem RefreshSharedWithMeFilesToolStripMenuItem;
        private System.Windows.Forms.TextBox SharedWithMePath;
        private System.Windows.Forms.Button SharedWithMeUpButton;
        private System.Windows.Forms.ToolStripMenuItem GoToSharedWithMeRootTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoUpSharedWithMeToolStripMenuItem;
        private System.Windows.Forms.Label SharedWithMeNotAvailableLabel;
    }
}
﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using KoenZomers.KeePass.OneDriveSync;
using KoenZomers.KeePass.OneDriveSync.Enums;

namespace KoenZomersKeePassOneDriveSync
{
    public partial class OneDriveConfigForm : Form
    {
        /// <summary>
        /// Timer that resets any other status back to the default after a few seconds
        /// </summary>
        private readonly Timer _resetStatusTimer;

        /// <summary>
        /// The default status to show
        /// </summary>
        private string _defaultStatus;

        public OneDriveConfigForm()
        {
            InitializeComponent();

            _resetStatusTimer = new Timer {Enabled = false, Interval = 5000 };
            _resetStatusTimer.Tick += (sender, args) => { _resetStatusTimer.Enabled = false; UpdateStatus(_defaultStatus); };
        }

        private void OneDriveConfigForm_Load(object sender, EventArgs e)
        {
            LoadConfigurations();
        }

        /// <summary>
        /// Loads the configurations in the listview
        /// </summary>
        private void LoadConfigurations()
        {
            UpdateStatus("Loading configuration");

            // Clear the existing items
            ConfigurationListView.Items.Clear();

            var configurations = Configuration.PasswordDatabases;

            foreach (var configuration in configurations)
            {
                var configurationItem = new ListViewItem
                {
                    Text = configuration.Key,
                    Tag = configuration
                };
                var doesDatabaseExistLocally = File.Exists(configuration.Key);
                var isRemoteDatabase = Regex.IsMatch(configuration.Key, @".+:[\\/]{2}.+", RegexOptions.IgnoreCase);
                configurationItem.BackColor = doesDatabaseExistLocally ? ConfigurationListView.BackColor : isRemoteDatabase ? Color.Orange : Color.Red;
                configurationItem.ToolTipText = doesDatabaseExistLocally ? "Database has been found" : isRemoteDatabase ? "Database is a remote database which is not supported" : "Database has not been found"; 
                configurationItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "OneDrive", Text = configuration.Value.DoNotSync ? "Not synced" : configuration.Value.OneDriveName });
                configurationItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "CloudStorage", Text = configuration.Value.CloudStorageType.HasValue ? configuration.Value.CloudStorageType.Value.ToString() : configuration.Value.DoNotSync ? "Not in cloud" : CloudStorageType.OneDriveConsumer.ToString() });
                ConfigurationListView.Items.Add(configurationItem);
            }

            _defaultStatus = string.Format("{0} configuration{1} found", ConfigurationListView.Items.Count, ConfigurationListView.Items.Count != 1 ? "s" : "");
            UpdateStatus(_defaultStatus);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfigurationListViewContextItemDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void ConfigurationListViewContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ConfigurationListViewContextItemDelete.Enabled = ConfigurationListView.SelectedItems.Count > 0;
            ConfigurationListViewContextItemViewDetails.Enabled = ConfigurationListView.SelectedItems.Count == 1;
            ConfigurationListViewContextItemOpenFileLocation.Enabled = ConfigurationListView.SelectedItems.Count > 0;
            ConfigurationListViewContextItemSyncNow.Enabled = ConfigurationListView.SelectedItems.Count == 1 && !((KeyValuePair<string, Configuration>)ConfigurationListView.SelectedItems[0].Tag).Value.DoNotSync && KoenZomersKeePassOneDriveSyncExt.Host.Database.IOConnectionInfo.Path.Equals(ConfigurationListView.SelectedItems[0].Text, StringComparison.InvariantCultureIgnoreCase);
            ConfigurationListViewContextItemRenameStorage.Enabled = ConfigurationListView.SelectedItems.Count == 1;
        }

        private void ConfigurationListView_DoubleClick(object sender, EventArgs e)
        {
            ViewDetails();
        }

        private void ConfigurationListViewContextItemViewDetails_Click(object sender, EventArgs e)
        {
            ViewDetails();
        }

        private void DeleteItem()
        {
            if (ConfigurationListView.SelectedItems.Count == 0) return;

            var answer = MessageBox.Show("Are you sure that you wish to delete the OneDrive configuration for the selected KeePass databases? This will NOT delete the actual KeePass database file, just its configuration for the KeeOneDriveSync plugin.", "Confirm removal", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (answer != DialogResult.Yes) return;

            foreach (ListViewItem selectedItem in ConfigurationListView.SelectedItems)
            {
                Configuration.DeleteConfig(((KeyValuePair<string, Configuration>)selectedItem.Tag).Key);
            }

            LoadConfigurations();
        }

        private void ViewDetails()
        {
            if (ConfigurationListView.SelectedItems.Count != 1) return;

            var oneDriveConfigDetailsForm = new OneDriveConfigDetailsForm((KeyValuePair<string, Configuration>)ConfigurationListView.SelectedItems[0].Tag);
            oneDriveConfigDetailsForm.ShowDialog();

            LoadConfigurations();
        }

        private void RenameEntry()
        {
            if (ConfigurationListView.SelectedItems.Count != 1) return;
            var configuration = ((KeyValuePair<string, Configuration>)ConfigurationListView.SelectedItems[0].Tag);

            var renameItemDialog = new Forms.OneDriveRequestInputDialog
            {
                FormTitle = string.Format("Enter new storage name name for {0}", configuration.Value.OneDriveName),
                InputValue = configuration.Value.OneDriveName
            };
            renameItemDialog.ShowDialog(this);
            if (renameItemDialog.DialogResult != DialogResult.OK) return;
            if (renameItemDialog.InputValue == configuration.Value.OneDriveName) return;

            configuration.Value.OneDriveName = renameItemDialog.InputValue;
            Configuration.Save();

            ConfigurationListView.SelectedItems[0].SubItems[1].Text = configuration.Value.OneDriveName;
            UpdateStatus("Storage Name has been changed");
        }

        private async Task SyncNow()
        {
            // Only allow syncing if the database is not marked with the DoNotSync flag
            var configuration = ((KeyValuePair<string, Configuration>)ConfigurationListView.SelectedItems[0].Tag);
            if (configuration.Value.DoNotSync)
            {
                return;
            }

            // Only allow syncing if the currently opened database is the one we're trying to sync
            if(!KoenZomersKeePassOneDriveSyncExt.Host.Database.IOConnectionInfo.Path.Equals(ConfigurationListView.SelectedItems[0].Text, StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }
            
            UpdateStatus("Synchronizing");
            await KeePassDatabase.SyncDatabase(ConfigurationListView.SelectedItems[0].Text, UpdateStatus, true, configuration.Value);
        }

        private async void ConfigurationListViewContextItemSyncNow_Click(object sender, EventArgs e)
        {
            await SyncNow();
        }

        private void UpdateStatus(string message)
        {
            StatusLabel.Text = message;

            // If the status message is not the default message, enable the timer to reset the status back to the default after a few seconds
            if (_defaultStatus != null && message != _defaultStatus)
            {
                _resetStatusTimer.Enabled = true;
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var oneDriveAboutForm = new OneDriveAboutForm();
            oneDriveAboutForm.ShowDialog();
        }

        private void ConfigurationListView_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ViewDetails();
                    break;

                case Keys.Delete:
                    DeleteItem();
                    break;

                case Keys.F5:
                    LoadConfigurations();
                    break;

                case Keys.F2:
                    RenameEntry();
                    break;
            }
        }

        private void ConfigurationListViewContextItemOpenFileLocation_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in ConfigurationListView.SelectedItems)
            {
                // Get the full local path of the selected KeePass database configuration
                var databaseFileLocation = ((KeyValuePair<string, Configuration>)selectedItem.Tag).Key;

                // Open File Explorer and make it directly jump to the KeePass database if it exists, if not, just open the explorer to the folder
                Process.Start("explorer.exe", File.Exists(databaseFileLocation) ? string.Concat("/select, ", databaseFileLocation) : Directory.GetParent(databaseFileLocation).FullName);
            }
        }

        private void ConfigurationListViewContextItemRenameStorage_Click(object sender, EventArgs e)
        {
            RenameEntry();
        }
    }
}

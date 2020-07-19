using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Onova;
using Onova.Models;
using Sunny.UI;

namespace OpenYeeLightUI.Forms
{
    public partial class UpdateForm : UIForm
    {
        private CheckForUpdatesResult _updateResult;
        private UpdateManager _updateManager;
        private string changeLogUrl;

        public UpdateForm(CheckForUpdatesResult updateResult, UpdateManager updateManager)
        {
            InitializeComponent();
            _updateResult = updateResult;
            _updateManager = updateManager;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            NewVersionLabel.Text += _updateResult.LastVersion;
            YourVersionLabel.Text += Application.ProductVersion;
            changeLogUrl = $"https://github.com/EthemAcar-Dev/OpenYeeLight/releases/tag/{_updateResult.LastVersion}";
        }

        private void ChangelogLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(changeLogUrl);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateButton.Text = "Updating";
            UpdateButton.Enabled = false;
            PerformUpdate();
        }

        private async void PerformUpdate()
        {
            await _updateManager.CheckPerformUpdateAsync();
        }
    }
}
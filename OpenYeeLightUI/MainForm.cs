using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nucs.JsonSettings;
using Onova;
using Onova.Models;
using Onova.Services;
using OpenYeeLightUI.Classes;
using OpenYeeLightUI.Forms;
using OpenYeeLightUI.Pages;
using Sunny.UI;
using YeelightAPI;

namespace OpenYeeLightUI
{
    public partial class MainForm : UIAsideMainFrame
    {
        private TreeNode _lightsMainNode;
        public UINavMenu FormAside;
        private readonly MySettings _settings = JsonSettings.Load<MySettings>();

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
            {
                ShowWindow();
            }
            base.WndProc(ref message);
        }

        public void ShowWindow()
        {
            // Insert code here to make your form show itself.
            WinApi.ShowToFront(this.Handle);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private async Task Loader()
        {
            _lightsMainNode.Nodes.Clear();
            var devices = await DeviceLocator.DiscoverAsync();
            foreach (Device device in devices.OrderBy(m => m.Name))
            {
                Guid pageGuid = Guid.NewGuid();

                Aside.Invoke((MethodInvoker)delegate ()
                {
                    Aside.CreateChildNode(_lightsMainNode, AddPage(new LightPage(
                        new DeviceViewModel
                        {
                            Device = device,
                            Hostname = device.Hostname,
                            Name = device.Name,
                            IsOn = device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString(),
                            PageGuid = pageGuid
                        }), pageGuid));
                });
            }
            Aside.Invoke((MethodInvoker)delegate ()
            {
                Aside.SelectFirst();
            });

            _lightsMainNode.Expand();
        }

        private async void Updater()
        {
            using (var manager = new UpdateManager(
                new GithubPackageResolver("EthemAcar-Dev", "OpenYeeLight", "*.zip"),
                new ZipPackageExtractor()))
            {
                CheckForUpdatesResult update = await manager.CheckForUpdatesAsync();
                if (update.CanUpdate && _settings.AppSettings.AskForUpdates)
                {
                    UpdateForm updateForm = new UpdateForm(update, manager);
                    updateForm.ShowDialog();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_settings.AppSettings == null)
            {
                _settings.AppSettings = new AppSettings() { AskForUpdates = true, MulticastLookup = false };
                _settings.Save();
            }

            if (_settings.Profiles == null)
            {
                _settings.Profiles = new List<Profile>();
                _settings.Save();
            }

            UILocalizeHelper.SetEN();
            Opacity = 0;
            Text = $"{Text} - {Application.ProductVersion}";
            Updater();

            _lightsMainNode = Aside.CreateNode("Lights", 61451, 24, 1000);
            FormAside = Aside;
            _ = Loader();
        }

        private void RefreshLightsButton_Click(object sender, EventArgs e)
        {
            NotifyUser(RefreshLightsButton, "Searching for lights");
            _ = Loader();
        }

        private void NotifyUser(Control control, string information)
        {
            Point controlLoc = this.PointToScreen(control.Location);
            controlLoc.X = controlLoc.X + (control.Width / 2) + 20;
            controlLoc.Y += 15;
            UIMessageTip.ShowOk(information, point: controlLoc);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.AppSettings = _settings.AppSettings;
            settingsForm.ShowDialog();

            if (settingsForm.IsOK)
            {
                _settings.AppSettings = settingsForm.AppSettings;
                _settings.Save();
                NotifyUser(RefreshLightsButton, "Settings saved");
            }

            settingsForm.Dispose();
        }
    }
}
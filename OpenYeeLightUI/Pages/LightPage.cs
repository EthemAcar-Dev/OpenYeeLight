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
using OpenYeeLightUI.Classes;
using Sunny.UI;

namespace OpenYeeLightUI.Pages
{
    public sealed partial class LightPage : UITitlePage
    {
        private readonly MySettings _settings = JsonSettings.Load<MySettings>();
        private DeviceViewModel _deviceViewModel;
        private bool _isColour = false;

        public LightPage(DeviceViewModel deviceViewModel)
        {
            InitializeComponent();

            _deviceViewModel = deviceViewModel;
            _deviceViewModel.Name = _settings.AppSettings.Base64 && Base64Util.IsBase64(_deviceViewModel.Name) ? Base64Util.Base64Decode(_deviceViewModel.Name) : _deviceViewModel.Name;
            Text = _deviceViewModel.ToString();

            LightBulbIndicator.State = _deviceViewModel.IsOn == "on" ? UILightState.On : UILightState.Off;
        }

        private async void TurnOnButton_Click(object sender, EventArgs e)
        {
            NotifyUser(TurnOnButton, "Turning on");
            FlashBulb();
            await Yeelight.TurnOnAsync(_deviceViewModel.Device, SmoothnessTrackBar.Value * 10);
            UpdateBulbState();
        }

        private async void TurnOffButton_Click(object sender, EventArgs e)
        {
            NotifyUser(TurnOffButton, "Turning off");

            FlashBulb();
            await Yeelight.TurnOffAsync(_deviceViewModel.Device, SmoothnessTrackBar.Value * 10);
            UpdateBulbState();
        }

        private async void ToggleButton_Click(object sender, EventArgs e)
        {
            NotifyUser(ToggleButton, "Toggling");

            FlashBulb();
            await Yeelight.ToggleAsync(_deviceViewModel.Device);
            UpdateBulbState();
        }

        private void NotifyUser(Control control, string information)
        {
            Point controlLoc = this.PointToScreen(control.Location);
            controlLoc.X = controlLoc.X + (control.Width / 2) + 10;
            controlLoc.Y += 60;
            UIMessageTip.ShowOk(information, point: controlLoc);
        }

        private void FlashBulb()
        {
            LightBulbIndicator.State = UILightState.Blink;
        }

        private void UpdateBulbState()
        {
            _deviceViewModel.IsOn = _deviceViewModel.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString();
            LightBulbIndicator.State = _deviceViewModel.IsOn == "on" ? UILightState.On : UILightState.Off;
            Text = _deviceViewModel.ToString();
            MainForm mainForm = (MainForm)this.Parent.Parent.Parent;
            TreeNode firstNode = mainForm.FormAside.Nodes[0]; // Lights
            List<TreeNode> subNodesList = firstNode.Nodes.Cast<TreeNode>().ToList(); // Lights sub nodes to list.

            List<NavMenuItem> lightTab = (from t in subNodesList
                                          let ts = t.Tag as NavMenuItem
                                          where ts.PageGuid == _deviceViewModel.PageGuid
                                          select ts).ToList();

            var node = subNodesList.FirstOrDefault(m => m.Tag == lightTab.FirstOrDefault());
            if (node != null)
            {
                node.Text = _deviceViewModel.ToString();
            }
        }

        private void BrightnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            BrightnessProcentLabel.Text = $"{BrightnessTrackBar.Value}%";
        }

        private void BrightnessTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            SetBrightness();
        }

        private void SetBrightness()
        {
            if (_deviceViewModel.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString() == "off")
            {
                _ = Yeelight.TurnOnAsync(_deviceViewModel.Device);
            }
            _ = Yeelight.SetBrightnessAsync(_deviceViewModel.Device, BrightnessTrackBar.Value, SmoothnessTrackBar.Value * 10);
        }

        private void TemperatureTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TemperatureProcentLabel.Text = $"{TemperatureTrackBar.Value}K";
        }

        private void TemperatureTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            SetTemperature();
        }

        private void SetTemperature()
        {
            if (_deviceViewModel.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString() == "off")
            {
                _ = Yeelight.TurnOnAsync(_deviceViewModel.Device);
            }
            _ = Yeelight.SetColorTemperatureAsync(_deviceViewModel.Device, TemperatureTrackBar.Value, SmoothnessTrackBar.Value * 10);
            _isColour = false;
        }

        private void SmoothnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            SmoothnessProcentLabel.Text = $"{SmoothnessTrackBar.Value}0ms";
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://thirdparty.yeelight.com/topics/244/openyeelight");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/EthemAcar-Dev/OpenYeeLight/issues");
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=VCG3B576LENZ4&source=url");
        }

        private void ColorPickerComboBox_ValueChanged(object sender, Color value)
        {
            SetColor();
        }

        private void SetColor()
        {
            if (_deviceViewModel.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString() == "off")
            {
                _ = Yeelight.TurnOnAsync(_deviceViewModel.Device, SmoothnessTrackBar.Value * 10);
            }
            _ = Yeelight.SetRGBAsync(_deviceViewModel.Device, ColorPickerComboBox.Value, SmoothnessTrackBar.Value * 10);
            _isColour = true;
        }

        private void SetInformationTextBox()
        {
            InformationTextBox.Text = $"Name : {_deviceViewModel.Name}{Environment.NewLine}" +
                                      $"Hostname : {_deviceViewModel.Device.Hostname}{Environment.NewLine}" +
                                      $"ID : {_deviceViewModel.Device.Id}{Environment.NewLine}" +
                                      $"Firmware version : {_deviceViewModel.Device.FirmwareVersion}{Environment.NewLine}" +
                                      $"Model : {_deviceViewModel.Device.Model}";
        }

        private void LightPage_Load(object sender, EventArgs e)
        {
            SetInformationTextBox();

            BrightnessTrackBar.Value = int.Parse(_deviceViewModel.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.bright.ToString()).Value.ToString());
            TemperatureTrackBar.Value = int.Parse(_deviceViewModel.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.ct.ToString()).Value.ToString());
            int color = int.Parse(_deviceViewModel.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.rgb.ToString()).Value.ToString());
            Color colorRgb = Color.FromArgb(color);
            Color colorArgb = Color.FromArgb(255, colorRgb.R, colorRgb.G, colorRgb.B);
            ColorPickerComboBox.Value = colorArgb;

            LoadProfiles();
        }

        private void LoadProfiles()
        {
            ProfileComboBox.Text = "";
            ProfileComboBox.Items.Clear();
            foreach (var profile in _settings.Profiles)
            {
                ProfileComboBox.Items.Add(profile);
            }
        }

        private void NewProfileButton_Click(object sender, EventArgs e)
        {
            string value = "";
            if (this.InputStringDialog(ref value, true, "Profile name:"))
            {
                _settings.Profiles.Add(new Profile() { Name = value, Key = Guid.NewGuid() });
                _settings.Save();
                LoadProfiles();
                NotifyProfile(NewProfileButton, "Profile added", true);
            }
        }

        private void NotifyProfile(Control control, string information, bool isOk)

        {
            Point controlLoc = this.PointToScreen(control.Location);
            controlLoc.X = controlLoc.X + (control.Width / 2) + 10;
            controlLoc.Y += 160;
            if (isOk)
            {
                UIMessageTip.ShowOk(information, point: controlLoc);
            }
            else
            {
                UIMessageTip.ShowWarning(information, point: controlLoc);
            }
        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            var profile = (Profile)ProfileComboBox.SelectedItem;
            if (profile == null)
            {
                NotifyProfile(SaveProfileButton, "No profile selected", false);
                return;
            }
            var updatingProfile = _settings.Profiles.FirstOrDefault(m => m.Key == profile.Key);
            if (updatingProfile == null)
            {
                NotifyProfile(SaveProfileButton, "No profile selected", false);
                return;
            }
            updatingProfile.Brightness = BrightnessTrackBar.Value;
            updatingProfile.Smoothness = SmoothnessTrackBar.Value;
            updatingProfile.Temperature = TemperatureTrackBar.Value;
            updatingProfile.Blue = ColorPickerComboBox.Value.B;
            updatingProfile.Red = ColorPickerComboBox.Value.R;
            updatingProfile.Green = ColorPickerComboBox.Value.G;
            updatingProfile.IsColour = _isColour;
            _settings.Save();
            NotifyProfile(SaveProfileButton, "Profile saved", true);
        }

        private void NewDeleteProfile_Click(object sender, EventArgs e)
        {
            var profile = (Profile)ProfileComboBox.SelectedItem;
            if (profile == null)
            {
                NotifyProfile(NewDeleteProfile, "No profile selected", false);
                return;
            }
            var updatingProfile = _settings.Profiles.FirstOrDefault(m => m.Key == profile.Key);
            if (updatingProfile == null)
            {
                NotifyProfile(NewDeleteProfile, "No profile selected", false);
                return;
            }
            _settings.Profiles.Remove(updatingProfile);
            _settings.Save();
            LoadProfiles();
            NotifyProfile(NewDeleteProfile, "Profile deleted", true);
        }

        private void ProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profile currentProfile = (Profile)ProfileComboBox.SelectedItem;
            SmoothnessTrackBar.Value = currentProfile.Smoothness;
            BrightnessTrackBar.Value = currentProfile.Brightness;
            TemperatureTrackBar.Value = currentProfile.Temperature;
            ColorPickerComboBox.Value = Color.FromArgb(255, currentProfile.Red, currentProfile.Green, currentProfile.Blue);
            SetBrightness();
            if (currentProfile.IsColour)
            {
                SetColor();
            }
            else
            {
                SetTemperature();
            }
        }

        private async void SetNameButton_Click(object sender, EventArgs e)
        {
            string value = "";
            if (this.InputStringDialog(ref value, true, "Light name:"))
            {
                if (_settings.AppSettings.Base64)
                {
                    value = Base64Util.Base64Encode(value);
                }
                await Yeelight.SetNameAsync(_deviceViewModel.Device, value);

                _deviceViewModel.Name = value;

                _deviceViewModel.IsOn = _deviceViewModel.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString();

                _deviceViewModel.Name = _settings.AppSettings.Base64 && Base64Util.IsBase64(_deviceViewModel.Name) ? Base64Util.Base64Decode(_deviceViewModel.Name) : _deviceViewModel.Name;

                Text = _deviceViewModel.ToString();

                MainForm mainForm = (MainForm)this.Parent.Parent.Parent;
                TreeNode firstNode = mainForm.FormAside.Nodes[0]; // Lights
                List<TreeNode> subNodesList = firstNode.Nodes.Cast<TreeNode>().ToList(); // Lights sub nodes to list.

                List<NavMenuItem> lightTab = (from t in subNodesList
                                              let ts = t.Tag as NavMenuItem
                                              where ts.PageGuid == _deviceViewModel.PageGuid
                                              select ts).ToList();

                var node = subNodesList.FirstOrDefault(m => m.Tag == lightTab.FirstOrDefault());
                if (node != null)
                {
                    node.Text = _deviceViewModel.ToString();
                }

                SetInformationTextBox();
                NotifyUser(SetNameButton, "Light name set");
            }
        }
    }
}
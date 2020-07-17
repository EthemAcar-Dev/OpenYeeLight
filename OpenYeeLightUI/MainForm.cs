// Created by Ethem Acar
using ComponentFactory.Krypton.Toolkit;
using nucs.JsonSettings;
using Onova;
using Onova.Models;
using Onova.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace OpenYeeLightUI
{
    public partial class MainForm : KryptonForm
    {
        private BtsForm _btsForm;
        private readonly MySettings _settings = JsonSettings.Load<MySettings>();
        private bool _isColour = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitComponents();
            Updater();
            _ = Loader();
        }

        private void InitComponents()
        {
            this.Text = $"{this.Text} - {Application.ProductVersion}";
            BrightnessLabel.Values.ExtraText = $"{BrightnessTrackbar.Value.ToString()}%";
            TemperatureLabel.Values.ExtraText = $"{TemperatureTrackBar.Value.ToString()}K";
            SmoothnessLabel.Values.ExtraText = $"{SmoothnessTrackBar.Value.ToString()}0MS";

            _btsForm = new BtsForm(this);

            HeaderPanel.Visible = false;
            SplitContainer2.Visible = false;
            if (_settings.Profiles == null)
                _settings.Profiles = new List<Profile>();
            LoadSettings();
        }

        private void LoadSettings()
        {
            if (_settings.Profiles == null) return;
            ProfileComboBox.ComboBox.Items.Clear();
            foreach (var profile in _settings.Profiles)
            {
                ProfileComboBox.ComboBox.Items.Add(profile);
            }
        }

        private void SaveSetting(string name)
        {
            _settings.Profiles.Add(new Profile() { Name = name, Key = Guid.NewGuid() });
            _settings.Save();
        }

        private DeviceViewModel _lastSelectedLight;

        private async Task Loader()
        {
            DevicesLabel.Invoke((MethodInvoker)delegate ()
            {
                DevicesLabel.Values.ExtraText = "0";
            });

            LightsListBox.ListBox.Invoke((MethodInvoker)delegate ()
            {
                LightsListBox.ListBox.Items.Clear();
            });

            DeviceLocator.UseAllAvailableMulticastAddresses = MulticastCheckBox.Checked;

            var devices = await DeviceLocator.DiscoverAsync();
            foreach (Device device in devices)
            {
                LightsListBox.ListBox.Invoke((MethodInvoker)delegate ()
                {
                    LightsListBox.ListBox.Items.Add(new DeviceViewModel { Device = device, Hostname = device.Hostname, Name = device.Name, IsOn = device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString() });
                });
            }

            if (_lastSelectedLight != null)
            {
                LightsListBox.ListBox.Invoke((MethodInvoker)delegate ()
                {
                    for (var i = 0; i < LightsListBox.ListBox.Items.Count; i++)
                    {
                        object lightItem = LightsListBox.ListBox.Items[i];
                        int index = LightsListBox.ListBox.Items.IndexOf(lightItem);
                        DeviceViewModel viewModelItem = (DeviceViewModel)lightItem;
                        if (viewModelItem.Hostname == _lastSelectedLight.Hostname)
                        {
                            LightsListBox.ListBox.SetSelected(index, true);
                        }
                    }
                });
            }
            DevicesLabel.Invoke((MethodInvoker)delegate ()
            {
                DevicesLabel.Values.ExtraText = LightsListBox.ListBox.Items.Count.ToString();
            });
        }

        private async void Updater()
        {
            using (var manager = new UpdateManager(
                new GithubPackageResolver("EthemAcar-Dev", "OpenYeeLight", "*.zip"),
                new ZipPackageExtractor()))
            {
                CheckForUpdatesResult update = await manager.CheckForUpdatesAsync();
                if (update.CanUpdate)
                {
                    UpdateForm updateForm = new UpdateForm(update, manager);
                    updateForm.ShowDialog();
                }
            }
        }

        private void BrightnessTrackbar_ValueChanged(object sender, EventArgs e)
        {
            BrightnessLabel.Values.ExtraText = $"{BrightnessTrackbar.Value.ToString()}%";
        }

        private void TemperatureTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TemperatureLabel.Values.ExtraText = $"{TemperatureTrackBar.Value.ToString()}K";
        }

        private void SmoothnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            SmoothnessLabel.Values.ExtraText = $"{SmoothnessTrackBar.Value.ToString()}0MS";
        }

        private void TurnOnLight_Click(object sender, EventArgs e)
        {
            foreach (DeviceViewModel selectedItem in LightsListBox.CheckedItems)
            {
                _ = Yeelight.TurnOnAsync(selectedItem.Device, SmoothnessTrackBar.Value * 10);
            }
        }

        private void TurnOffLight_Click(object sender, EventArgs e)
        {
            foreach (DeviceViewModel selectedItem in LightsListBox.CheckedItems)
            {
                _ = Yeelight.TurnOffAsync(selectedItem.Device, SmoothnessTrackBar.Value * 10);
            }
        }

        private void ToggleLight_Click(object sender, EventArgs e)
        {
            foreach (DeviceViewModel selectedItem in LightsListBox.CheckedItems)
            {
                _ = Yeelight.ToggleAsync(selectedItem.Device);
            }
        }

        private void ColourWheelAll_Click(object sender, EventArgs e)
        {
            foreach (DeviceViewModel selectedItem in LightsListBox.CheckedItems)
            {
                if (selectedItem.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString() == "off")
                {
                    _ = Yeelight.TurnOnAsync(selectedItem.Device, SmoothnessTrackBar.Value * 10);
                }
                _ = Yeelight.SetRGBAsync(selectedItem.Device,
                    new RGB
                    {
                        Red = ColourWheelAll.Colour.R,
                        Green = ColourWheelAll.Colour.G,
                        Blue = ColourWheelAll.Colour.B
                    }, SmoothnessTrackBar.Value * 10);
            }
        }

        private bool _isAllSelected;

        private void CheckAllLight_Click(object sender, EventArgs e)
        {
            _isAllSelected = !_isAllSelected;

            for (int item = 0; item < LightsListBox.ListBox.Items.Count; item++)
            {
                LightsListBox.SetItemChecked(item, _isAllSelected);
            }

            CheckAllLight.Text = _isAllSelected ? "Uncheck All" : "Check All";
        }

        private void BTSLight_Click(object sender, EventArgs e)
        {
            _btsForm.Show();
            _btsForm.Focus();
        }

        private void SelectedLightsCheckerTimer_Tick(object sender, EventArgs e)
        {
            if (LightsListBox.CheckedItems.Count > 0)
            {
                BasicsLightGroup.Visible = true;
            }
            else
            {
                BasicsLightGroup.Visible = false;
            }
        }

        private void RefreshLight_Click(object sender, EventArgs e)
        {
            _ = Loader();
        }

        private DeviceViewModel _currentDevice = null;

        private void LightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lastSelectedLight = (DeviceViewModel)LightsListBox.ListBox.SelectedItem;
            _currentDevice = (DeviceViewModel)LightsListBox.ListBox.SelectedItem;
            HeaderPanel.Visible = true;
            SplitContainer2.Visible = true;
            LightName.Text = _currentDevice.Name;
            DetailsText.Text = $"Name : {_currentDevice.Device.Name}{Environment.NewLine}" +
                               $"Hostname : {_currentDevice.Device.Hostname}{Environment.NewLine}" +
                               $"ID : {_currentDevice.Device.Id}{Environment.NewLine}" +
                               $"Firmware version : {_currentDevice.Device.FirmwareVersion}{Environment.NewLine}" +
                               $"Model : {_currentDevice.Device.Model}";

            BrightnessTrackbar.Value = int.Parse(_currentDevice.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.bright.ToString()).Value.ToString());
            TemperatureTrackBar.Value = int.Parse(_currentDevice.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.ct.ToString()).Value.ToString());
            int color = int.Parse(_currentDevice.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.rgb.ToString()).Value.ToString());
            ColourWheel.Colour = Color.FromArgb(color);
        }

        private void SaveLightName_Click(object sender, EventArgs e)
        {
            SaveLightName.Enabled = ButtonEnabled.False;
            _ = SaveAndReloadAsync();
        }

        private async Task SaveAndReloadAsync()
        {
            await Yeelight.SetNameAsync(_currentDevice.Device, LightName.Text);
            await Loader();
            SaveLightName.Enabled = ButtonEnabled.True;
        }

        private bool _trackbarMouseDown = false;
        private bool _trackbarScrolling = false;

        private void BrightnessTrackbar_Scroll(object sender, EventArgs e)
        {
            _trackbarScrolling = true;
        }

        private void BrightnessTrackbar_MouseDown(object sender, MouseEventArgs e)
        {
            _trackbarMouseDown = true;
        }

        private void SetBrightness()
        {
            if (_currentDevice.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString() == "off")
            {
                _ = Yeelight.TurnOnAsync(_currentDevice.Device);
            }
            _ = Yeelight.SetBrightnessAsync(_currentDevice.Device, BrightnessTrackbar.Value, SmoothnessTrackBar.Value * 10);
        }

        private void BrightnessTrackbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (_trackbarMouseDown == true && _trackbarScrolling == true)
            {
                SetBrightness();
            }
            _trackbarMouseDown = false;
            _trackbarScrolling = false;
        }

        private void TemperatureTrackBar_Scroll(object sender, EventArgs e)
        {
            _trackbarScrolling = true;
        }

        private void TemperatureTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            _trackbarMouseDown = true;
        }

        private void SetTemperature()
        {
            if (_currentDevice.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString() == "off")
            {
                _ = Yeelight.TurnOnAsync(_currentDevice.Device);
            }
            _ = Yeelight.SetColorTemperatureAsync(_currentDevice.Device, TemperatureTrackBar.Value, SmoothnessTrackBar.Value * 10);
            _isColour = false;
        }

        private void TemperatureTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (_trackbarMouseDown == true && _trackbarScrolling == true)
            {
                SetTemperature();
            }
            _trackbarMouseDown = false;
            _trackbarScrolling = false;
        }

        private void SetColour()
        {
            if (_currentDevice.Device.Properties.FirstOrDefault(m => m.Key == "power").Value.ToString() == "off")
            {
                _ = Yeelight.TurnOnAsync(_currentDevice.Device, SmoothnessTrackBar.Value * 10);
            }
            _ = Yeelight.SetRGBAsync(_currentDevice.Device,
                new RGB
                {
                    Red = ColourWheel.Colour.R,
                    Green = ColourWheel.Colour.G,
                    Blue = ColourWheel.Colour.B
                }, SmoothnessTrackBar.Value * 10);
        }

        private void ColourWheel_Click(object sender, EventArgs e)
        {
            SetColour();
            _isColour = true;
        }

        private async void TurnOn_Click(object sender, EventArgs e)
        {
            Enabled = false;
            foreach (DeviceViewModel selectedItem in LightsListBox.SelectedItems)
            {
                await Yeelight.TurnOnAsync(selectedItem.Device, SmoothnessTrackBar.Value * 10);
            }

            await Loader();
            Enabled = true;
        }

        private async void TurnOff_Click(object sender, EventArgs e)
        {
            Enabled = false;
            foreach (DeviceViewModel selectedItem in LightsListBox.SelectedItems)
            {
                await Yeelight.TurnOffAsync(selectedItem.Device, SmoothnessTrackBar.Value * 10);
            }
            await Loader();
            Enabled = true;
        }

        private async void Toggle_Click(object sender, EventArgs e)
        {
            Enabled = false;
            foreach (DeviceViewModel selectedItem in LightsListBox.SelectedItems)
            {
                await Yeelight.ToggleAsync(selectedItem.Device);
            }
            await Loader();
            Enabled = true;
        }

        private void ProfileGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentDevice != null)
            {
                Profile currentProfile = (Profile)ProfileComboBox.ComboBox.SelectedItem;
                SmoothnessTrackBar.Value = currentProfile.Smoothness;
                BrightnessTrackbar.Value = currentProfile.Brightness;
                TemperatureTrackBar.Value = currentProfile.Temperature;
                ColourWheel.Colour = Color.FromArgb(currentProfile.Red, currentProfile.Green, currentProfile.Blue);
                SetBrightness();
                if (currentProfile.IsColour)
                {
                    SetColour();
                }
                else
                {
                    SetTemperature();
                }
            }
        }

        public string ShowDialog(string text, string caption)
        {
            KryptonForm prompt = new KryptonForm()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            KryptonLabel textLabel = new KryptonLabel() { Left = 35, Top = 10, Text = text };
            KryptonTextBox textBox = new KryptonTextBox() { Left = 40, Top = 40, Width = 400 };
            KryptonButton confirmation = new KryptonButton() { Text = "Add profile", Left = 340, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void NewProfile_Click(object sender, EventArgs e)
        {
            var messageBox = ShowDialog("Profile name", "Profile name");
            SaveSetting(messageBox);
            LoadSettings();
        }

        private void SaveProfile_Click(object sender, EventArgs e)
        {
            var profile = (Profile)ProfileComboBox.ComboBox.SelectedItem;
            var updatingProfile = _settings.Profiles.FirstOrDefault(m => m.Key == profile.Key);
            if (updatingProfile == null) return;
            updatingProfile.Brightness = BrightnessTrackbar.Value;
            updatingProfile.Smoothness = SmoothnessTrackBar.Value;
            updatingProfile.Temperature = TemperatureTrackBar.Value;
            updatingProfile.Blue = ColourWheel.Colour.B;
            updatingProfile.Red = ColourWheel.Colour.R;
            updatingProfile.Green = ColourWheel.Colour.G;
            updatingProfile.IsColour = _isColour;
            _settings.Save();
        }

        private void DeleteProfile_Click(object sender, EventArgs e)
        {
            var profile = (Profile)ProfileComboBox.ComboBox.SelectedItem;
            var updatingProfile = _settings.Profiles.FirstOrDefault(m => m.Key == profile.Key);
            if (updatingProfile == null) return;
            _settings.Profiles.Remove(updatingProfile);
            _settings.Save();
            LoadSettings();
        }
    }
}
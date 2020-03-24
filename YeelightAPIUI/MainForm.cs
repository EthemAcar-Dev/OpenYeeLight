using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace YeelightAPIUI
{
    public partial class MainForm : KryptonForm
    {
        private BtsForm btsForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitComponents();
            _ = Loader();
        }

        private void InitComponents()
        {
            BrightnessLabel.Values.ExtraText = $"{BrightnessTrackbar.Value.ToString()}%";
            TemperatureLabel.Values.ExtraText = $"{TemperatureTrackBar.Value.ToString()}K";
            SmoothnessLabel.Values.ExtraText = $"{SmoothnessTrackBar.Value.ToString()}0MS";

            btsForm = new BtsForm(this);

            Panel1.Visible = false;
            SplitContainer2.Visible = false;
        }

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

            List<Device> devices = await DeviceLocator.Discover();
            foreach (Device device in devices)
            {
                LightsListBox.ListBox.Invoke((MethodInvoker)delegate ()
                {
                    LightsListBox.ListBox.Items.Add(new DeviceViewModel { Device = device, Hostname = device.Hostname, Name = device.Name });
                });
            }

            DevicesLabel.Invoke((MethodInvoker)delegate ()
            {
                DevicesLabel.Values.ExtraText = LightsListBox.ListBox.Items.Count.ToString();
            });
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
                _ = Yeelight.TurnOnAsync(selectedItem.Device, Properties.Settings.Default.Smoothness * 10);
            }
        }

        private void TurnOffLight_Click(object sender, EventArgs e)
        {
            foreach (DeviceViewModel selectedItem in LightsListBox.CheckedItems)
            {
                _ = Yeelight.TurnOffAsync(selectedItem.Device, Properties.Settings.Default.Smoothness * 10);
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
                if (selectedItem.Device.Properties.Where(m => m.Key == "power").FirstOrDefault().Value.ToString() == "off")
                {
                    _ = Yeelight.TurnOnAsync(selectedItem.Device, Properties.Settings.Default.Smoothness * 10);
                }
                _ = Yeelight.SetRGBAsync(selectedItem.Device,
                    new RGB
                    {
                        Red = ColourWheelAll.Colour.R,
                        Green = ColourWheelAll.Colour.G,
                        Blue = ColourWheelAll.Colour.B
                    }, Properties.Settings.Default.Smoothness * 10);
            }
        }

        private bool isAllSelected;

        private void SelectAllLight_Click(object sender, EventArgs e)
        {
            isAllSelected = !isAllSelected;

            for (int item = 0; item < LightsListBox.ListBox.Items.Count; item++)
            {
                LightsListBox.SetItemChecked(item, isAllSelected);
            }

            SelectAllLight.Text = isAllSelected ? "Unselect All" : "Select All";
        }

        private void BTSLight_Click(object sender, EventArgs e)
        {
            btsForm.Show();
            btsForm.Focus();
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

        private DeviceViewModel currentDevice = null;

        private void LightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDevice = (DeviceViewModel)LightsListBox.ListBox.SelectedItem;
            Panel1.Visible = true;
            SplitContainer2.Visible = true;
            LightName.Text = currentDevice.Name;
            DetailsText.Text = $"Name : {currentDevice.Device.Name}{Environment.NewLine}" +
                               $"Hostname : {currentDevice.Device.Hostname}{Environment.NewLine}" +
                               $"ID : {currentDevice.Device.Id}{Environment.NewLine}" +
                               $"Firmware version : {currentDevice.Device.FirmwareVersion}{Environment.NewLine}" +
                               $"Model : {currentDevice.Device.Model}";

            BrightnessTrackbar.Value = int.Parse(currentDevice.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.bright.ToString()).Value.ToString());
            TemperatureTrackBar.Value = int.Parse(currentDevice.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.ct.ToString()).Value.ToString());
            int color = int.Parse(currentDevice.Device.Properties.FirstOrDefault(m => m.Key == YeelightAPI.Models.PROPERTIES.rgb.ToString()).Value.ToString());
            ColourWheel.Colour = Color.FromArgb(color);
        }

        private void SaveLightName_Click(object sender, EventArgs e)
        {
            SaveLightName.Enabled = ButtonEnabled.False;
            _ = SaveAndReloadAsync();
        }

        private async Task SaveAndReloadAsync()
        {
            await Yeelight.SetNameAsync(currentDevice.Device, LightName.Text);
            await Loader();
            SaveLightName.Enabled = ButtonEnabled.True;
        }

        private bool trackbarMouseDown = false;
        private bool trackbarScrolling = false;

        private void BrightnessTrackbar_Scroll(object sender, EventArgs e)
        {
            trackbarScrolling = true;
        }

        private void BrightnessTrackbar_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarMouseDown = true;
        }

        private void BrightnessTrackbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarMouseDown == true && trackbarScrolling == true)
            {
                if (currentDevice.Device.Properties.Where(m => m.Key == "power").FirstOrDefault().Value.ToString() == "off")
                {
                    _ = Yeelight.TurnOnAsync(currentDevice.Device);
                }
                _ = Yeelight.SetBrightnessAsync(currentDevice.Device, BrightnessTrackbar.Value, Properties.Settings.Default.Smoothness * 10);
            }
            trackbarMouseDown = false;
            trackbarScrolling = false;
        }

        private void TemperatureTrackBar_Scroll(object sender, EventArgs e)
        {
            trackbarScrolling = true;
        }

        private void TemperatureTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarMouseDown = true;
        }

        private void TemperatureTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarMouseDown == true && trackbarScrolling == true)
            {
                if (currentDevice.Device.Properties.Where(m => m.Key == "power").FirstOrDefault().Value.ToString() == "off")
                {
                    _ = Yeelight.TurnOnAsync(currentDevice.Device);
                }
                _ = Yeelight.SetColorTemperatureAsync(currentDevice.Device, TemperatureTrackBar.Value, Properties.Settings.Default.Smoothness * 10);
            }
            trackbarMouseDown = false;
            trackbarScrolling = false;
        }

        private void ColourWheel_Click(object sender, EventArgs e)
        {
            if (currentDevice.Device.Properties.Where(m => m.Key == "power").FirstOrDefault().Value.ToString() == "off")
            {
                _ = Yeelight.TurnOnAsync(currentDevice.Device, Properties.Settings.Default.Smoothness * 10);
            }
            _ = Yeelight.SetRGBAsync(currentDevice.Device,
                new RGB
                {
                    Red = ColourWheel.Colour.R,
                    Green = ColourWheel.Colour.G,
                    Blue = ColourWheel.Colour.B
                }, Properties.Settings.Default.Smoothness * 10);
        }
    }
}
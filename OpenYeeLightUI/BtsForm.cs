using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace OpenYeeLightUI
{
    public partial class BtsForm : KryptonForm
    {
        private MainForm _mainForm;
        public BtsForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void BtsForm_Load(object sender, EventArgs e)
        {
            BrightnessTrackbar.Value = Properties.Settings.Default.Brightness;
            TemperatureTrackBar.Value = Properties.Settings.Default.Temperature;
            SmoothnessTrackBar.Value = Properties.Settings.Default.Smoothness;
            BrightnessLabel.Values.ExtraText = $"{BrightnessTrackbar.Value.ToString()}%";
            TemperatureLabel.Values.ExtraText = $"{TemperatureTrackBar.Value.ToString()}K";
            SmoothnessLabel.Values.ExtraText = $"{SmoothnessTrackBar.Value.ToString()}0MS";
        }

        private void BrightnessTrackbar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Brightness = BrightnessTrackbar.Value;
            BrightnessLabel.Values.ExtraText = $"{BrightnessTrackbar.Value.ToString()}%";
            Properties.Settings.Default.Save();
        }

        private void TemperatureTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Temperature = TemperatureTrackBar.Value;
            TemperatureLabel.Values.ExtraText = $"{TemperatureTrackBar.Value.ToString()}K";
            Properties.Settings.Default.Save();
        }

        private void SmoothnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Smoothness = SmoothnessTrackBar.Value;
            SmoothnessLabel.Values.ExtraText = $"{SmoothnessTrackBar.Value.ToString()}0MS";
            Properties.Settings.Default.Save();
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
                foreach (DeviceViewModel selectedItem in _mainForm.LightsListBox.CheckedItems)
                {
                    if (selectedItem.Device.Properties.Where(m => m.Key == "power").FirstOrDefault().Value.ToString() == "off")
                    {
                        _ = Yeelight.TurnOnAsync(selectedItem.Device);
                    }
                    _ = Yeelight.SetBrightnessAsync(selectedItem.Device, BrightnessTrackbar.Value, Properties.Settings.Default.Smoothness * 10);
                }
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
                foreach (DeviceViewModel selectedItem in _mainForm.LightsListBox.CheckedItems)
                {
                    if (selectedItem.Device.Properties.Where(m => m.Key == "power").FirstOrDefault().Value.ToString() == "off")
                    {
                        _ = Yeelight.TurnOnAsync(selectedItem.Device);
                    }
                    _ = Yeelight.SetColorTemperatureAsync(selectedItem.Device, TemperatureTrackBar.Value, Properties.Settings.Default.Smoothness * 10);
                }
            }
            trackbarMouseDown = false;
            trackbarScrolling = false;
        }

        private void BtsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}

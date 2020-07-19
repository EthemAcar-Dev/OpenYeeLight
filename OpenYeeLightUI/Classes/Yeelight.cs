// Created by Ethem Acar

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace OpenYeeLightUI.Classes
{
    public static class Yeelight
    {
        public static async Task TurnOnAsync(Device device, int? smooth = null)
        {
            if (!device.IsConnected) await device.Connect();

            bool success = true, globalSuccess = true;
            int delay = 1500;
            await Try(async () =>
            {
                success = await device.SetPower(true, smooth);
                globalSuccess &= success;
                await Task.Delay(delay);
            });
        }

        public static async Task TurnOffAsync(Device device, int? smooth = null)
        {
            if (!device.IsConnected) await device.Connect();

            bool success = true, globalSuccess = true;
            int delay = 1500;
            await Try(async () =>
            {
                success = await device.SetPower(false, smooth);
                globalSuccess &= success;
                await Task.Delay(delay);
            });
        }

        public static async Task ToggleAsync(Device device)
        {
            if (!device.IsConnected) await device.Connect();

            bool success = true, globalSuccess = true;
            int delay = 1500;
            await Try(async () =>
            {
                success = await device.Toggle();
                globalSuccess &= success;
                await Task.Delay(delay);
            });
        }

        public static async Task SetRGBAsync(Device device, Color color, int? smooth = null)
        {
            if (!device.IsConnected) await device.Connect();

            bool success = true, globalSuccess = true;
            int delay = 1500;
            await Try(async () =>
            {
                success = await device.SetRGBColor(color.R, color.G, color.B, smooth);
                globalSuccess &= success;
                await Task.Delay(delay);
            });
        }

        public static async Task SetBrightnessAsync(Device device, int brightness, int? smooth = null)
        {
            if (!device.IsConnected) await device.Connect();

            bool success = true, globalSuccess = true;
            int delay = 1500;
            await Try(async () =>
            {
                success = await device.SetBrightness(brightness, smooth);
                globalSuccess &= success;
                await Task.Delay(delay);
            });
        }

        public static async Task SetColorTemperatureAsync(Device device, int temperature, int? smooth = null)
        {
            if (!device.IsConnected) await device.Connect();

            bool success = true, globalSuccess = true;
            int delay = 1500;
            await Try(async () =>
            {
                success = await device.SetColorTemperature(temperature, smooth);
                globalSuccess &= success;
                await Task.Delay(delay);
            });
        }

        public static async Task SetNameAsync(Device device, string name)
        {
            if (!device.IsConnected) await device.Connect();

            bool success = true, globalSuccess = true;
            int delay = 1500;
            await Try(async () =>
            {
                success = await device.SetName(name);
                globalSuccess &= success;
                await Task.Delay(delay);
            });
        }

        public static async Task Try(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
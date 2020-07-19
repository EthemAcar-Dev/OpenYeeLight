// Created by Ethem Acar

using System;
using YeelightAPI;

namespace OpenYeeLightUI.Classes
{
    public class DeviceViewModel
    {
        public Device Device;
        public string Name;
        public string Hostname;
        public string IsOn;
        public Guid PageGuid;

        public override string ToString()
        {
            return $"{Name} - {IsOn}";
        }
    }
}
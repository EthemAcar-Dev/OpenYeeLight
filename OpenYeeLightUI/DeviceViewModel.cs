// Created by Ethem Acar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeelightAPI;

namespace OpenYeeLightUI
{
    public class DeviceViewModel
    {
        public Device Device;
        public string Name;
        public string Hostname;
        public string IsOn;

        public override string ToString()
        {
            return $"{Name} - {IsOn}";
        }
    }
}
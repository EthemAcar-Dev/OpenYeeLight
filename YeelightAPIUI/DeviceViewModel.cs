using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeelightAPI;

namespace YeelightAPIUI
{
    public class DeviceViewModel
    {
        public Device Device;
        public string Name;
        public string Hostname;

        public override string ToString()
        { return Name; }
    }
}

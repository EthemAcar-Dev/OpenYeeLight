using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenYeeLightUI.Classes
{
    public class AppSettings
    {
        public bool MulticastLookup { get; set; } = false;
        public bool AskForUpdates { get; set; } = true;

        public bool Base64 { get; set; } = false;
    }
}
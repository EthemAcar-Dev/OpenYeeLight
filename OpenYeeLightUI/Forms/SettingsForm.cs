using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenYeeLightUI.Classes;
using Sunny.UI;

namespace OpenYeeLightUI.Forms
{
    public partial class SettingsForm : UIEditForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
        }

        private AppSettings _appSettings;

        public AppSettings AppSettings
        {
            get
            {
                if (_appSettings == null)
                {
                    _appSettings = new AppSettings();
                }

                _appSettings.MulticastLookup = MulticastEnabled.Checked;
                _appSettings.AskForUpdates = AskForUpdatesEnabled.Checked;
                _appSettings.Base64 = Base64Enabled.Checked;

                return _appSettings;
            }

            set
            {
                _appSettings = value;
                _appSettings.MulticastLookup = value.MulticastLookup;
                _appSettings.AskForUpdates = value.AskForUpdates;
                _appSettings.Base64 = value.Base64;

                if (value.MulticastLookup)
                {
                    MulticastEnabled.Checked = value.MulticastLookup;
                }
                else
                {
                    MulticastDisabled.Checked = !value.MulticastLookup;
                }

                if (value.AskForUpdates)
                {
                    AskForUpdatesEnabled.Checked = value.AskForUpdates;
                }
                else
                {
                    AskForUpdatesDisabled.Checked = !value.AskForUpdates;
                }

                if (value.Base64)
                {
                    Base64Enabled.Checked = value.Base64;
                }
                else
                {
                    Base64Disabled.Checked = !value.Base64;
                }
            }
        }
    }
}
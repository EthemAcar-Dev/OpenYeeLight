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
using System.Diagnostics;
using System.Management;

namespace OpenYeeLightUI
{
    public partial class TaskForm : KryptonForm
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private  void LoadProcesses()
        {
            var query = "SELECT ProcessId, Name, ExecutablePath FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(query))
            using (var results = searcher.Get())
            {
                var processes = results.Cast<ManagementObject>().Select(x => new
                {
                    ProcessId = (UInt32)x["ProcessId"],
                    Name = (string)x["Name"],
                    ExecutablePath = (string)x["ExecutablePath"]
                });
                foreach (var p in processes.DistinctBy(m=>m.Name))
                {
                    if (System.IO.File.Exists(p.ExecutablePath) && !p.ExecutablePath.Contains("rundll32.exe") && !p.ExecutablePath.Contains(@"C:\Windows\SystemApps\"))
                    {
                        
                        var icon = Icon.ExtractAssociatedIcon(p.ExecutablePath);
                        var key = p.ProcessId.ToString();
                       
                        imageList.Images.Add(key, icon.ToBitmap());
                        ProcessList.Items.Add(p.Name, key);
                    }
                }
            }
           
        }
    }
}

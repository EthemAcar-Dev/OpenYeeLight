// Created by Ethem Acar
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nucs.JsonSettings;

namespace OpenYeeLightUI
{
    public class MySettings : JsonSettings
    {
        public override string FileName { get; set; } = "settings.json"; //for loading and saving.

        public List<Profile> Profiles { get; set; }

        public MySettings()
        {
        }

        public MySettings(string fileName) : base(fileName)
        {
        }
    }
}
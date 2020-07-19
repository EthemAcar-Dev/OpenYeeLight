// Created by Ethem Acar

using System.Collections.Generic;
using nucs.JsonSettings;

namespace OpenYeeLightUI.Classes
{
    public class MySettings : JsonSettings
    {
        public override string FileName { get; set; } = "settings.json"; //for loading and saving.

        public AppSettings AppSettings { get; set; } = new AppSettings() { AskForUpdates = true, MulticastLookup = false };
        public List<Profile> Profiles { get; set; }

        public MySettings()
        {
        }

        public MySettings(string fileName) : base(fileName)
        {
        }
    }
}
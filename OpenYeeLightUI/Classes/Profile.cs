// Created by Ethem Acar

using System;

namespace OpenYeeLightUI.Classes
{
    public class Profile
    {
        public string Name { get; set; }
        public int Brightness { get; set; } = 1;
        public int Temperature { get; set; } = 1700;
        public int Smoothness { get; set; } = 1;
        public int Red { get; set; } = 1;
        public int Green { get; set; } = 1;
        public int Blue { get; set; } = 1;
        public Guid Key { get; set; }
        public bool IsColour { get; set; } = false;

        public override string ToString()
        {
            return Name;
        }
    }
}
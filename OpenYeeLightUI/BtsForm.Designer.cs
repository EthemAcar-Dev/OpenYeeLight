namespace OpenYeeLightUI
{
    partial class BtsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BtsForm));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.BrightnessLabel = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.BrightnessTrackbar = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.TemperatureLabel = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.TemperatureTrackBar = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.SmoothnessLabel = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.SmoothnessTrackBar = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office365Black;
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrightnessLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrightnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.BrightnessLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.BrightnessLabel.Location = new System.Drawing.Point(0, -1);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(551, 29);
            this.BrightnessLabel.TabIndex = 24;
            this.BrightnessLabel.Values.Text = "Brightness";
            // 
            // BrightnessTrackbar
            // 
            this.BrightnessTrackbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrightnessTrackbar.DrawBackground = true;
            this.BrightnessTrackbar.LargeChange = 0;
            this.BrightnessTrackbar.Location = new System.Drawing.Point(0, 28);
            this.BrightnessTrackbar.Maximum = 100;
            this.BrightnessTrackbar.Minimum = 1;
            this.BrightnessTrackbar.Name = "BrightnessTrackbar";
            this.BrightnessTrackbar.Size = new System.Drawing.Size(551, 34);
            this.BrightnessTrackbar.SmallChange = 0;
            this.BrightnessTrackbar.StateCommon.Position.Color1 = System.Drawing.Color.Transparent;
            this.BrightnessTrackbar.StateCommon.Tick.Color1 = System.Drawing.Color.White;
            this.BrightnessTrackbar.StateCommon.Tick.Color2 = System.Drawing.Color.Transparent;
            this.BrightnessTrackbar.StateCommon.Tick.Color3 = System.Drawing.Color.Transparent;
            this.BrightnessTrackbar.StateCommon.Tick.Color4 = System.Drawing.Color.Transparent;
            this.BrightnessTrackbar.StateCommon.Tick.Color5 = System.Drawing.Color.Transparent;
            this.BrightnessTrackbar.StateCommon.Track.Color1 = System.Drawing.Color.Transparent;
            this.BrightnessTrackbar.StateNormal.Tick.Color1 = System.Drawing.Color.White;
            this.BrightnessTrackbar.StatePressed.Position.Color1 = System.Drawing.Color.Transparent;
            this.BrightnessTrackbar.StatePressed.Position.Color2 = System.Drawing.Color.Magenta;
            this.BrightnessTrackbar.StateTracking.Position.Color1 = System.Drawing.Color.Transparent;
            this.BrightnessTrackbar.StateTracking.Position.Color2 = System.Drawing.Color.Magenta;
            this.BrightnessTrackbar.TabIndex = 19;
            this.BrightnessTrackbar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.BrightnessTrackbar.TrackBarSize = ComponentFactory.Krypton.Toolkit.PaletteTrackBarSize.Large;
            this.BrightnessTrackbar.Value = 1;
            this.BrightnessTrackbar.ValueChanged += new System.EventHandler(this.BrightnessTrackbar_ValueChanged);
            this.BrightnessTrackbar.Scroll += new System.EventHandler(this.BrightnessTrackbar_Scroll);
            this.BrightnessTrackbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrightnessTrackbar_MouseDown);
            this.BrightnessTrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightnessTrackbar_MouseUp);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TemperatureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.TemperatureLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.TemperatureLabel.Location = new System.Drawing.Point(0, 62);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(551, 29);
            this.TemperatureLabel.TabIndex = 23;
            this.TemperatureLabel.Values.Text = "Temperature";
            // 
            // TemperatureTrackBar
            // 
            this.TemperatureTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TemperatureTrackBar.DrawBackground = true;
            this.TemperatureTrackBar.LargeChange = 0;
            this.TemperatureTrackBar.Location = new System.Drawing.Point(0, 91);
            this.TemperatureTrackBar.Maximum = 6500;
            this.TemperatureTrackBar.Minimum = 1700;
            this.TemperatureTrackBar.Name = "TemperatureTrackBar";
            this.TemperatureTrackBar.Size = new System.Drawing.Size(551, 34);
            this.TemperatureTrackBar.SmallChange = 0;
            this.TemperatureTrackBar.StateCommon.Position.Color1 = System.Drawing.Color.Transparent;
            this.TemperatureTrackBar.StateCommon.Tick.Color1 = System.Drawing.Color.White;
            this.TemperatureTrackBar.StateCommon.Tick.Color2 = System.Drawing.Color.Transparent;
            this.TemperatureTrackBar.StateCommon.Tick.Color3 = System.Drawing.Color.Transparent;
            this.TemperatureTrackBar.StateCommon.Tick.Color4 = System.Drawing.Color.Transparent;
            this.TemperatureTrackBar.StateCommon.Tick.Color5 = System.Drawing.Color.Transparent;
            this.TemperatureTrackBar.StateCommon.Track.Color1 = System.Drawing.Color.Transparent;
            this.TemperatureTrackBar.StateNormal.Tick.Color1 = System.Drawing.Color.White;
            this.TemperatureTrackBar.StatePressed.Position.Color1 = System.Drawing.Color.Transparent;
            this.TemperatureTrackBar.StatePressed.Position.Color2 = System.Drawing.Color.Magenta;
            this.TemperatureTrackBar.StateTracking.Position.Color1 = System.Drawing.Color.Transparent;
            this.TemperatureTrackBar.StateTracking.Position.Color2 = System.Drawing.Color.Magenta;
            this.TemperatureTrackBar.TabIndex = 22;
            this.TemperatureTrackBar.TickFrequency = 10;
            this.TemperatureTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TemperatureTrackBar.TrackBarSize = ComponentFactory.Krypton.Toolkit.PaletteTrackBarSize.Large;
            this.TemperatureTrackBar.Value = 1700;
            this.TemperatureTrackBar.ValueChanged += new System.EventHandler(this.TemperatureTrackBar_ValueChanged);
            this.TemperatureTrackBar.Scroll += new System.EventHandler(this.TemperatureTrackBar_Scroll);
            this.TemperatureTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TemperatureTrackBar_MouseDown);
            this.TemperatureTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TemperatureTrackBar_MouseUp);
            // 
            // SmoothnessLabel
            // 
            this.SmoothnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.SmoothnessLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SmoothnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.SmoothnessLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.SmoothnessLabel.Location = new System.Drawing.Point(0, 125);
            this.SmoothnessLabel.Name = "SmoothnessLabel";
            this.SmoothnessLabel.Size = new System.Drawing.Size(551, 29);
            this.SmoothnessLabel.TabIndex = 21;
            this.SmoothnessLabel.Values.Text = "Smoothness";
            // 
            // SmoothnessTrackBar
            // 
            this.SmoothnessTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SmoothnessTrackBar.DrawBackground = true;
            this.SmoothnessTrackBar.LargeChange = 0;
            this.SmoothnessTrackBar.Location = new System.Drawing.Point(0, 154);
            this.SmoothnessTrackBar.Maximum = 100;
            this.SmoothnessTrackBar.Minimum = 1;
            this.SmoothnessTrackBar.Name = "SmoothnessTrackBar";
            this.SmoothnessTrackBar.Size = new System.Drawing.Size(551, 34);
            this.SmoothnessTrackBar.SmallChange = 0;
            this.SmoothnessTrackBar.StateCommon.Position.Color1 = System.Drawing.Color.Transparent;
            this.SmoothnessTrackBar.StateCommon.Tick.Color1 = System.Drawing.Color.White;
            this.SmoothnessTrackBar.StateCommon.Tick.Color2 = System.Drawing.Color.Transparent;
            this.SmoothnessTrackBar.StateCommon.Tick.Color3 = System.Drawing.Color.Transparent;
            this.SmoothnessTrackBar.StateCommon.Tick.Color4 = System.Drawing.Color.Transparent;
            this.SmoothnessTrackBar.StateCommon.Tick.Color5 = System.Drawing.Color.Transparent;
            this.SmoothnessTrackBar.StateCommon.Track.Color1 = System.Drawing.Color.Transparent;
            this.SmoothnessTrackBar.StateNormal.Tick.Color1 = System.Drawing.Color.White;
            this.SmoothnessTrackBar.StatePressed.Position.Color1 = System.Drawing.Color.Transparent;
            this.SmoothnessTrackBar.StatePressed.Position.Color2 = System.Drawing.Color.Magenta;
            this.SmoothnessTrackBar.StateTracking.Position.Color1 = System.Drawing.Color.Transparent;
            this.SmoothnessTrackBar.StateTracking.Position.Color2 = System.Drawing.Color.Magenta;
            this.SmoothnessTrackBar.TabIndex = 20;
            this.SmoothnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.SmoothnessTrackBar.TrackBarSize = ComponentFactory.Krypton.Toolkit.PaletteTrackBarSize.Large;
            this.SmoothnessTrackBar.Value = 1;
            this.SmoothnessTrackBar.ValueChanged += new System.EventHandler(this.SmoothnessTrackBar_ValueChanged);
            // 
            // BtsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(551, 188);
            this.Controls.Add(this.BrightnessLabel);
            this.Controls.Add(this.BrightnessTrackbar);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.TemperatureTrackBar);
            this.Controls.Add(this.SmoothnessLabel);
            this.Controls.Add(this.SmoothnessTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BtsForm";
            this.ShowInTaskbar = false;
            this.Text = "Brightness, Temperature and Smoothness";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BtsForm_FormClosing);
            this.Load += new System.EventHandler(this.BtsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel BrightnessLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar BrightnessTrackbar;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel TemperatureLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar TemperatureTrackBar;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel SmoothnessLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar SmoothnessTrackBar;
    }
}
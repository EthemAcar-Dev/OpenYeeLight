namespace OpenYeeLightUI.Pages
{
    sealed partial class LightPage
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
            this.ControlsGroupBox = new Sunny.UI.UIGroupBox();
            this.ToggleButton = new Sunny.UI.UISymbolButton();
            this.TurnOffButton = new Sunny.UI.UISymbolButton();
            this.TurnOnButton = new Sunny.UI.UISymbolButton();
            this.LightBulbIndicator = new Sunny.UI.UILight();
            this.ColorPickerGroupBox = new Sunny.UI.UIGroupBox();
            this.ColorPickerComboBox = new Sunny.UI.UIColorPicker();
            this.BTSGroupBox = new Sunny.UI.UIGroupBox();
            this.SmoothnessProcentLabel = new Sunny.UI.UILabel();
            this.TemperatureProcentLabel = new Sunny.UI.UILabel();
            this.BrightnessProcentLabel = new Sunny.UI.UILabel();
            this.SmoothnessLabel = new Sunny.UI.UILabel();
            this.SmoothnessTrackBar = new Sunny.UI.UITrackBar();
            this.TemperatureLabel = new Sunny.UI.UILabel();
            this.TemperatureTrackBar = new Sunny.UI.UITrackBar();
            this.BrightnessLabel = new Sunny.UI.UILabel();
            this.BrightnessTrackBar = new Sunny.UI.UITrackBar();
            this.ProfileGroupBox = new Sunny.UI.UIGroupBox();
            this.NewDeleteProfile = new Sunny.UI.UISymbolButton();
            this.NewProfileButton = new Sunny.UI.UISymbolButton();
            this.SaveProfileButton = new Sunny.UI.UISymbolButton();
            this.ProfileComboBox = new Sunny.UI.UIComboBox();
            this.InformationGroupBox = new Sunny.UI.UIGroupBox();
            this.InformationTextBox = new Sunny.UI.UITextBox();
            this.FeedbackButton = new Sunny.UI.UISymbolButton();
            this.ReportButton = new Sunny.UI.UISymbolButton();
            this.DonateButton = new Sunny.UI.UISymbolButton();
            this.SetNameButton = new Sunny.UI.UISymbolButton();
            this.PagePanel.SuspendLayout();
            this.ControlsGroupBox.SuspendLayout();
            this.ColorPickerGroupBox.SuspendLayout();
            this.BTSGroupBox.SuspendLayout();
            this.ProfileGroupBox.SuspendLayout();
            this.InformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.DonateButton);
            this.PagePanel.Controls.Add(this.ReportButton);
            this.PagePanel.Controls.Add(this.FeedbackButton);
            this.PagePanel.Controls.Add(this.InformationGroupBox);
            this.PagePanel.Controls.Add(this.ProfileGroupBox);
            this.PagePanel.Controls.Add(this.BTSGroupBox);
            this.PagePanel.Controls.Add(this.ColorPickerGroupBox);
            this.PagePanel.Controls.Add(this.ControlsGroupBox);
            this.PagePanel.Size = new System.Drawing.Size(657, 550);
            // 
            // ControlsGroupBox
            // 
            this.ControlsGroupBox.Controls.Add(this.SetNameButton);
            this.ControlsGroupBox.Controls.Add(this.ToggleButton);
            this.ControlsGroupBox.Controls.Add(this.TurnOffButton);
            this.ControlsGroupBox.Controls.Add(this.TurnOnButton);
            this.ControlsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ControlsGroupBox.Location = new System.Drawing.Point(13, 8);
            this.ControlsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.ControlsGroupBox.Size = new System.Drawing.Size(631, 82);
            this.ControlsGroupBox.TabIndex = 0;
            this.ControlsGroupBox.Text = "Controls";
            // 
            // ToggleButton
            // 
            this.ToggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ToggleButton.Location = new System.Drawing.Point(337, 35);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ToggleButton.Size = new System.Drawing.Size(156, 35);
            this.ToggleButton.Symbol = 61473;
            this.ToggleButton.TabIndex = 2;
            this.ToggleButton.Text = "Toggle";
            this.ToggleButton.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // TurnOffButton
            // 
            this.TurnOffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnOffButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TurnOffButton.Location = new System.Drawing.Point(175, 35);
            this.TurnOffButton.Name = "TurnOffButton";
            this.TurnOffButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.TurnOffButton.Size = new System.Drawing.Size(156, 35);
            this.TurnOffButton.Symbol = 61926;
            this.TurnOffButton.TabIndex = 1;
            this.TurnOffButton.Text = "Turn off";
            this.TurnOffButton.Click += new System.EventHandler(this.TurnOffButton_Click);
            // 
            // TurnOnButton
            // 
            this.TurnOnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnOnButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TurnOnButton.Location = new System.Drawing.Point(13, 35);
            this.TurnOnButton.Name = "TurnOnButton";
            this.TurnOnButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.TurnOnButton.Size = new System.Drawing.Size(156, 35);
            this.TurnOnButton.Symbol = 61457;
            this.TurnOnButton.TabIndex = 0;
            this.TurnOnButton.Text = "Turn on";
            this.TurnOnButton.Click += new System.EventHandler(this.TurnOnButton_Click);
            // 
            // LightBulbIndicator
            // 
            this.LightBulbIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.LightBulbIndicator.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.LightBulbIndicator.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.LightBulbIndicator.Location = new System.Drawing.Point(619, 3);
            this.LightBulbIndicator.Name = "LightBulbIndicator";
            this.LightBulbIndicator.Radius = 35;
            this.LightBulbIndicator.ShowCenterColor = false;
            this.LightBulbIndicator.ShowLightLine = false;
            this.LightBulbIndicator.Size = new System.Drawing.Size(28, 28);
            this.LightBulbIndicator.TabIndex = 1;
            // 
            // ColorPickerGroupBox
            // 
            this.ColorPickerGroupBox.Controls.Add(this.ColorPickerComboBox);
            this.ColorPickerGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ColorPickerGroupBox.Location = new System.Drawing.Point(13, 198);
            this.ColorPickerGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorPickerGroupBox.Name = "ColorPickerGroupBox";
            this.ColorPickerGroupBox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.ColorPickerGroupBox.Size = new System.Drawing.Size(270, 86);
            this.ColorPickerGroupBox.TabIndex = 1;
            this.ColorPickerGroupBox.Text = "Color";
            // 
            // ColorPickerComboBox
            // 
            this.ColorPickerComboBox.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ColorPickerComboBox.FillColor = System.Drawing.Color.White;
            this.ColorPickerComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ColorPickerComboBox.Location = new System.Drawing.Point(13, 37);
            this.ColorPickerComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorPickerComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.ColorPickerComboBox.Name = "ColorPickerComboBox";
            this.ColorPickerComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ColorPickerComboBox.Size = new System.Drawing.Size(244, 29);
            this.ColorPickerComboBox.TabIndex = 0;
            this.ColorPickerComboBox.Text = "uiColorPicker1";
            this.ColorPickerComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorPickerComboBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ColorPickerComboBox.ValueChanged += new Sunny.UI.UIColorPicker.OnColorChanged(this.ColorPickerComboBox_ValueChanged);
            // 
            // BTSGroupBox
            // 
            this.BTSGroupBox.Controls.Add(this.SmoothnessProcentLabel);
            this.BTSGroupBox.Controls.Add(this.TemperatureProcentLabel);
            this.BTSGroupBox.Controls.Add(this.BrightnessProcentLabel);
            this.BTSGroupBox.Controls.Add(this.SmoothnessLabel);
            this.BTSGroupBox.Controls.Add(this.SmoothnessTrackBar);
            this.BTSGroupBox.Controls.Add(this.TemperatureLabel);
            this.BTSGroupBox.Controls.Add(this.TemperatureTrackBar);
            this.BTSGroupBox.Controls.Add(this.BrightnessLabel);
            this.BTSGroupBox.Controls.Add(this.BrightnessTrackBar);
            this.BTSGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BTSGroupBox.Location = new System.Drawing.Point(291, 198);
            this.BTSGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTSGroupBox.Name = "BTSGroupBox";
            this.BTSGroupBox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.BTSGroupBox.Size = new System.Drawing.Size(353, 218);
            this.BTSGroupBox.TabIndex = 2;
            this.BTSGroupBox.Text = "BTS";
            // 
            // SmoothnessProcentLabel
            // 
            this.SmoothnessProcentLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SmoothnessProcentLabel.Location = new System.Drawing.Point(270, 148);
            this.SmoothnessProcentLabel.Name = "SmoothnessProcentLabel";
            this.SmoothnessProcentLabel.Size = new System.Drawing.Size(80, 21);
            this.SmoothnessProcentLabel.TabIndex = 8;
            this.SmoothnessProcentLabel.Text = "1000MS";
            this.SmoothnessProcentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TemperatureProcentLabel
            // 
            this.TemperatureProcentLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TemperatureProcentLabel.Location = new System.Drawing.Point(293, 89);
            this.TemperatureProcentLabel.Name = "TemperatureProcentLabel";
            this.TemperatureProcentLabel.Size = new System.Drawing.Size(57, 21);
            this.TemperatureProcentLabel.TabIndex = 7;
            this.TemperatureProcentLabel.Text = "1700K";
            this.TemperatureProcentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BrightnessProcentLabel
            // 
            this.BrightnessProcentLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BrightnessProcentLabel.Location = new System.Drawing.Point(299, 32);
            this.BrightnessProcentLabel.Name = "BrightnessProcentLabel";
            this.BrightnessProcentLabel.Size = new System.Drawing.Size(51, 21);
            this.BrightnessProcentLabel.TabIndex = 6;
            this.BrightnessProcentLabel.Text = "100%";
            this.BrightnessProcentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SmoothnessLabel
            // 
            this.SmoothnessLabel.AutoSize = true;
            this.SmoothnessLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SmoothnessLabel.Location = new System.Drawing.Point(3, 148);
            this.SmoothnessLabel.Name = "SmoothnessLabel";
            this.SmoothnessLabel.Size = new System.Drawing.Size(103, 21);
            this.SmoothnessLabel.TabIndex = 5;
            this.SmoothnessLabel.Text = "Smoothness";
            this.SmoothnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SmoothnessTrackBar
            // 
            this.SmoothnessTrackBar.DisableColor = System.Drawing.Color.Silver;
            this.SmoothnessTrackBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SmoothnessTrackBar.Location = new System.Drawing.Point(3, 173);
            this.SmoothnessTrackBar.Minimum = 1;
            this.SmoothnessTrackBar.Name = "SmoothnessTrackBar";
            this.SmoothnessTrackBar.Size = new System.Drawing.Size(347, 29);
            this.SmoothnessTrackBar.TabIndex = 4;
            this.SmoothnessTrackBar.Value = 100;
            this.SmoothnessTrackBar.ValueChanged += new System.EventHandler(this.SmoothnessTrackBar_ValueChanged);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TemperatureLabel.Location = new System.Drawing.Point(3, 89);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(108, 21);
            this.TemperatureLabel.TabIndex = 3;
            this.TemperatureLabel.Text = "Temperature";
            this.TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TemperatureTrackBar
            // 
            this.TemperatureTrackBar.DisableColor = System.Drawing.Color.Silver;
            this.TemperatureTrackBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TemperatureTrackBar.Location = new System.Drawing.Point(3, 114);
            this.TemperatureTrackBar.Maximum = 6500;
            this.TemperatureTrackBar.Minimum = 1700;
            this.TemperatureTrackBar.Name = "TemperatureTrackBar";
            this.TemperatureTrackBar.Size = new System.Drawing.Size(347, 29);
            this.TemperatureTrackBar.TabIndex = 2;
            this.TemperatureTrackBar.Value = 1700;
            this.TemperatureTrackBar.ValueChanged += new System.EventHandler(this.TemperatureTrackBar_ValueChanged);
            this.TemperatureTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TemperatureTrackBar_MouseUp);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BrightnessLabel.Location = new System.Drawing.Point(3, 32);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(89, 21);
            this.BrightnessLabel.TabIndex = 1;
            this.BrightnessLabel.Text = "Brightness";
            this.BrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.DisableColor = System.Drawing.Color.Silver;
            this.BrightnessTrackBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BrightnessTrackBar.Location = new System.Drawing.Point(3, 57);
            this.BrightnessTrackBar.Minimum = 1;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(347, 29);
            this.BrightnessTrackBar.TabIndex = 0;
            this.BrightnessTrackBar.Text = "uiTrackBar1";
            this.BrightnessTrackBar.Value = 100;
            this.BrightnessTrackBar.ValueChanged += new System.EventHandler(this.BrightnessTrackBar_ValueChanged);
            this.BrightnessTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightnessTrackBar_MouseUp);
            // 
            // ProfileGroupBox
            // 
            this.ProfileGroupBox.Controls.Add(this.NewDeleteProfile);
            this.ProfileGroupBox.Controls.Add(this.NewProfileButton);
            this.ProfileGroupBox.Controls.Add(this.SaveProfileButton);
            this.ProfileGroupBox.Controls.Add(this.ProfileComboBox);
            this.ProfileGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ProfileGroupBox.Location = new System.Drawing.Point(13, 100);
            this.ProfileGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfileGroupBox.Name = "ProfileGroupBox";
            this.ProfileGroupBox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.ProfileGroupBox.Size = new System.Drawing.Size(631, 88);
            this.ProfileGroupBox.TabIndex = 3;
            this.ProfileGroupBox.Text = "Profile";
            // 
            // NewDeleteProfile
            // 
            this.NewDeleteProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewDeleteProfile.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.NewDeleteProfile.Location = new System.Drawing.Point(516, 37);
            this.NewDeleteProfile.Name = "NewDeleteProfile";
            this.NewDeleteProfile.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.NewDeleteProfile.Size = new System.Drawing.Size(100, 29);
            this.NewDeleteProfile.Symbol = 61944;
            this.NewDeleteProfile.TabIndex = 3;
            this.NewDeleteProfile.Text = "Delete";
            this.NewDeleteProfile.Click += new System.EventHandler(this.NewDeleteProfile_Click);
            // 
            // NewProfileButton
            // 
            this.NewProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewProfileButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.NewProfileButton.Location = new System.Drawing.Point(410, 37);
            this.NewProfileButton.Name = "NewProfileButton";
            this.NewProfileButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.NewProfileButton.Size = new System.Drawing.Size(100, 29);
            this.NewProfileButton.Symbol = 61543;
            this.NewProfileButton.TabIndex = 2;
            this.NewProfileButton.Text = "New";
            this.NewProfileButton.Click += new System.EventHandler(this.NewProfileButton_Click);
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveProfileButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SaveProfileButton.Location = new System.Drawing.Point(304, 37);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.SaveProfileButton.Size = new System.Drawing.Size(100, 29);
            this.SaveProfileButton.Symbol = 61639;
            this.SaveProfileButton.TabIndex = 1;
            this.SaveProfileButton.Text = "Save";
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ProfileComboBox.FillColor = System.Drawing.Color.White;
            this.ProfileComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ProfileComboBox.Location = new System.Drawing.Point(13, 37);
            this.ProfileComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfileComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ProfileComboBox.Size = new System.Drawing.Size(284, 29);
            this.ProfileComboBox.TabIndex = 0;
            this.ProfileComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfileComboBox_SelectedIndexChanged);
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.InformationTextBox);
            this.InformationGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.InformationGroupBox.Location = new System.Drawing.Point(13, 287);
            this.InformationGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.InformationGroupBox.Size = new System.Drawing.Size(270, 129);
            this.InformationGroupBox.TabIndex = 4;
            this.InformationGroupBox.Text = "Information";
            // 
            // InformationTextBox
            // 
            this.InformationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InformationTextBox.FillColor = System.Drawing.Color.White;
            this.InformationTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationTextBox.Location = new System.Drawing.Point(13, 37);
            this.InformationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InformationTextBox.Maximum = 2147483647D;
            this.InformationTextBox.Minimum = -2147483648D;
            this.InformationTextBox.Multiline = true;
            this.InformationTextBox.Name = "InformationTextBox";
            this.InformationTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.InformationTextBox.ReadOnly = true;
            this.InformationTextBox.Size = new System.Drawing.Size(244, 76);
            this.InformationTextBox.TabIndex = 0;
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FeedbackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.FeedbackButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.FeedbackButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.FeedbackButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.FeedbackButton.Location = new System.Drawing.Point(543, 522);
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.FeedbackButton.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.FeedbackButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.FeedbackButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.FeedbackButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.FeedbackButton.Size = new System.Drawing.Size(114, 28);
            this.FeedbackButton.Style = Sunny.UI.UIStyle.Orange;
            this.FeedbackButton.StyleCustomMode = true;
            this.FeedbackButton.Symbol = 61870;
            this.FeedbackButton.TabIndex = 51;
            this.FeedbackButton.Text = "Feedback";
            this.FeedbackButton.Click += new System.EventHandler(this.FeedbackButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ReportButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.ReportButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.ReportButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ReportButton.Location = new System.Drawing.Point(432, 522);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ReportButton.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.ReportButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ReportButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.ReportButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.ReportButton.Size = new System.Drawing.Size(114, 28);
            this.ReportButton.Style = Sunny.UI.UIStyle.Red;
            this.ReportButton.StyleCustomMode = true;
            this.ReportButton.Symbol = 61553;
            this.ReportButton.TabIndex = 52;
            this.ReportButton.Text = "Issue";
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // DonateButton
            // 
            this.DonateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DonateButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.DonateButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.DonateButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DonateButton.Location = new System.Drawing.Point(318, 522);
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.DonateButton.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.DonateButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DonateButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.DonateButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.DonateButton.Size = new System.Drawing.Size(114, 28);
            this.DonateButton.Style = Sunny.UI.UIStyle.Green;
            this.DonateButton.StyleCustomMode = true;
            this.DonateButton.Symbol = 61444;
            this.DonateButton.TabIndex = 53;
            this.DonateButton.Text = "Donate";
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // SetNameButton
            // 
            this.SetNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetNameButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.SetNameButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.SetNameButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.SetNameButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SetNameButton.Location = new System.Drawing.Point(499, 35);
            this.SetNameButton.Name = "SetNameButton";
            this.SetNameButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.SetNameButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.SetNameButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.SetNameButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.SetNameButton.Size = new System.Drawing.Size(117, 35);
            this.SetNameButton.Style = Sunny.UI.UIStyle.Orange;
            this.SetNameButton.StyleCustomMode = true;
            this.SetNameButton.Symbol = 108;
            this.SetNameButton.TabIndex = 54;
            this.SetNameButton.Text = "Set name";
            this.SetNameButton.Click += new System.EventHandler(this.SetNameButton_Click);
            // 
            // LightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 585);
            this.Controls.Add(this.LightBulbIndicator);
            this.Name = "LightPage";
            this.StyleCustomMode = true;
            this.Symbol = 61675;
            this.Text = "Page";
            this.Load += new System.EventHandler(this.LightPage_Load);
            this.Controls.SetChildIndex(this.PagePanel, 0);
            this.Controls.SetChildIndex(this.LightBulbIndicator, 0);
            this.PagePanel.ResumeLayout(false);
            this.ControlsGroupBox.ResumeLayout(false);
            this.ColorPickerGroupBox.ResumeLayout(false);
            this.BTSGroupBox.ResumeLayout(false);
            this.BTSGroupBox.PerformLayout();
            this.ProfileGroupBox.ResumeLayout(false);
            this.InformationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox ControlsGroupBox;
        private Sunny.UI.UISymbolButton TurnOnButton;
        private Sunny.UI.UISymbolButton ToggleButton;
        private Sunny.UI.UISymbolButton TurnOffButton;
        private Sunny.UI.UILight LightBulbIndicator;
        private Sunny.UI.UIGroupBox BTSGroupBox;
        private Sunny.UI.UIGroupBox ColorPickerGroupBox;
        private Sunny.UI.UILabel SmoothnessLabel;
        private Sunny.UI.UITrackBar SmoothnessTrackBar;
        private Sunny.UI.UILabel TemperatureLabel;
        private Sunny.UI.UITrackBar TemperatureTrackBar;
        private Sunny.UI.UILabel BrightnessLabel;
        private Sunny.UI.UITrackBar BrightnessTrackBar;
        private Sunny.UI.UIGroupBox ProfileGroupBox;
        private Sunny.UI.UIGroupBox InformationGroupBox;
        private Sunny.UI.UITextBox InformationTextBox;
        private Sunny.UI.UIComboBox ProfileComboBox;
        private Sunny.UI.UIColorPicker ColorPickerComboBox;
        private Sunny.UI.UISymbolButton NewDeleteProfile;
        private Sunny.UI.UISymbolButton NewProfileButton;
        private Sunny.UI.UISymbolButton SaveProfileButton;
        private Sunny.UI.UILabel SmoothnessProcentLabel;
        private Sunny.UI.UILabel TemperatureProcentLabel;
        private Sunny.UI.UILabel BrightnessProcentLabel;
        private Sunny.UI.UISymbolButton FeedbackButton;
        private Sunny.UI.UISymbolButton ReportButton;
        private Sunny.UI.UISymbolButton DonateButton;
        private Sunny.UI.UISymbolButton SetNameButton;
    }
}
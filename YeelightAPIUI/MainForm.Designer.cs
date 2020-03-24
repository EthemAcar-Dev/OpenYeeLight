namespace YeelightAPIUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FormManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.Ribbon = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.ActionsTab = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.BasicsLightGroup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.ActionsGroupTripple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.TurnOnLight = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.TurnOffLight = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.ToggleLight = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.SelectedLightsSeperator1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.ActionsGroupTripple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupCustomControl1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCustomControl();
            this.ColourWheelAll = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel();
            this.SelectedLightsSeperator2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.ActionsGroupTripple3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.BTSLight = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.SplitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.LightsListBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.LightsListBoxStrip = new ExtendedControls.ExtendedToolkit.FloatingFramework.Controls.TearOffToolStrip();
            this.SelectAllLight = new System.Windows.Forms.ToolStripButton();
            this.RefreshLight = new System.Windows.Forms.ToolStripButton();
            this.DevicesLabel = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.SplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.ColourWheel = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel();
            this.Panel2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanel();
            this.BrightnessLabel = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.BrightnessTrackbar = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.TemperatureLabel = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.TemperatureTrackBar = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.SmoothnessLabel = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.SmoothnessTrackBar = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.Panel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanel();
            this.DetailsGroupBox = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonGroupBox();
            this.DetailsText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LightName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SaveLightName = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedLightsCheckerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer.Panel1)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer.Panel2)).BeginInit();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.LightsListBoxStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2.Panel1)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2.Panel2)).BeginInit();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.DetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormManager
            // 
            this.FormManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office365Black;
            // 
            // Ribbon
            // 
            this.Ribbon.InDesignHelperMode = true;
            this.Ribbon.Name = "Ribbon";
            this.Ribbon.QATLocation = ComponentFactory.Krypton.Ribbon.QATLocation.Hidden;
            this.Ribbon.RibbonAppButton.AppButtonVisible = false;
            this.Ribbon.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.ActionsTab});
            this.Ribbon.SelectedTab = this.ActionsTab;
            this.Ribbon.ShowMinimizeButton = false;
            this.Ribbon.Size = new System.Drawing.Size(918, 115);
            this.Ribbon.TabIndex = 1;
            // 
            // ActionsTab
            // 
            this.ActionsTab.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.BasicsLightGroup});
            this.ActionsTab.Text = "Actions";
            // 
            // BasicsLightGroup
            // 
            this.BasicsLightGroup.DialogBoxLauncher = false;
            this.BasicsLightGroup.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.ActionsGroupTripple1,
            this.SelectedLightsSeperator1,
            this.ActionsGroupTripple2,
            this.SelectedLightsSeperator2,
            this.ActionsGroupTripple3});
            this.BasicsLightGroup.TextLine1 = "Selected lights";
            // 
            // ActionsGroupTripple1
            // 
            this.ActionsGroupTripple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.TurnOnLight,
            this.TurnOffLight,
            this.ToggleLight});
            // 
            // TurnOnLight
            // 
            this.TurnOnLight.ImageLarge = global::YeelightAPIUI.Properties.Resources._139;
            this.TurnOnLight.TextLine1 = "Turn on";
            this.TurnOnLight.Click += new System.EventHandler(this.TurnOnLight_Click);
            // 
            // TurnOffLight
            // 
            this.TurnOffLight.ImageLarge = global::YeelightAPIUI.Properties.Resources._140;
            this.TurnOffLight.TextLine1 = "Turn off";
            this.TurnOffLight.Click += new System.EventHandler(this.TurnOffLight_Click);
            // 
            // ToggleLight
            // 
            this.ToggleLight.ImageLarge = global::YeelightAPIUI.Properties.Resources._39;
            this.ToggleLight.TextLine1 = "Toggle";
            this.ToggleLight.Click += new System.EventHandler(this.ToggleLight_Click);
            // 
            // ActionsGroupTripple2
            // 
            this.ActionsGroupTripple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupCustomControl1});
            // 
            // kryptonRibbonGroupCustomControl1
            // 
            this.kryptonRibbonGroupCustomControl1.CustomControl = this.ColourWheelAll;
            // 
            // ColourWheelAll
            // 
            this.ColourWheelAll.BackColor = System.Drawing.Color.Transparent;
            this.ColourWheelAll.Location = new System.Drawing.Point(176, 3);
            this.ColourWheelAll.Name = "ColourWheelAll";
            this.ColourWheelAll.Size = new System.Drawing.Size(69, 65);
            this.ColourWheelAll.TabIndex = 6;
            this.ColourWheelAll.TabStop = false;
            this.ColourWheelAll.Click += new System.EventHandler(this.ColourWheelAll_Click);
            // 
            // ActionsGroupTripple3
            // 
            this.ActionsGroupTripple3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.BTSLight});
            // 
            // BTSLight
            // 
            this.BTSLight.ImageLarge = global::YeelightAPIUI.Properties.Resources._135;
            this.BTSLight.TextLine1 = "B, T & S";
            this.BTSLight.Click += new System.EventHandler(this.BTSLight_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 115);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.LightsListBox);
            this.SplitContainer.Panel1.Controls.Add(this.LightsListBoxStrip);
            this.SplitContainer.Panel1.Controls.Add(this.DevicesLabel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer.Panel2.Controls.Add(this.Panel1);
            this.SplitContainer.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.SplitContainer.Size = new System.Drawing.Size(918, 314);
            this.SplitContainer.SplitterDistance = 169;
            this.SplitContainer.SplitterWidth = 10;
            this.SplitContainer.TabIndex = 3;
            // 
            // LightsListBox
            // 
            this.LightsListBox.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.LightsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightsListBox.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.LightsListBox.Location = new System.Drawing.Point(0, 54);
            this.LightsListBox.Name = "LightsListBox";
            this.LightsListBox.Size = new System.Drawing.Size(169, 260);
            this.LightsListBox.TabIndex = 22;
            this.LightsListBox.SelectedIndexChanged += new System.EventHandler(this.LightsListBox_SelectedIndexChanged);
            // 
            // LightsListBoxStrip
            // 
            this.LightsListBoxStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LightsListBoxStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.LightsListBoxStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllLight,
            this.RefreshLight});
            this.LightsListBoxStrip.Location = new System.Drawing.Point(0, 29);
            this.LightsListBoxStrip.Name = "LightsListBoxStrip";
            this.LightsListBoxStrip.Size = new System.Drawing.Size(169, 25);
            this.LightsListBoxStrip.TabIndex = 21;
            // 
            // SelectAllLight
            // 
            this.SelectAllLight.Image = global::YeelightAPIUI.Properties.Resources._523;
            this.SelectAllLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAllLight.Name = "SelectAllLight";
            this.SelectAllLight.Size = new System.Drawing.Size(75, 22);
            this.SelectAllLight.Text = "Select All";
            this.SelectAllLight.Click += new System.EventHandler(this.SelectAllLight_Click);
            // 
            // RefreshLight
            // 
            this.RefreshLight.Image = global::YeelightAPIUI.Properties.Resources._556;
            this.RefreshLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshLight.Name = "RefreshLight";
            this.RefreshLight.Size = new System.Drawing.Size(66, 22);
            this.RefreshLight.Text = "Refresh";
            this.RefreshLight.Click += new System.EventHandler(this.RefreshLight_Click);
            // 
            // DevicesLabel
            // 
            this.DevicesLabel.BackColor = System.Drawing.Color.Transparent;
            this.DevicesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DevicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.DevicesLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.DevicesLabel.Location = new System.Drawing.Point(0, 0);
            this.DevicesLabel.Name = "DevicesLabel";
            this.DevicesLabel.Size = new System.Drawing.Size(169, 29);
            this.DevicesLabel.TabIndex = 19;
            this.DevicesLabel.Values.ExtraText = "0";
            this.DevicesLabel.Values.Text = "Devices";
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 126);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.ColourWheel);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.Panel2);
            this.SplitContainer2.Panel2.Controls.Add(this.SmoothnessLabel);
            this.SplitContainer2.Panel2.Controls.Add(this.SmoothnessTrackBar);
            this.SplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.SplitContainer2.Size = new System.Drawing.Size(739, 188);
            this.SplitContainer2.SplitterDistance = 159;
            this.SplitContainer2.TabIndex = 1;
            // 
            // ColourWheel
            // 
            this.ColourWheel.BackColor = System.Drawing.Color.Transparent;
            this.ColourWheel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColourWheel.Location = new System.Drawing.Point(0, 0);
            this.ColourWheel.Name = "ColourWheel";
            this.ColourWheel.Size = new System.Drawing.Size(159, 188);
            this.ColourWheel.TabIndex = 5;
            this.ColourWheel.Click += new System.EventHandler(this.ColourWheel_Click);
            // 
            // Panel2
            // 
            this.Panel2.BorderWidth = 0;
            this.Panel2.Controls.Add(this.BrightnessLabel);
            this.Panel2.Controls.Add(this.BrightnessTrackbar);
            this.Panel2.Controls.Add(this.TemperatureLabel);
            this.Panel2.Controls.Add(this.TemperatureTrackBar);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Panel2.GradientToogleColours = false;
            this.Panel2.GradientUseBlend = false;
            this.Panel2.GradientUseSolid = true;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.PersistentColours = false;
            this.Panel2.Size = new System.Drawing.Size(575, 125);
            this.Panel2.TabIndex = 12;
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrightnessLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrightnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.BrightnessLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.BrightnessLabel.Location = new System.Drawing.Point(0, -1);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(575, 29);
            this.BrightnessLabel.TabIndex = 18;
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
            this.BrightnessTrackbar.Size = new System.Drawing.Size(575, 34);
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
            this.TemperatureLabel.Size = new System.Drawing.Size(575, 29);
            this.TemperatureLabel.TabIndex = 17;
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
            this.TemperatureTrackBar.Size = new System.Drawing.Size(575, 34);
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
            this.SmoothnessLabel.Size = new System.Drawing.Size(575, 29);
            this.SmoothnessLabel.TabIndex = 11;
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
            this.SmoothnessTrackBar.Size = new System.Drawing.Size(575, 34);
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
            // Panel1
            // 
            this.Panel1.BorderWidth = 0;
            this.Panel1.Controls.Add(this.DetailsGroupBox);
            this.Panel1.Controls.Add(this.LightName);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Panel1.GradientToogleColours = false;
            this.Panel1.GradientUseBlend = false;
            this.Panel1.GradientUseSolid = true;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.PersistentColours = false;
            this.Panel1.Size = new System.Drawing.Size(739, 126);
            this.Panel1.TabIndex = 0;
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.BorderStyle = ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonGroupBox.BorderMode.Full;
            this.DetailsGroupBox.Controls.Add(this.DetailsText);
            this.DetailsGroupBox.DarkerColours = true;
            this.DetailsGroupBox.DrawBottomLine = false;
            this.DetailsGroupBox.DrawShadows = false;
            this.DetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsGroupBox.ForceTransparent = false;
            this.DetailsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DetailsGroupBox.Location = new System.Drawing.Point(275, 0);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.PaintDefault = false;
            this.DetailsGroupBox.Size = new System.Drawing.Size(452, 119);
            this.DetailsGroupBox.TabIndex = 2;
            this.DetailsGroupBox.TabStop = false;
            this.DetailsGroupBox.Text = "Details";
            this.DetailsGroupBox.UseAlternateForeColour = false;
            // 
            // DetailsText
            // 
            this.DetailsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsText.Location = new System.Drawing.Point(3, 22);
            this.DetailsText.Multiline = true;
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.ReadOnly = true;
            this.DetailsText.Size = new System.Drawing.Size(446, 94);
            this.DetailsText.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.DetailsText.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.DetailsText.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DetailsText.StateActive.Content.Color1 = System.Drawing.Color.White;
            this.DetailsText.StateActive.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.DetailsText.StateNormal.Back.Color1 = System.Drawing.Color.Gray;
            this.DetailsText.TabIndex = 0;
            // 
            // LightName
            // 
            this.LightName.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.SaveLightName});
            this.LightName.Location = new System.Drawing.Point(17, 32);
            this.LightName.Name = "LightName";
            this.LightName.Size = new System.Drawing.Size(201, 26);
            this.LightName.TabIndex = 1;
            // 
            // SaveLightName
            // 
            this.SaveLightName.Image = global::YeelightAPIUI.Properties.Resources._967;
            this.SaveLightName.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.SaveLightName.Text = "Save";
            this.SaveLightName.UniqueName = "17de1e3bb09e4fc9b0c4b9f05d724c7b";
            this.SaveLightName.Click += new System.EventHandler(this.SaveLightName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // SelectedLightsCheckerTimer
            // 
            this.SelectedLightsCheckerTimer.Tick += new System.EventHandler(this.SelectedLightsCheckerTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 429);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.Ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(934, 468);
            this.MinimumSize = new System.Drawing.Size(934, 468);
            this.Name = "MainForm";
            this.Text = "Yeelight UI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer.Panel1)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer.Panel2)).EndInit();
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.LightsListBoxStrip.ResumeLayout(false);
            this.LightsListBoxStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2.Panel1)).EndInit();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2.Panel2)).EndInit();
            this.SplitContainer2.Panel2.ResumeLayout(false);
            this.SplitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager FormManager;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon Ribbon;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer SplitContainer;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanel Panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer SplitContainer2;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel ColourWheel;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel SmoothnessLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar SmoothnessTrackBar;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanel Panel2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel TemperatureLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar TemperatureTrackBar;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel BrightnessLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar BrightnessTrackbar;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab ActionsTab;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel DevicesLabel;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup BasicsLightGroup;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple ActionsGroupTripple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton TurnOnLight;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton TurnOffLight;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton ToggleLight;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple ActionsGroupTripple2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCustomControl kryptonRibbonGroupCustomControl1;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel ColourWheelAll;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator SelectedLightsSeperator1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple ActionsGroupTripple3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton BTSLight;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator SelectedLightsSeperator2;
        private ExtendedControls.ExtendedToolkit.FloatingFramework.Controls.TearOffToolStrip LightsListBoxStrip;
        private System.Windows.Forms.ToolStripButton SelectAllLight;
        public ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox LightsListBox;
        private System.Windows.Forms.Timer SelectedLightsCheckerTimer;
        private System.Windows.Forms.ToolStripButton RefreshLight;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox LightName;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny SaveLightName;
        private System.Windows.Forms.Label label1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonGroupBox DetailsGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DetailsText;
    }
}


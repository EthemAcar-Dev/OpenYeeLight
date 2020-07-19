using System;
using System.Drawing;

namespace Sunny.UI
{
    public sealed class UIColorItem : UIDropDownItem
    {
        public UIColorItem()
        {
            InitializeComponent();
        }

        private LabelRotate m_colorSample;
        private UITextBox edtR;
        private UITextBox edtG;
        private UITextBox edtB;
        private UILabel lblR;
        private UILabel lblG;
        private UILabel lblB;
        private UIColorWheel m_colorWheel;
        private HSLColorSlider m_colorBar;
        private UISymbolButton btnOK;
        private UISymbolButton btnCancel;
        private UIColorTable m_colorTable;

        private void InitializeComponent()
        {
            this.m_colorTable = new Sunny.UI.UIColorTable();
            this.m_colorSample = new Sunny.UI.LabelRotate();
            this.edtR = new Sunny.UI.UITextBox();
            this.edtG = new Sunny.UI.UITextBox();
            this.edtB = new Sunny.UI.UITextBox();
            this.lblR = new Sunny.UI.UILabel();
            this.lblG = new Sunny.UI.UILabel();
            this.lblB = new Sunny.UI.UILabel();
            this.m_colorWheel = new Sunny.UI.UIColorWheel();
            this.m_colorBar = new Sunny.UI.HSLColorSlider();
            this.btnOK = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // m_colorTable
            // 
            this.m_colorTable.BackColor = System.Drawing.Color.Transparent;
            this.m_colorTable.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.DarkSlateGray,
        System.Drawing.Color.Purple,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Teal,
        System.Drawing.Color.Green,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.DarkMagenta,
        System.Drawing.Color.DarkBlue,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.DarkOliveGreen,
        System.Drawing.Color.SaddleBrown,
        System.Drawing.Color.ForestGreen,
        System.Drawing.Color.OliveDrab,
        System.Drawing.Color.SeaGreen,
        System.Drawing.Color.DarkGoldenrod,
        System.Drawing.Color.DarkSlateBlue,
        System.Drawing.Color.MediumBlue,
        System.Drawing.Color.Sienna,
        System.Drawing.Color.Brown,
        System.Drawing.Color.DarkTurquoise,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.LightSeaGreen,
        System.Drawing.Color.DarkViolet,
        System.Drawing.Color.Firebrick,
        System.Drawing.Color.MediumVioletRed,
        System.Drawing.Color.MediumSeaGreen,
        System.Drawing.Color.Crimson,
        System.Drawing.Color.Chocolate,
        System.Drawing.Color.MediumSpringGreen,
        System.Drawing.Color.Goldenrod,
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.LawnGreen,
        System.Drawing.Color.DarkOrchid,
        System.Drawing.Color.Orange,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Gold,
        System.Drawing.Color.Red,
        System.Drawing.Color.Magenta,
        System.Drawing.Color.Lime,
        System.Drawing.Color.SpringGreen,
        System.Drawing.Color.YellowGreen,
        System.Drawing.Color.Chartreuse,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.Aqua,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.CadetBlue,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.Gray,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Peru,
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.LightSlateGray,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.MediumTurquoise,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.Turquoise,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.SlateBlue,
        System.Drawing.Color.MediumOrchid,
        System.Drawing.Color.DarkKhaki,
        System.Drawing.Color.IndianRed,
        System.Drawing.Color.GreenYellow,
        System.Drawing.Color.MediumAquamarine,
        System.Drawing.Color.Tomato,
        System.Drawing.Color.DarkSeaGreen,
        System.Drawing.Color.Orchid,
        System.Drawing.Color.RosyBrown,
        System.Drawing.Color.PaleVioletRed,
        System.Drawing.Color.MediumPurple,
        System.Drawing.Color.Coral,
        System.Drawing.Color.CornflowerBlue,
        System.Drawing.Color.DarkGray,
        System.Drawing.Color.SandyBrown,
        System.Drawing.Color.MediumSlateBlue,
        System.Drawing.Color.Tan,
        System.Drawing.Color.DarkSalmon,
        System.Drawing.Color.BurlyWood,
        System.Drawing.Color.HotPink,
        System.Drawing.Color.Salmon,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightCoral,
        System.Drawing.Color.SkyBlue,
        System.Drawing.Color.LightSalmon,
        System.Drawing.Color.Khaki,
        System.Drawing.Color.Plum,
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Aquamarine,
        System.Drawing.Color.Silver,
        System.Drawing.Color.LightSkyBlue,
        System.Drawing.Color.LightSteelBlue,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.PaleGreen,
        System.Drawing.Color.PowderBlue,
        System.Drawing.Color.Thistle,
        System.Drawing.Color.PaleGoldenrod,
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Wheat,
        System.Drawing.Color.NavajoWhite,
        System.Drawing.Color.Moccasin,
        System.Drawing.Color.LightPink,
        System.Drawing.Color.PeachPuff,
        System.Drawing.Color.Gainsboro,
        System.Drawing.Color.Pink,
        System.Drawing.Color.Bisque,
        System.Drawing.Color.LightGoldenrodYellow,
        System.Drawing.Color.LemonChiffon,
        System.Drawing.Color.BlanchedAlmond,
        System.Drawing.Color.Beige,
        System.Drawing.Color.AntiqueWhite,
        System.Drawing.Color.PapayaWhip,
        System.Drawing.Color.Cornsilk,
        System.Drawing.Color.LightYellow,
        System.Drawing.Color.LightCyan,
        System.Drawing.Color.Lavender,
        System.Drawing.Color.Linen,
        System.Drawing.Color.MistyRose,
        System.Drawing.Color.OldLace,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.SeaShell,
        System.Drawing.Color.Azure,
        System.Drawing.Color.Honeydew,
        System.Drawing.Color.Ivory,
        System.Drawing.Color.LavenderBlush,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.MintCream,
        System.Drawing.Color.GhostWhite,
        System.Drawing.Color.Snow,
        System.Drawing.Color.White};
            this.m_colorTable.Cols = 16;
            this.m_colorTable.FieldSize = new System.Drawing.Size(12, 12);
            this.m_colorTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.m_colorTable.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.m_colorTable.Location = new System.Drawing.Point(10, 8);
            this.m_colorTable.Name = "m_colorTable";
            this.m_colorTable.Padding = new System.Windows.Forms.Padding(8);
            this.m_colorTable.RotatePointAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_colorTable.SelectedItem = System.Drawing.Color.Black;
            this.m_colorTable.Size = new System.Drawing.Size(253, 148);
            this.m_colorTable.Style = Sunny.UI.UIStyle.Custom;
            this.m_colorTable.StyleCustomMode = false;
            this.m_colorTable.TabIndex = 0;
            this.m_colorTable.TagString = null;
            this.m_colorTable.Text = "colorTable1";
            this.m_colorTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_colorTable.TextAngle = 0F;
            this.m_colorTable.SelectedIndexChanged += new System.EventHandler(this.m_colorTable_SelectedIndexChanged);
            // 
            // m_colorSample
            // 
            this.m_colorSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.m_colorSample.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.m_colorSample.Location = new System.Drawing.Point(10, 163);
            this.m_colorSample.Name = "m_colorSample";
            this.m_colorSample.RotatePointAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_colorSample.Size = new System.Drawing.Size(56, 26);
            this.m_colorSample.Style = Sunny.UI.UIStyle.Custom;
            this.m_colorSample.StyleCustomMode = false;
            this.m_colorSample.TabIndex = 1;
            this.m_colorSample.TabStop = false;
            this.m_colorSample.TagString = null;
            this.m_colorSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_colorSample.TextAngle = 0F;
            this.m_colorSample.Paint += new System.Windows.Forms.PaintEventHandler(this.m_colorSample_Paint);
            // 
            // edtR
            // 
            this.edtR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtR.FillColor = System.Drawing.Color.White;
            this.edtR.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edtR.HasMaximum = true;
            this.edtR.HasMinimum = true;
            this.edtR.Location = new System.Drawing.Point(90, 163);
            this.edtR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtR.Maximum = 255D;
            this.edtR.Minimum = 0D;
            this.edtR.Name = "edtR";
            this.edtR.Padding = new System.Windows.Forms.Padding(5);
            this.edtR.ReadOnly = true;
            this.edtR.Size = new System.Drawing.Size(41, 26);
            this.edtR.Style = Sunny.UI.UIStyle.Custom;
            this.edtR.TabIndex = 3;
            this.edtR.Text = "0";
            this.edtR.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // edtG
            // 
            this.edtG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtG.FillColor = System.Drawing.Color.White;
            this.edtG.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edtG.HasMaximum = true;
            this.edtG.HasMinimum = true;
            this.edtG.Location = new System.Drawing.Point(155, 163);
            this.edtG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtG.Maximum = 255D;
            this.edtG.Minimum = 0D;
            this.edtG.Name = "edtG";
            this.edtG.Padding = new System.Windows.Forms.Padding(5);
            this.edtG.ReadOnly = true;
            this.edtG.Size = new System.Drawing.Size(41, 26);
            this.edtG.Style = Sunny.UI.UIStyle.Custom;
            this.edtG.TabIndex = 4;
            this.edtG.Text = "0";
            this.edtG.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // edtB
            // 
            this.edtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtB.FillColor = System.Drawing.Color.White;
            this.edtB.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edtB.HasMaximum = true;
            this.edtB.HasMinimum = true;
            this.edtB.Location = new System.Drawing.Point(219, 163);
            this.edtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtB.Maximum = 255D;
            this.edtB.Minimum = 0D;
            this.edtB.Name = "edtB";
            this.edtB.Padding = new System.Windows.Forms.Padding(5);
            this.edtB.ReadOnly = true;
            this.edtB.Size = new System.Drawing.Size(41, 26);
            this.edtB.Style = Sunny.UI.UIStyle.Custom;
            this.edtB.TabIndex = 5;
            this.edtB.Text = "0";
            this.edtB.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.Color.Transparent;
            this.lblR.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblR.Location = new System.Drawing.Point(71, 166);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(18, 20);
            this.lblR.Style = Sunny.UI.UIStyle.Custom;
            this.lblR.TabIndex = 7;
            this.lblR.Text = "R";
            this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.Transparent;
            this.lblG.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblG.Location = new System.Drawing.Point(135, 166);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(19, 20);
            this.lblG.Style = Sunny.UI.UIStyle.Custom;
            this.lblG.TabIndex = 8;
            this.lblG.Text = "G";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblB.Location = new System.Drawing.Point(200, 166);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(18, 20);
            this.lblB.Style = Sunny.UI.UIStyle.Custom;
            this.lblB.TabIndex = 9;
            this.lblB.Text = "B";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_colorWheel
            // 
            this.m_colorWheel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.m_colorWheel.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.m_colorWheel.Location = new System.Drawing.Point(269, 8);
            this.m_colorWheel.Name = "m_colorWheel";
            this.m_colorWheel.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(205)))));
            this.m_colorWheel.Size = new System.Drawing.Size(148, 148);
            this.m_colorWheel.Style = Sunny.UI.UIStyle.Custom;
            this.m_colorWheel.StyleCustomMode = false;
            this.m_colorWheel.TabIndex = 10;
            this.m_colorWheel.TagString = null;
            this.m_colorWheel.Text = "colorWheel1";
            this.m_colorWheel.SelectedColorChanged += new System.EventHandler(this.m_colorWheel_SelectedColorChanged);
            // 
            // m_colorBar
            // 
            this.m_colorBar.BackColor = System.Drawing.Color.Transparent;
            this.m_colorBar.BarPadding = new System.Windows.Forms.Padding(12, 5, 32, 10);
            this.m_colorBar.Color1 = System.Drawing.Color.Black;
            this.m_colorBar.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.m_colorBar.Color3 = System.Drawing.Color.White;
            this.m_colorBar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_colorBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.m_colorBar.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.m_colorBar.Location = new System.Drawing.Point(422, 8);
            this.m_colorBar.Name = "m_colorBar";
            this.m_colorBar.NumberOfColors = Sunny.UI.ColorSlider.eNumberOfColors.Use3Colors;
            this.m_colorBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_colorBar.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.m_colorBar.Percent = 0F;
            this.m_colorBar.RotatePointAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.m_colorBar.Size = new System.Drawing.Size(45, 148);
            this.m_colorBar.Style = Sunny.UI.UIStyle.Custom;
            this.m_colorBar.StyleCustomMode = false;
            this.m_colorBar.TabIndex = 11;
            this.m_colorBar.TagString = null;
            this.m_colorBar.Text = "Lightness";
            this.m_colorBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.m_colorBar.TextAngle = 270F;
            this.m_colorBar.ValueOrientation = Sunny.UI.ColorSlider.eValueOrientation.MaxToMin;
            this.m_colorBar.SelectedValueChanged += new System.EventHandler(this.m_colorBar_SelectedValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnOK.Location = new System.Drawing.Point(269, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnOK.Size = new System.Drawing.Size(95, 26);
            this.btnOK.Style = Sunny.UI.UIStyle.Custom;
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Select";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCancel.Location = new System.Drawing.Point(372, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(95, 26);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UIColorItem
            // 
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.m_colorBar);
            this.Controls.Add(this.m_colorWheel);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.edtB);
            this.Controls.Add(this.edtG);
            this.Controls.Add(this.edtR);
            this.Controls.Add(this.m_colorSample);
            this.Controls.Add(this.m_colorTable);
            this.FillColor = System.Drawing.Color.White;
            this.Name = "UIColorItem";
            this.Size = new System.Drawing.Size(476, 199);
            this.Style = Sunny.UI.UIStyle.Custom;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void m_colorTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color selcol = (Color)m_colorTable.SelectedItem;
            if (selcol != m_selectedColor)
            {
                lockColorTable = true;
                m_colorWheel.SelectedColor = selcol;
                lockColorTable = false;
                m_colorSample.Invalidate();
            }
        }

        private Color m_selectedColor = Color.AntiqueWhite;

        private bool lockColorTable = false;

        public Color SelectedColor
        {
            get { return Color.FromArgb(m_selectedColor.R, m_selectedColor.G, m_selectedColor.B); }
            set
            {
                value = Color.FromArgb(255, value);
                m_colorWheel.SelectedColor = value;
                if (m_colorTable.ColorExist(value) == false)
                    m_colorTable.SetCustomColor(value);
                m_colorTable.SelectedItem = value;
            }
        }

        private void m_colorBar_SelectedValueChanged(object sender, EventArgs e)
        {
            m_colorWheel.SetLightness(m_colorBar.SelectedHSLColor.Lightness);
        }

        private void UpdateInfo()
        {
            Color c = Color.FromArgb(m_selectedColor.R, m_selectedColor.G, m_selectedColor.B);
            string info = string.Format("{0} aRGB({1}, {2}, {3}, {4})", m_colorWheel.SelectedHSLColor.ToString(), c.A, c.R, c.G, c.B);
            edtR.IntValue = c.R;
            edtG.IntValue = c.G;
            edtB.IntValue = c.B;
            //m_infoLabel.Text = info;
        }

        private void m_colorWheel_SelectedColorChanged(object sender, EventArgs e)
        {
            Color selcol = m_colorWheel.SelectedColor;
            if (selcol != m_selectedColor)
            {
                m_selectedColor = selcol;
                m_colorSample.Refresh();
                if (lockColorTable == false && selcol != m_colorTable.SelectedItem)
                    m_colorTable.SetCustomColor(selcol);
            }

            m_colorBar.SelectedHSLColor = m_colorWheel.SelectedHSLColor;
            UpdateInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseParent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DoValueChanged(this, SelectedColor);
            CloseParent();
        }

        private void m_colorSample_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Rectangle r = m_colorSample.ClientRectangle;
            r.Inflate(-4, -4);

            int width = r.Width;
            r.Width /= 2;

            Color c = Color.FromArgb(m_selectedColor.R, m_selectedColor.G, m_selectedColor.B);
            e.Graphics.FillRectangle(c, r);

            r.X += r.Width;

            e.Graphics.FillRectangle(Color.White, r);
            c = Color.FromArgb(255, m_selectedColor);
            e.Graphics.FillRectangle(c, r);
        }

        public override void SetStyle(UIBaseStyle uiColor)
        {
            base.SetStyleColor(uiColor);
            RectColor = uiColor.RectColor;
            BackColor = uiColor.PlainColor;
            btnOK.SetStyleColor(uiColor);
            btnCancel.SetStyleColor(uiColor);
            m_colorTable.SetStyleColor(uiColor);
            m_colorWheel.SetStyleColor(uiColor);
            m_colorBar.SetStyleColor(uiColor);
            m_colorSample.SetStyleColor(uiColor);
            edtR.SetStyleColor(uiColor);
            edtG.SetStyleColor(uiColor);
            edtB.SetStyleColor(uiColor);
            lblR.ForeColor = lblG.ForeColor = lblB.ForeColor = uiColor.PanelForeColor;
        }
    }
}
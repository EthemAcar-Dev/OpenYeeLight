namespace OpenYeeLightUI
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
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.RefreshLightsButton = new Sunny.UI.UISymbolButton();
            this.SettingsButton = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Size = new System.Drawing.Size(250, 585);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // RefreshLightsButton
            // 
            this.RefreshLightsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshLightsButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.RefreshLightsButton.Location = new System.Drawing.Point(0, 585);
            this.RefreshLightsButton.Name = "RefreshLightsButton";
            this.RefreshLightsButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.RefreshLightsButton.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.RefreshLightsButton.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.RefreshLightsButton.Size = new System.Drawing.Size(208, 35);
            this.RefreshLightsButton.Style = Sunny.UI.UIStyle.Custom;
            this.RefreshLightsButton.Symbol = 61473;
            this.RefreshLightsButton.TabIndex = 45;
            this.RefreshLightsButton.Text = "Refresh";
            this.RefreshLightsButton.Click += new System.EventHandler(this.RefreshLightsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.SettingsButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.SettingsButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SettingsButton.Location = new System.Drawing.Point(206, 585);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.SettingsButton.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.SettingsButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.SettingsButton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.SettingsButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.SettingsButton.Size = new System.Drawing.Size(44, 35);
            this.SettingsButton.Style = Sunny.UI.UIStyle.Orange;
            this.SettingsButton.StyleCustomMode = true;
            this.SettingsButton.Symbol = 61573;
            this.SettingsButton.TabIndex = 46;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 620);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.RefreshLightsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(907, 620);
            this.MinimumSize = new System.Drawing.Size(907, 620);
            this.Name = "MainForm";
            this.ShowRadius = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "OpenYeeLight";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.RefreshLightsButton, 0);
            this.Controls.SetChildIndex(this.SettingsButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIStyleManager StyleManager;
        private Sunny.UI.UISymbolButton RefreshLightsButton;
        private Sunny.UI.UISymbolButton SettingsButton;
    }
}
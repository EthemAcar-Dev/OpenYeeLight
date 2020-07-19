namespace OpenYeeLightUI.Forms
{
    partial class SettingsForm
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
            this.MulticastDisabled = new Sunny.UI.UIRadioButton();
            this.MulticastEnabled = new Sunny.UI.UIRadioButton();
            this.MulticastLookupLabel = new Sunny.UI.UILabel();
            this.AskForUpdatesDisabled = new Sunny.UI.UIRadioButton();
            this.AskForUpdatesEnabled = new Sunny.UI.UIRadioButton();
            this.AskForUpdatesLabel = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 136);
            this.pnlBtm.Size = new System.Drawing.Size(375, 55);
            // 
            // MulticastDisabled
            // 
            this.MulticastDisabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MulticastDisabled.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.MulticastDisabled.Location = new System.Drawing.Point(261, 47);
            this.MulticastDisabled.Name = "MulticastDisabled";
            this.MulticastDisabled.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.MulticastDisabled.Size = new System.Drawing.Size(100, 29);
            this.MulticastDisabled.TabIndex = 8;
            this.MulticastDisabled.Text = "Disabled";
            // 
            // MulticastEnabled
            // 
            this.MulticastEnabled.Checked = true;
            this.MulticastEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MulticastEnabled.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.MulticastEnabled.Location = new System.Drawing.Point(160, 47);
            this.MulticastEnabled.Name = "MulticastEnabled";
            this.MulticastEnabled.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.MulticastEnabled.Size = new System.Drawing.Size(95, 29);
            this.MulticastEnabled.TabIndex = 7;
            this.MulticastEnabled.Text = "Enabled";
            // 
            // MulticastLookupLabel
            // 
            this.MulticastLookupLabel.AutoSize = true;
            this.MulticastLookupLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.MulticastLookupLabel.Location = new System.Drawing.Point(11, 51);
            this.MulticastLookupLabel.Name = "MulticastLookupLabel";
            this.MulticastLookupLabel.Size = new System.Drawing.Size(142, 21);
            this.MulticastLookupLabel.TabIndex = 9;
            this.MulticastLookupLabel.Text = "Multicast lookup:";
            this.MulticastLookupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AskForUpdatesDisabled
            // 
            this.AskForUpdatesDisabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AskForUpdatesDisabled.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AskForUpdatesDisabled.GroupIndex = 1;
            this.AskForUpdatesDisabled.Location = new System.Drawing.Point(261, 87);
            this.AskForUpdatesDisabled.Name = "AskForUpdatesDisabled";
            this.AskForUpdatesDisabled.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.AskForUpdatesDisabled.Size = new System.Drawing.Size(100, 29);
            this.AskForUpdatesDisabled.TabIndex = 11;
            this.AskForUpdatesDisabled.Text = "Disabled";
            // 
            // AskForUpdatesEnabled
            // 
            this.AskForUpdatesEnabled.Checked = true;
            this.AskForUpdatesEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AskForUpdatesEnabled.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AskForUpdatesEnabled.GroupIndex = 1;
            this.AskForUpdatesEnabled.Location = new System.Drawing.Point(160, 87);
            this.AskForUpdatesEnabled.Name = "AskForUpdatesEnabled";
            this.AskForUpdatesEnabled.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.AskForUpdatesEnabled.Size = new System.Drawing.Size(95, 29);
            this.AskForUpdatesEnabled.TabIndex = 10;
            this.AskForUpdatesEnabled.Text = "Enabled";
            // 
            // AskForUpdatesLabel
            // 
            this.AskForUpdatesLabel.AutoSize = true;
            this.AskForUpdatesLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AskForUpdatesLabel.Location = new System.Drawing.Point(11, 87);
            this.AskForUpdatesLabel.Name = "AskForUpdatesLabel";
            this.AskForUpdatesLabel.Size = new System.Drawing.Size(134, 21);
            this.AskForUpdatesLabel.TabIndex = 12;
            this.AskForUpdatesLabel.Text = "Ask for updates:";
            this.AskForUpdatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 194);
            this.Controls.Add(this.AskForUpdatesDisabled);
            this.Controls.Add(this.AskForUpdatesEnabled);
            this.Controls.Add(this.AskForUpdatesLabel);
            this.Controls.Add(this.MulticastDisabled);
            this.Controls.Add(this.MulticastEnabled);
            this.Controls.Add(this.MulticastLookupLabel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.MulticastLookupLabel, 0);
            this.Controls.SetChildIndex(this.MulticastEnabled, 0);
            this.Controls.SetChildIndex(this.MulticastDisabled, 0);
            this.Controls.SetChildIndex(this.AskForUpdatesLabel, 0);
            this.Controls.SetChildIndex(this.AskForUpdatesEnabled, 0);
            this.Controls.SetChildIndex(this.AskForUpdatesDisabled, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIRadioButton MulticastDisabled;
        private Sunny.UI.UIRadioButton MulticastEnabled;
        private Sunny.UI.UILabel MulticastLookupLabel;
        private Sunny.UI.UIRadioButton AskForUpdatesDisabled;
        private Sunny.UI.UIRadioButton AskForUpdatesEnabled;
        private Sunny.UI.UILabel AskForUpdatesLabel;
    }
}
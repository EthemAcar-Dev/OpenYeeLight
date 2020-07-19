namespace OpenYeeLightUI.Forms
{
    partial class UpdateForm
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
            this.NewVersionLabel = new Sunny.UI.UISymbolLabel();
            this.YourVersionLabel = new Sunny.UI.UISymbolLabel();
            this.ChangelogLabel = new Sunny.UI.UILinkLabel();
            this.UpdateButton = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // NewVersionLabel
            // 
            this.NewVersionLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.NewVersionLabel.Location = new System.Drawing.Point(3, 38);
            this.NewVersionLabel.Name = "NewVersionLabel";
            this.NewVersionLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.NewVersionLabel.Size = new System.Drawing.Size(312, 35);
            this.NewVersionLabel.Symbol = 61445;
            this.NewVersionLabel.TabIndex = 0;
            this.NewVersionLabel.Text = "New version: ";
            this.NewVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YourVersionLabel
            // 
            this.YourVersionLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.YourVersionLabel.Location = new System.Drawing.Point(3, 79);
            this.YourVersionLabel.Name = "YourVersionLabel";
            this.YourVersionLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.YourVersionLabel.Size = new System.Drawing.Size(312, 35);
            this.YourVersionLabel.Symbol = 57585;
            this.YourVersionLabel.TabIndex = 1;
            this.YourVersionLabel.Text = "Your version: ";
            this.YourVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangelogLabel
            // 
            this.ChangelogLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.ChangelogLabel.AutoSize = true;
            this.ChangelogLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ChangelogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ChangelogLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.ChangelogLabel.LinkColor = System.Drawing.Color.Blue;
            this.ChangelogLabel.Location = new System.Drawing.Point(3, 134);
            this.ChangelogLabel.Name = "ChangelogLabel";
            this.ChangelogLabel.Size = new System.Drawing.Size(107, 21);
            this.ChangelogLabel.TabIndex = 2;
            this.ChangelogLabel.TabStop = true;
            this.ChangelogLabel.Text = "What\'s new?";
            this.ChangelogLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ChangelogLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangelogLabel_LinkClicked);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.UpdateButton.Location = new System.Drawing.Point(215, 120);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.UpdateButton.Size = new System.Drawing.Size(100, 35);
            this.UpdateButton.Symbol = 57457;
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 161);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ChangelogLabel);
            this.Controls.Add(this.YourVersionLabel);
            this.Controls.Add(this.NewVersionLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 161);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 161);
            this.Name = "UpdateForm";
            this.ShowInTaskbar = false;
            this.ShowRadius = false;
            this.Text = "New update!";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolLabel NewVersionLabel;
        private Sunny.UI.UISymbolLabel YourVersionLabel;
        private Sunny.UI.UILinkLabel ChangelogLabel;
        private Sunny.UI.UISymbolButton UpdateButton;
    }
}
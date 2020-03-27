namespace OpenYeeLightUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.NewUpdateLabel = new System.Windows.Forms.Label();
            this.YourVersionLabel = new System.Windows.Forms.Label();
            this.NewVersionLabel = new System.Windows.Forms.Label();
            this.ChangelogLabel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.UpdateButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.loadingCircle = new ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common.LoadingCircle();
            this.SuspendLayout();
            // 
            // NewUpdateLabel
            // 
            this.NewUpdateLabel.AutoSize = true;
            this.NewUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUpdateLabel.Location = new System.Drawing.Point(12, 9);
            this.NewUpdateLabel.Name = "NewUpdateLabel";
            this.NewUpdateLabel.Size = new System.Drawing.Size(257, 33);
            this.NewUpdateLabel.TabIndex = 0;
            this.NewUpdateLabel.Text = "New update found.";
            // 
            // YourVersionLabel
            // 
            this.YourVersionLabel.AutoSize = true;
            this.YourVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourVersionLabel.Location = new System.Drawing.Point(14, 58);
            this.YourVersionLabel.Name = "YourVersionLabel";
            this.YourVersionLabel.Size = new System.Drawing.Size(126, 24);
            this.YourVersionLabel.TabIndex = 1;
            this.YourVersionLabel.Text = "Your version: ";
            // 
            // NewVersionLabel
            // 
            this.NewVersionLabel.AutoSize = true;
            this.NewVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVersionLabel.Location = new System.Drawing.Point(14, 92);
            this.NewVersionLabel.Name = "NewVersionLabel";
            this.NewVersionLabel.Size = new System.Drawing.Size(125, 24);
            this.NewVersionLabel.TabIndex = 2;
            this.NewVersionLabel.Text = "New version: ";
            // 
            // ChangelogLabel
            // 
            this.ChangelogLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.ChangelogLabel.Location = new System.Drawing.Point(12, 130);
            this.ChangelogLabel.Name = "ChangelogLabel";
            this.ChangelogLabel.Size = new System.Drawing.Size(122, 29);
            this.ChangelogLabel.TabIndex = 3;
            this.ChangelogLabel.Values.Text = "What\'s new?";
            this.ChangelogLabel.LinkClicked += new System.EventHandler(this.ChangelogLabel_LinkClicked);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(313, 130);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(121, 29);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Values.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // loadingCircle
            // 
            this.loadingCircle.Active = true;
            this.loadingCircle.Color = System.Drawing.Color.DarkGray;
            this.loadingCircle.InnerCircleRadius = 8;
            this.loadingCircle.Location = new System.Drawing.Point(313, 84);
            this.loadingCircle.Name = "loadingCircle";
            this.loadingCircle.NumberSpoke = 24;
            this.loadingCircle.OuterCircleRadius = 9;
            this.loadingCircle.RotationSpeed = 100;
            this.loadingCircle.Size = new System.Drawing.Size(121, 40);
            this.loadingCircle.SpokeThickness = 4;
            this.loadingCircle.StylePreset = ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common.LoadingCircle.StylePresets.IE7;
            this.loadingCircle.TabIndex = 5;
            this.loadingCircle.Text = "loadingCircle1";
            this.loadingCircle.Visible = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 171);
            this.Controls.Add(this.loadingCircle);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ChangelogLabel);
            this.Controls.Add(this.NewVersionLabel);
            this.Controls.Add(this.YourVersionLabel);
            this.Controls.Add(this.NewUpdateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewUpdateLabel;
        private System.Windows.Forms.Label YourVersionLabel;
        private System.Windows.Forms.Label NewVersionLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel ChangelogLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton UpdateButton;
        private ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common.LoadingCircle loadingCircle;
    }
}
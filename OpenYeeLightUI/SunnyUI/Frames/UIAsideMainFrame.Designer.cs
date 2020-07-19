namespace Sunny.UI
{
    partial class UIAsideMainFrame
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
            this.Aside = new Sunny.UI.UINavMenu();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Aside.Dock = System.Windows.Forms.DockStyle.Left;
            this.Aside.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.Aside.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Aside.FullRowSelect = true;
            this.Aside.ItemHeight = 50;
            this.Aside.Location = new System.Drawing.Point(0, 35);
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Name = "Aside";
            this.Aside.ShowLines = false;
            this.Aside.Size = new System.Drawing.Size(250, 415);
            this.Aside.TabIndex = 1;
            // 
            // UIAsideMainFrame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aside);
            this.Name = "UIAsideMainFrame";
            this.Text = "UIAsideMainFrame";
            this.Controls.SetChildIndex(this.Aside, 0);
            this.ResumeLayout(false);

        }

        #endregion

        protected UINavMenu Aside;
    }
}
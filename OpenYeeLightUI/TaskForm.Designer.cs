namespace OpenYeeLightUI
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.UserTaskList = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonComboBoxEnhanced();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProcessList = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonListView();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserTaskList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTaskList
            // 
            this.UserTaskList.DropDownWidth = 197;
            this.UserTaskList.Location = new System.Drawing.Point(12, 12);
            this.UserTaskList.Name = "UserTaskList";
            this.UserTaskList.PersistentColours = false;
            this.UserTaskList.Size = new System.Drawing.Size(187, 21);
            this.UserTaskList.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.UserTaskList.TabIndex = 0;
            this.UserTaskList.UseStyledColours = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProcessList);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processes";
            // 
            // ProcessList
            // 
            this.ProcessList.AlternateRowColour = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.ProcessList.AlternateRowColourEnabled = true;
            this.ProcessList.AutoSizeLastColumn = true;
            this.ProcessList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessList.EnableDragDrop = false;
            this.ProcessList.EnableHeaderGlow = false;
            this.ProcessList.EnableHeaderHotTrack = false;
            this.ProcessList.EnableHeaderRendering = true;
            this.ProcessList.EnableSelectionBorder = false;
            this.ProcessList.EnableSorting = true;
            this.ProcessList.EnableVistaCheckBoxes = true;
            this.ProcessList.ForceLeftAlign = false;
            this.ProcessList.FullRowSelect = true;
            this.ProcessList.HideSelection = false;
            this.ProcessList.ItemHeight = 0;
            this.ProcessList.LargeImageList = this.imageList;
            this.ProcessList.LineAfter = -1;
            this.ProcessList.LineBefore = -1;
            this.ProcessList.Location = new System.Drawing.Point(3, 16);
            this.ProcessList.MultiSelect = false;
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.OwnerDraw = true;
            this.ProcessList.PersistentColours = false;
            this.ProcessList.SelectEntireRowOnSubItem = true;
            this.ProcessList.Size = new System.Drawing.Size(184, 324);
            this.ProcessList.SmallImageList = this.imageList;
            this.ProcessList.TabIndex = 2;
            this.ProcessList.UseCompatibleStateImageBehavior = false;
            this.ProcessList.UseKryptonRenderer = true;
            this.ProcessList.UseStyledColours = false;
            this.ProcessList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office365Black;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserTaskList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskForm";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserTaskList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonComboBoxEnhanced UserTaskList;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonListView ProcessList;
        private System.Windows.Forms.ImageList imageList;
    }
}
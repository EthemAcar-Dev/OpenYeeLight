// Created by Ethem Acar
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.Classes;

namespace OpenYeeLightUI
{
    public class ComboBoxFix : ComponentFactory.Krypton.Toolkit.KryptonComboBox
    {
        /// <summary>Required designer variable.</summary>
        private IContainer components = (IContainer)null;

        private bool _enabled = true;
        private Color _gradientStartColor = Color.White;
        private Color _gradientEndColor = Color.Gray;
        private bool _persistentColors = false;
        private bool _useStyledColors = false;
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        /// <summary>Clean up any resources being used.</summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = (IContainer)new Container();
        }

        public new bool Enabled
        {
            get
            {
                return this._enabled;
            }
            set
            {
                this._enabled = value;
                this.ComboBox.Enabled = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true)]
        [Category("Appearance-Extended")]
        [DefaultValue("Color.White")]
        public Color GradientStartColour
        {
            get
            {
                return this._gradientStartColor;
            }
            set
            {
                this._gradientStartColor = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true)]
        [Category("Appearance-Extended")]
        [DefaultValue("Color.Gray")]
        public Color GradientEndColour
        {
            get
            {
                return this._gradientEndColor;
            }
            set
            {
                this._gradientEndColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance-Extended")]
        [DefaultValue("False")]
        public bool PersistentColours
        {
            get
            {
                return this._persistentColors;
            }
            set
            {
                this._persistentColors = value;
            }
        }

        [Browsable(true)]
        [Category("Appearance-Extended")]
        [DefaultValue("False")]
        public bool UseStyledColours
        {
            get
            {
                return this._useStyledColors;
            }
            set
            {
                this._useStyledColors = value;
            }
        }

        public ComboBoxFix()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.ComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            this.ItemHeight += 2;
            this.ComboBox.DrawItem += new DrawItemEventHandler(this.OnDItem);
            if (this._palette != null)
                this._palette.PalettePaint += new System.EventHandler<PaletteLayoutEventArgs>(this.OnPalettePaint);
            KryptonManager.GlobalPaletteChanged += new System.EventHandler(this.ThisGlobalPaletteChanged);
            this._palette = KryptonManager.CurrentGlobalPalette;
            this._paletteRedirect = new PaletteRedirect(this._palette);
            this.InitializeComponent();
            if (this.Enabled)
                return;
            this.Enabled = true;
            this.ComboBox.Enabled = false;
        }

        private void OnDItem(object Sender, DrawItemEventArgs e)
        {
            this.ODrawItem(e);
        }

        protected void ODrawItem(DrawItemEventArgs e)
        {
            Rectangle bounds = e.Bounds;
            Graphics graphics = e.Graphics;
            if (e.Index == -1)
                return;
            try
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            if (this._palette == null)
                this.ThisGlobalPaletteChanged((object)this, new EventArgs());
            if (!this._persistentColors)
            {
                if (this._useStyledColors)
                {
                    this._gradientStartColor = Color.FromArgb((int)byte.MaxValue, 246, 215);
                    this._gradientEndColor = Color.FromArgb((int)byte.MaxValue, 213, 77);
                }
                else
                {
                    this._gradientStartColor = this._palette.ColorTable.StatusStripGradientBegin;
                    this._gradientEndColor = this._palette.ColorTable.OverflowButtonGradientEnd;
                }
            }
            Color gradientStartColor = this._gradientStartColor;
            Color gradientEndColor = this._gradientEndColor;
            Color statusStripText = this._palette.ColorTable.StatusStripText;
            Font font = e.Font ?? this.Font;
            e.DrawBackground();
            string s = this.Items[e.Index].ToString();
            if (!this.Enabled)
                e.Graphics.DrawString(s, font, (Brush)new SolidBrush(SystemColors.GrayText), (RectangleF)e.Bounds);
            else
                e.Graphics.DrawString(s, font, (Brush)new SolidBrush(Color.Black), (RectangleF)e.Bounds);
            if ((uint)(e.State & DrawItemState.Selected) > 0U)
            {
                DrawingMethods.DrawGradient(graphics, e.Bounds, gradientStartColor, gradientEndColor, 90f, false, Color.White, 0.0f);
                e.Graphics.DrawString(s, font, (Brush)new SolidBrush(statusStripText), (RectangleF)e.Bounds);
                e.DrawFocusRectangle();
            }
            e.DrawFocusRectangle();
        }

        private void ThisGlobalPaletteChanged(object sender, EventArgs e)
        {
            if (this._palette != null)
                this._palette.PalettePaint -= new System.EventHandler<PaletteLayoutEventArgs>(this.OnPalettePaint);
            this._palette = KryptonManager.CurrentGlobalPalette;
            this._paletteRedirect.Target = this._palette;
            if (this._palette != null)
            {
                this._palette.PalettePaint += new System.EventHandler<PaletteLayoutEventArgs>(this.OnPalettePaint);
                if (!this._persistentColors)
                {
                    if (this._useStyledColors)
                    {
                        this._gradientStartColor = Color.FromArgb((int)byte.MaxValue, 246, 215);
                        this._gradientEndColor = Color.FromArgb((int)byte.MaxValue, 213, 77);
                    }
                    else
                    {
                        this._gradientStartColor = this._palette.ColorTable.StatusStripGradientBegin;
                        this._gradientEndColor = this._palette.ColorTable.OverflowButtonGradientEnd;
                    }
                }
            }
            this.Invalidate();
        }

        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            this.Invalidate();
        }
    }
}
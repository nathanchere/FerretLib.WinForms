using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FerretLib.WinForms.Controls
{
    internal partial class TagLabelControl : UserControl
    {
        public delegate void TagEvent(object sender, string tag);
        public event TagEvent DeleteClicked;
        public event TagEvent DoubleClicked;

        #region ctor
        private bool isDisposing;

        public TagLabelControl() : this("New Tag") { }

        public TagLabelControl(string value)
        {
            InitializeComponent();
            Value = value;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Opaque | ControlStyles.FixedHeight, false);
            BackColor = Color.Transparent;

            RecreateBuffer();
            Redraw();
        }

        protected override void Dispose(bool disposing)
        {                                
            isDisposing = true;
            if (disposing)
            {
                if (backbuffer != null) backbuffer.Dispose();                
                if (components != null) components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Properties
        public string Value
        {
            get
            {
                return lblText.Text;
            }
            set
            {
                lblText.Text = value;
                ResizeControl();
            }
        }

        #endregion

        #region Input events
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteClicked != null) DeleteClicked(this, Value);
        }

        private void lblText_DoubleClick(object sender, EventArgs e)
        {
            if (DoubleClicked != null) DoubleClicked(this, Value);
        }
        #endregion        

        #region Rendering

        private Bitmap backbuffer;
        private static Font font = new ResourceFont(Properties.Resources.font_PatrickHand).GetFont(12);

        private void ResizeControl()
        {
            var width = lblText.Width + 35;
            lblText.Left = 10;
            var height = 19;
            MaximumSize = new Size(width, height);
            MinimumSize = MaximumSize;
            Width = width;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RecreateBuffer();
            Redraw();
        }

        private void RecreateBuffer()
        {
            if (isDisposing) return;

            var newBuffer = new Bitmap(Math.Max(Width, 1), Math.Max(Height, 1), PixelFormat.Format32bppPArgb);

            if (backbuffer != null) {
                using (var g = Graphics.FromImage(newBuffer)) {
                    g.DrawImage(backbuffer, Point.Empty);
                }
                backbuffer.Dispose();
            }

            backbuffer = newBuffer;            
            
            DoInvalidate();
        }

        private void DoInvalidate()
        {
            if (Parent != null) {
                Rectangle rc = new Rectangle(this.Location, this.Size);
                Parent.Invalidate(rc, true);
            }                     
            Invalidate();
        }

        private void Redraw()
        {
            const int LEFT_WIDTH = 9;
            const int MARGIN = 3;
            const int RIGHT_WIDTH = 15;

            if (backbuffer == null) return;
            using (var canvas = Graphics.FromImage(backbuffer)) {
                canvas.Clear(Color.Transparent);
                //canvas.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                canvas.DrawImage(Properties.Resources.tagLabel_background_left, 0, 0);
                canvas.DrawImage(Properties.Resources.tagLabel_background, new Rectangle(LEFT_WIDTH, 0, Width - LEFT_WIDTH - RIGHT_WIDTH, Height));
                canvas.DrawImage(Properties.Resources.tagLabel_background_right,
                    Width - Properties.Resources.tagLabel_background_right.Width, 0);
                canvas.DrawString(Value, font, Brushes.Black, 0, -4);
            }
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!isDisposing && backbuffer != null) e.Graphics.DrawImage(backbuffer, Point.Empty);
        }
        #endregion
    }
}

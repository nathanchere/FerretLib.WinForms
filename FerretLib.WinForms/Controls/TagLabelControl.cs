using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FerretLib.WinForms.Controls
{
    internal partial class TagLabelControl : UserControl
    {
        public delegate void TagEvent(object sender, string tag);
        public event TagEvent DeleteClicked;
        public event TagEvent DoubleClicked;

        private string _value;
        private const int HEIGHT = 19;
        private const int LEFT_WIDTH = 9;
        private const int MARGIN = 3;
        private const int RIGHT_WIDTH = 15;

        #region ctor
        private bool isDisposing;

        public TagLabelControl() : this("New Tag")
        {
        }

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
            if (disposing) {
                if (backbuffer != null)
                    backbuffer.Dispose();
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Properties
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                ResizeControl();
            }
        }

        #endregion

        #region Input events
        
        private void Control_Click(object sender, EventArgs e)
        {
            if (IsCursorOverDeleteButton())
            {
                if (DeleteClicked != null) DeleteClicked(this, Value);
            }
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            if (IsCursorOverDeleteButton())
            {
                if (DeleteClicked != null) DeleteClicked(this, Value);
                return;
            }

            if (DoubleClicked != null) DoubleClicked(this, Value);
        }
        #endregion

        #region Rendering

        private Bitmap backbuffer;
        private bool _drawDeleteButton;
        private static Font font = new Font("Buxton Sketch", 11);

        private void ResizeControl()
        {
            using (var g = Graphics.FromImage(backbuffer)) {
                int width = (int)g.MeasureString(Value, font).Width + LEFT_WIDTH + RIGHT_WIDTH + MARGIN + MARGIN;
                MaximumSize = new Size(width, HEIGHT);
                MinimumSize = MaximumSize;
                Width = width;
            }

            _deleteButtonRegion = new Rectangle(Width - 18, 1, 16, 16);
        }

        private void RecreateBuffer()
        {
            if (isDisposing)
                return;

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
            if (backbuffer == null)
                return;
            try
            {
                using (var canvas = Graphics.FromImage(backbuffer))
                {
                    canvas.Clear(Color.Transparent);
                    canvas.PixelOffsetMode = PixelOffsetMode.Half;
                    canvas.InterpolationMode = InterpolationMode.NearestNeighbor;
                    canvas.DrawImage(Properties.Resources.tagLabel_background, new Rectangle(LEFT_WIDTH, 0, Width - LEFT_WIDTH - RIGHT_WIDTH, Height));
                    canvas.DrawImage(Properties.Resources.tagLabel_background_left, 0, 0);
                    canvas.DrawImage(Properties.Resources.tagLabel_background_right, Width - Properties.Resources.tagLabel_background_right.Width, 0);
                    if (_drawDeleteButton)
                        canvas.DrawImage(Properties.Resources.icon_round_delete, _deleteButtonRegion);

                    canvas.DrawString(Value, font, Brushes.Black, LEFT_WIDTH, 1);
                }
            }
            catch {  }
            Refresh();
            
        }
        #endregion
        #region Event overrides
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Cursor = Cursors.Default;

            if (_drawDeleteButton) {
                _drawDeleteButton = false;
                Redraw();
            }

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Cursor = IsCursorOverDeleteButton() ? Cursors.Hand : Cursors.Default;

            if (!_drawDeleteButton) {
                _drawDeleteButton = true;
                Redraw();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RecreateBuffer();
            Redraw();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!isDisposing && backbuffer != null)
                e.Graphics.DrawImage(backbuffer, Point.Empty);
        }
        #endregion

        #region Misc logic
        private Rectangle _deleteButtonRegion;
        private bool IsCursorOverDeleteButton()
        {
            return _deleteButtonRegion.Contains(PointToClient(Cursor.Position));
        }
        #endregion
    }
}

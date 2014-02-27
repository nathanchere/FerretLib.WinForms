using System;
using System.Drawing;
using System.Windows.Forms;

namespace FerretLib.WinForms.Controls
{
    public partial class ColorPicker : UserControl
    {
        public delegate void ColorChangedEvent(object sender, Color color);
        public event ColorChangedEvent ColorChanged;

        public ColorPicker()
        {
            InitializeComponent();            
        }

        private Color _value;
        public Color Value {
            get { return _value; }
            set { _value = value; UpdateColor(); }
        }
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }
        public byte A { get; private set; }        

        private void ColourPicker_Load(object sender, EventArgs e)
        {
            numR.ValueChanged += (o, args) => SyncValue(trackBarR,(NumericUpDown)o);
            numG.ValueChanged += (o, args) => SyncValue(trackBarG,(NumericUpDown)o);
            numB.ValueChanged += (o, args) => SyncValue(trackBarB,(NumericUpDown)o);
            numA.ValueChanged += (o, args) => SyncValue(trackBarA,(NumericUpDown)o);

            trackBarR.ValueChanged += (o, args) => SyncValue(numR, (TrackBar)o);
            trackBarG.ValueChanged += (o, args) => SyncValue(numG, (TrackBar)o);
            trackBarB.ValueChanged += (o, args) => SyncValue(numB, (TrackBar)o);
            trackBarA.ValueChanged += (o, args) => SyncValue(numA, (TrackBar)o);            
            UpdateColor();
        }

        private void SyncValue(TrackBar trackbar, NumericUpDown number)
        {
            int value = Convert.ToInt32(number.Value);
            if (trackbar.Value == value) return;
            
            trackbar.Value = value;
            UpdateColor();
        }

        private void SyncValue(NumericUpDown number, TrackBar trackbar)
        {
            int value = Convert.ToInt32(number.Value);
            if (value == trackbar.Value) return;

            number.Value = trackbar.Value;
            UpdateColor();
        }

        private void UpdateColor()
        {            
            R = (byte)trackBarR.Value;
            G = (byte)trackBarG.Value;
            B = (byte)trackBarB.Value;
            A = (byte)trackBarA.Value;

            var image = new Bitmap(128, 58);
            using (var g = Graphics.FromImage(image))
            {
                g.Clear(Color.FromArgb(A, R, G, B));
            }
            picColor.Image = image;

            if (ColorChanged != null) ColorChanged(this, Value);
        }
    }
}

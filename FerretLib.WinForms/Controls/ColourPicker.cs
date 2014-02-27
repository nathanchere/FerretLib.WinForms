using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FerretLib.WinForms.Controls
{
    public partial class ColourPicker : UserControl
    {
        public ColourPicker()
        {
            InitializeComponent();
        }

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
        }

        private void SyncValue(TrackBar trackbar, NumericUpDown number)
        {
            int value = Convert.ToInt32(number.Value);
            if (trackbar.Value != value) trackbar.Value = value;
        }

        private void SyncValue(NumericUpDown number, TrackBar trackbar)
        {
            int value = Convert.ToInt32(number.Value);
            if (value != trackbar.Value) number.Value = value;
        }
    }
}

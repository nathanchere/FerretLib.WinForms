using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerretLib.WinForms.Controls
{
    internal partial class TagLabelControl : UserControl
    {
        public delegate void TagEvent(object sender, string tag);
        public event TagEvent DeleteClicked;
        public event TagEvent DoubleClicked;

        public string Value {
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

        public TagLabelControl() : this("New Tag"){ }
        public TagLabelControl(string value)
        {
            InitializeComponent();
            Value = value;
        }       

        private void ResizeControl()
        {
            var width = lblText.Width + 18;
            var height = 20;
            MaximumSize = new Size(width, height);
            MinimumSize = MaximumSize;
            Width = width;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteClicked != null) DeleteClicked(this, Value);
        }

        private void lblText_DoubleClick(object sender, EventArgs e)
        {
            if (DoubleClicked != null) DoubleClicked(this, Value);
        }
    }
}

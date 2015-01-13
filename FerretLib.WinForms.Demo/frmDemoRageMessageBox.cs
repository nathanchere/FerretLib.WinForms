using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerretLib.WinForms.Controls;

namespace FerretLib.WinForms
{
    public partial class frmDemoRageMessageBox : Form
    {
        public frmDemoRageMessageBox()
        {
            InitializeComponent();
        }

        private void frmDemoRageMessageBox_Load(object sender, EventArgs e)
        {
            foreach (var option in Enum.GetValues(typeof (RageMessageBox.RageMessageBoxButtons)))
            {
                var radioButton = new RadioButton
                {
                    Tag = option,
                    Text = option.ToString(),
                };

                panelDialogOptions.Controls.Add(radioButton);
            }
        }
    }
}

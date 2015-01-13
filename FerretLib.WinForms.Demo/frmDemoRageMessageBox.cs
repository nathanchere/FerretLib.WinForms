using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
            foreach (var option in Enum.GetValues(typeof(RageMessageBox.RageMessageBoxButtons)))
            {
                var radioButton = new RadioButton
                {
                    Tag = option,
                    Text = option.ToString(),
                    Padding = new Padding(1),
                    Margin = new Padding(1),
                };

                optionsMessageBoxButtons.Controls.Add(radioButton);
                radioButton.Checked = true;
            }

            foreach (var option in Enum.GetValues(typeof(RageMessageBox.RageMessageBoxIcon)))
            {
                var radioButton = new RadioButton
                {
                    Tag = option,
                    Text = option.ToString(),
                };

                optionsMessageBoxIcons.Controls.Add(radioButton);
                radioButton.Checked = true;
            }
        }

        private RageMessageBox.RageMessageBoxButtons GetSelectedRageMessageBoxButtons()
        {
            foreach (var control in optionsMessageBoxButtons.Controls)
            {
                var option = control as RadioButton;
                if (option == null || !option.Checked) continue;
                return (RageMessageBox.RageMessageBoxButtons)(option.Tag);
            }
            throw new Exception("Nothing selected");
        }

        private RageMessageBox.RageMessageBoxIcon GetSelectedRageMessageBoxIcon()
        {
            foreach (var control in optionsMessageBoxIcons.Controls)
            {
                var option = control as RadioButton;
                if (option == null || !option.Checked) continue;
                return (RageMessageBox.RageMessageBoxIcon)(option.Tag);
            }
            throw new Exception("Nothing selected");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var result = RageMessageBox.Show(txtMainText.Text.Trim(), "FUUUUUUUUUU", txtDetail.Text.Trim(), GetSelectedRageMessageBoxButtons(), GetSelectedRageMessageBoxIcon());
            MessageBox.Show(result.ToString());

        }

        private void btnPadText_Click(object sender, EventArgs e)
        {
            txtMainText.AppendText(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec feugiat urna sit amet mi ultrices, in luctus nulla finibus. Aenean quis mauris efficitur, mattis velit sed, tincidunt elit. Integer ac est risus. Aenean dictum rutrum odio sit amet venenatis. Aenean ut metus in odio congue faucibus vitae non velit. Sed tincidunt interdum elit quis commodo. Vivamus quis nunc congue, fringilla dui in, facilisis ante. Mauris a urna vitae orci iaculis rhoncus. Donec viverra, orci at sollicitudin aliquam, odio risus sodales nunc, at lobortis nibh ex ut augue. Ut nec ultrices risus, eu pulvinar nibh." + Environment.NewLine + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMainText.AppendText(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec feugiat urna sit amet mi ultrices, in luctus nulla finibus. Aenean quis mauris efficitur, mattis velit sed, tincidunt elit. Integer ac est risus. Aenean dictum rutrum odio sit amet venenatis. Aenean ut metus in odio congue faucibus vitae non velit. Sed tincidunt interdum elit quis commodo. Vivamus quis nunc congue, fringilla dui in, facilisis ante. Mauris a urna vitae orci iaculis rhoncus. Donec viverra, orci at sollicitudin aliquam, odio risus sodales nunc, at lobortis nibh ex ut augue. Ut nec ultrices risus, eu pulvinar nibh." + Environment.NewLine + Environment.NewLine);
        }
    }
}

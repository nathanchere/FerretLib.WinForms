using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FerretLib.WinForms.Controls
{
    public partial class RageMessageBox : Form
    {
        public DialogResult Result { get; private set; }

        public enum RageMessageBoxButtons
        {
        }

        public enum RageMessageBoxDefaultButton
        {
            OK,
            OKCancel,
            RetryCancel,
            YesNo,
            YesNoCancel,
            AbortRetryIgnore,
            FFFFFUUUUUUUU,
            LOL,            
            Derp,
        }

        public enum RageMessageBoxIcon
        {
            None,
            FFFFFUUUUUUUU,
            SuperRage,
            Derp,
            Trolling,
            Facepalm,
            EpicWin,
            YUNo,
        }

        public RageMessageBox(string text, RageMessageBoxDefaultButton buttons, RageMessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeButtons(buttons);
            //InitializeDialogLayout();
        }

        private void InitializeButtons(RageMessageBoxDefaultButton buttons)
        {
            if (buttons == RageMessageBoxDefaultButton.OK || buttons == RageMessageBoxDefaultButton.OKCancel)
                AddButton("OK", DialogResult.OK);

            if (buttons == RageMessageBoxDefaultButton.AbortRetryIgnore)
                AddButton("Abort", DialogResult.Abort);

            if (buttons == RageMessageBoxDefaultButton.AbortRetryIgnore || buttons == RageMessageBoxDefaultButton.RetryCancel)
                AddButton("Retry", DialogResult.Retry);

            if (buttons == RageMessageBoxDefaultButton.YesNo || buttons == RageMessageBoxDefaultButton.YesNoCancel)
            {
                AddButton("Yes", DialogResult.Yes);
                AddButton("No", DialogResult.No);
            }

            if (buttons == RageMessageBoxDefaultButton.RetryCancel || buttons == RageMessageBoxDefaultButton.OKCancel || buttons == RageMessageBoxDefaultButton.YesNoCancel)
                AddButton("Cancel", DialogResult.Cancel);

            if (buttons == RageMessageBoxDefaultButton.AbortRetryIgnore)
                AddButton("Ignore", DialogResult.Ignore);

            if (buttons == RageMessageBoxDefaultButton.FFFFFUUUUUUUU || buttons == RageMessageBoxDefaultButton.Derp || buttons == RageMessageBoxDefaultButton.LOL)
                AddButton(buttons.ToString(), DialogResult.OK);
        }

        private void AddButton(string caption, DialogResult result)
        {
            var button = new Button
            {
                Text = caption,
                Width = 70,
                Height = 33,
            };

            var parent = this;
            button.Click += (sender, args) =>
            {
                parent.Result = result;
                parent.Close();
            };

            panelButtons.Controls.Add(button);
        }

        private void RageMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}

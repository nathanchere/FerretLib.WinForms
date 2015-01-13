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
    public static class RageMessageBox
    {
        public static DialogResult Show(string text, string title = "", RageMessageBoxButtons buttons = RageMessageBoxButtons.OK, RageMessageBoxIcon icon = RageMessageBoxIcon.Derp)
        {
            var messageBox = new RageMessageBoxForm();
            messageBox.InitializeButtons(buttons);
            messageBox.lblMessage.Text = text;
            // TODO: set image
            messageBox.Text = title;
            messageBox.InitializeDialogLayout();

            messageBox.ShowDialog();
            return messageBox.Result;
        }

        public enum RageMessageBoxButtons
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

        
    }
}

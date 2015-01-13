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
        public static DialogResult Show(string text, string title = "", string detail = "", RageMessageBoxButtons buttons = RageMessageBoxButtons.OK, RageMessageBoxIcon icon = RageMessageBoxIcon.RageMild)
        {
            var messageBox = new RageMessageBoxForm();
            messageBox.InitializeButtons(buttons);
            messageBox.InitializeIcon(icon);
            messageBox.lblMessage.Text = text;
            messageBox.txtDetail.Text = detail;
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
            BiteLip,
            Derp,
            Drool,
            Happy,
            RageFull,
            RageLight,
            RageMild,
            Stressed,
            Troll,
            TrollDerp,
            Unhappy,
            WeepAnxious,
            WeepHappy,
            Suspicious,
            YUNo,
        }
    }
}

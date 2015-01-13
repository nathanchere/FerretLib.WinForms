using System.Windows.Forms;
using FerretLib.WinForms.Properties;

namespace FerretLib.WinForms.Controls
{
    internal class RageMessageBoxForm : Form
    {
        public DialogResult Result { get; private set; }

        public RageMessageBoxForm()
        {
            InitializeComponent();
        }

        public void InitializeButtons(RageMessageBox.RageMessageBoxButtons buttons)
        {
            panelButtons.Controls.Clear();

            if (buttons == RageMessageBox.RageMessageBoxButtons.FFFFFUUUUUUUU || buttons == RageMessageBox.RageMessageBoxButtons.Derp || buttons == RageMessageBox.RageMessageBoxButtons.LOL)
                AddButton(buttons.ToString(), DialogResult.OK);

            if (buttons == RageMessageBox.RageMessageBoxButtons.AbortRetryIgnore)
                AddButton("Ignore", DialogResult.Ignore);

            if (buttons == RageMessageBox.RageMessageBoxButtons.RetryCancel || buttons == RageMessageBox.RageMessageBoxButtons.OKCancel || buttons == RageMessageBox.RageMessageBoxButtons.YesNoCancel)
                AddButton("Cancel", DialogResult.Cancel);

            if (buttons == RageMessageBox.RageMessageBoxButtons.YesNo ||
                buttons == RageMessageBox.RageMessageBoxButtons.YesNoCancel)
            {
                AddButton("No", DialogResult.No);
                AddButton("Yes", DialogResult.Yes);                
            }

            if (buttons == RageMessageBox.RageMessageBoxButtons.AbortRetryIgnore || buttons == RageMessageBox.RageMessageBoxButtons.RetryCancel)
                AddButton("Retry", DialogResult.Retry);            

            if (buttons == RageMessageBox.RageMessageBoxButtons.AbortRetryIgnore)
                AddButton("Abort", DialogResult.Abort);

            if (buttons == RageMessageBox.RageMessageBoxButtons.OK || buttons == RageMessageBox.RageMessageBoxButtons.OKCancel)
                AddButton("OK", DialogResult.OK);
        }

        public void InitializeIcon(RageMessageBox.RageMessageBoxIcon icon)
        {
            switch (icon)
            {
                case RageMessageBox.RageMessageBoxIcon.BiteLip:
                    picIcon.Image = Resources.RageIcon_BiteLip;
                    break;

                case RageMessageBox.RageMessageBoxIcon.Derp:
                    picIcon.Image = Resources.RageIcon_Derp;
                    break;

                case RageMessageBox.RageMessageBoxIcon.Drool:
                    picIcon.Image = Resources.RageIcon_Drool;
                    break;

                case RageMessageBox.RageMessageBoxIcon.Happy:
                    picIcon.Image = Resources.RageIcon_Happy;
                    break;

                case RageMessageBox.RageMessageBoxIcon.RageFull:
                    picIcon.Image = Resources.RageIcon_RageFull;
                    break;

                case RageMessageBox.RageMessageBoxIcon.RageLight:
                    picIcon.Image = Resources.RageIcon_RageLight;
                    break;

                case RageMessageBox.RageMessageBoxIcon.RageMild:
                    picIcon.Image = Resources.RageIcon_RageMild;
                    break;

                case RageMessageBox.RageMessageBoxIcon.Stressed:
                    picIcon.Image = Resources.RageIcon_Stressed;
                    break;

                case RageMessageBox.RageMessageBoxIcon.Troll:
                    picIcon.Image = Resources.RageIcon_Troll;
                    break;

                case RageMessageBox.RageMessageBoxIcon.TrollDerp:
                    picIcon.Image = Resources.RageIcon_TrollDerp;
                    break;

                case RageMessageBox.RageMessageBoxIcon.Unhappy:
                    picIcon.Image = Resources.RageIcon_Unhappy;
                    break;

                case RageMessageBox.RageMessageBoxIcon.WeepAnxious:
                    picIcon.Image = Resources.RageIcon_WeepAnxious;
                    break;

                case RageMessageBox.RageMessageBoxIcon.WeepHappy:
                    picIcon.Image = Resources.RageIcon_WeepHappy;
                    break;

                case RageMessageBox.RageMessageBoxIcon.YUNo:
                    picIcon.Image = Resources.RageIcon_YUNo;
                    break;
                
                case RageMessageBox.RageMessageBoxIcon.Suspicious:
                    picIcon.Image = Resources.RageIcon_Suspicious;
                    break;

                default:
                    return; // TODO: throw here? Mm..
            }
        }

        public void InitializeDialogLayout() // If you're allergic to magic numbers look away now
        {
            Height = lblMessage.Height + 118;
            Width = lblMessage.Width + 200;
            panelButtons.Top = lblMessage.Top + lblMessage.Height + 6;
            if (!string.IsNullOrEmpty(txtDetail.Text))
            {
                txtDetail.Visible = true;
                Height = panelButtons.Height + panelButtons.Top + 10;
            }
        }

        public void AddButton(string caption, DialogResult result)
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

        #region Designer
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDetail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(26, 13);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(128, 128);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(170, 19);
            this.lblMessage.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblMessage.MinimumSize = new System.Drawing.Size(250, 74);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(250, 74);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "aerg";
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(173, 106);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(249, 39);
            this.panelButtons.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(12, 152);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ReadOnly = true;
            this.txtDetail.Size = new System.Drawing.Size(410, 103);
            this.txtDetail.TabIndex = 4;
            // 
            // RageMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RageMessageBoxForm";
            this.Text = "RageMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDetail;

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public PictureBox picIcon;
        public Label lblMessage;
        public FlowLayoutPanel panelButtons;
        public Button button1;
        #endregion
    }
}
using System.Windows.Forms;

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

        public void InitializeDialogLayout() // If you're allergic to magic numbers look away now
        {
            Height = lblMessage.Height + 118;
            Width = lblMessage.Width + 200;
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(170, 20);
            this.lblMessage.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblMessage.MinimumSize = new System.Drawing.Size(250, 74);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(250, 74);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "aerg";
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(173, 107);
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
            // RageMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 153);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RageMessageBoxForm";
            this.Text = "RageMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public PictureBox pictureBox1;
        public Label lblMessage;
        public FlowLayoutPanel panelButtons;
        public Button button1;
        #endregion
    }
}
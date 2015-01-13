namespace FerretLib.WinForms
{
    partial class frmDemoRageMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDialogOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtMainText
            // 
            this.txtMainText.Location = new System.Drawing.Point(68, 12);
            this.txtMainText.Multiline = true;
            this.txtMainText.Name = "txtMainText";
            this.txtMainText.Size = new System.Drawing.Size(325, 138);
            this.txtMainText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main text";
            // 
            // panelDialogOptions
            // 
            this.panelDialogOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDialogOptions.Location = new System.Drawing.Point(401, 11);
            this.panelDialogOptions.Name = "panelDialogOptions";
            this.panelDialogOptions.Size = new System.Drawing.Size(249, 197);
            this.panelDialogOptions.TabIndex = 2;
            // 
            // frmDemoRageMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 229);
            this.Controls.Add(this.panelDialogOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMainText);
            this.Name = "frmDemoRageMessageBox";
            this.Text = "frmDemoRageMessageBox";
            this.Load += new System.EventHandler(this.frmDemoRageMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelDialogOptions;
    }
}
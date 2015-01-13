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
            this.optionsMessageBoxButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnPadText = new System.Windows.Forms.Button();
            this.optionsMessageBoxIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtMainText
            // 
            this.txtMainText.Location = new System.Drawing.Point(68, 12);
            this.txtMainText.Multiline = true;
            this.txtMainText.Name = "txtMainText";
            this.txtMainText.Size = new System.Drawing.Size(244, 138);
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
            // optionsMessageBoxButtons
            // 
            this.optionsMessageBoxButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionsMessageBoxButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.optionsMessageBoxButtons.Location = new System.Drawing.Point(318, 12);
            this.optionsMessageBoxButtons.Name = "optionsMessageBoxButtons";
            this.optionsMessageBoxButtons.Size = new System.Drawing.Size(165, 200);
            this.optionsMessageBoxButtons.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(203, 176);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(109, 36);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "ShowDialog";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnPadText
            // 
            this.btnPadText.Location = new System.Drawing.Point(65, 149);
            this.btnPadText.Name = "btnPadText";
            this.btnPadText.Size = new System.Drawing.Size(247, 21);
            this.btnPadText.TabIndex = 4;
            this.btnPadText.Text = "Append some lorum ipsem";
            this.btnPadText.UseVisualStyleBackColor = true;
            this.btnPadText.Click += new System.EventHandler(this.btnPadText_Click);
            // 
            // flowLayoutPanel1
            // 
            this.optionsMessageBoxIcons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionsMessageBoxIcons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.optionsMessageBoxIcons.Location = new System.Drawing.Point(489, 12);
            this.optionsMessageBoxIcons.Name = "optionsMessageBoxIcons";
            this.optionsMessageBoxIcons.Size = new System.Drawing.Size(165, 200);
            this.optionsMessageBoxIcons.TabIndex = 3;
            // 
            // frmDemoRageMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 333);
            this.Controls.Add(this.optionsMessageBoxIcons);
            this.Controls.Add(this.btnPadText);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.optionsMessageBoxButtons);
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
        private System.Windows.Forms.FlowLayoutPanel optionsMessageBoxButtons;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnPadText;
        private System.Windows.Forms.FlowLayoutPanel optionsMessageBoxIcons;
    }
}
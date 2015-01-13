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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMainText
            // 
            this.txtMainText.Location = new System.Drawing.Point(68, 12);
            this.txtMainText.Multiline = true;
            this.txtMainText.Name = "txtMainText";
            this.txtMainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainText.Size = new System.Drawing.Size(366, 151);
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
            this.optionsMessageBoxButtons.Location = new System.Drawing.Point(440, 12);
            this.optionsMessageBoxButtons.Margin = new System.Windows.Forms.Padding(1);
            this.optionsMessageBoxButtons.Name = "optionsMessageBoxButtons";
            this.optionsMessageBoxButtons.Size = new System.Drawing.Size(149, 559);
            this.optionsMessageBoxButtons.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(68, 452);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(366, 119);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "ShowDialog";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnPadText
            // 
            this.btnPadText.Location = new System.Drawing.Point(68, 169);
            this.btnPadText.Name = "btnPadText";
            this.btnPadText.Size = new System.Drawing.Size(366, 39);
            this.btnPadText.TabIndex = 4;
            this.btnPadText.Text = "Append some lorum ipsem";
            this.btnPadText.UseVisualStyleBackColor = true;
            this.btnPadText.Click += new System.EventHandler(this.btnPadText_Click);
            // 
            // optionsMessageBoxIcons
            // 
            this.optionsMessageBoxIcons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionsMessageBoxIcons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.optionsMessageBoxIcons.Location = new System.Drawing.Point(595, 12);
            this.optionsMessageBoxIcons.Name = "optionsMessageBoxIcons";
            this.optionsMessageBoxIcons.Size = new System.Drawing.Size(149, 559);
            this.optionsMessageBoxIcons.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Append some lorum ipsem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detail text";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(68, 214);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.Size = new System.Drawing.Size(366, 187);
            this.txtDetail.TabIndex = 5;
            // 
            // frmDemoRageMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDetail);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetail;
    }
}
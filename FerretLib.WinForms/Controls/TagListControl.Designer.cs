namespace FerretLib.WinForms.Controls
{
    partial class TagListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tagPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.tagLabelControl1 = new FerretLib.WinForms.Controls.TagLabelControl();
            this.tagLabelControl2 = new FerretLib.WinForms.Controls.TagLabelControl();
            this.tagLabelControl3 = new FerretLib.WinForms.Controls.TagLabelControl();
            this.tagLabelControl4 = new FerretLib.WinForms.Controls.TagLabelControl();
            this.tagPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagPanel
            // 
            this.tagPanel.AutoScroll = true;
            this.tagPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tagPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tagPanel.Controls.Add(this.txtTag);
            this.tagPanel.Controls.Add(this.tagLabelControl1);
            this.tagPanel.Controls.Add(this.tagLabelControl2);
            this.tagPanel.Controls.Add(this.tagLabelControl3);
            this.tagPanel.Controls.Add(this.tagLabelControl4);
            this.tagPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagPanel.Location = new System.Drawing.Point(0, 0);
            this.tagPanel.Name = "tagPanel";
            this.tagPanel.Size = new System.Drawing.Size(277, 84);
            this.tagPanel.TabIndex = 1;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(3, 3);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(144, 20);
            this.txtTag.TabIndex = 0;
            this.txtTag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTag_KeyUp);
            // 
            // tagLabelControl1
            // 
            this.tagLabelControl1.BackColor = System.Drawing.Color.White;
            this.tagLabelControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagLabelControl1.Location = new System.Drawing.Point(153, 3);
            this.tagLabelControl1.MaximumSize = new System.Drawing.Size(81, 20);
            this.tagLabelControl1.MinimumSize = new System.Drawing.Size(81, 20);
            this.tagLabelControl1.Name = "tagLabelControl1";
            this.tagLabelControl1.Size = new System.Drawing.Size(81, 20);
            this.tagLabelControl1.TabIndex = 0;
            this.tagLabelControl1.Value = "instrumental";
            // 
            // tagLabelControl2
            // 
            this.tagLabelControl2.BackColor = System.Drawing.Color.White;
            this.tagLabelControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagLabelControl2.Location = new System.Drawing.Point(3, 29);
            this.tagLabelControl2.MaximumSize = new System.Drawing.Size(50, 20);
            this.tagLabelControl2.MinimumSize = new System.Drawing.Size(50, 20);
            this.tagLabelControl2.Name = "tagLabelControl2";
            this.tagLabelControl2.Size = new System.Drawing.Size(50, 20);
            this.tagLabelControl2.TabIndex = 1;
            this.tagLabelControl2.Value = "metal";
            // 
            // tagLabelControl3
            // 
            this.tagLabelControl3.BackColor = System.Drawing.Color.White;
            this.tagLabelControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagLabelControl3.Location = new System.Drawing.Point(59, 29);
            this.tagLabelControl3.MaximumSize = new System.Drawing.Size(62, 20);
            this.tagLabelControl3.MinimumSize = new System.Drawing.Size(62, 20);
            this.tagLabelControl3.Name = "tagLabelControl3";
            this.tagLabelControl3.Size = new System.Drawing.Size(62, 20);
            this.tagLabelControl3.TabIndex = 2;
            this.tagLabelControl3.Value = "sweden";
            // 
            // tagLabelControl4
            // 
            this.tagLabelControl4.BackColor = System.Drawing.Color.White;
            this.tagLabelControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagLabelControl4.Location = new System.Drawing.Point(127, 29);
            this.tagLabelControl4.MaximumSize = new System.Drawing.Size(107, 20);
            this.tagLabelControl4.MinimumSize = new System.Drawing.Size(107, 20);
            this.tagLabelControl4.Name = "tagLabelControl4";
            this.tagLabelControl4.Size = new System.Drawing.Size(107, 20);
            this.tagLabelControl4.TabIndex = 3;
            this.tagLabelControl4.Value = "progressive metal";
            // 
            // TagListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tagPanel);
            this.Name = "TagListControl";
            this.Size = new System.Drawing.Size(277, 84);
            this.tagPanel.ResumeLayout(false);
            this.tagPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TagLabelControl tagLabelControl1;
        private System.Windows.Forms.FlowLayoutPanel tagPanel;
        private TagLabelControl tagLabelControl2;
        private TagLabelControl tagLabelControl3;
        private TagLabelControl tagLabelControl4;
        private System.Windows.Forms.TextBox txtTag;
    }
}

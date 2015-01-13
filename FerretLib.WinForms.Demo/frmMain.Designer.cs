namespace FerretLib.WinForms
{
    partial class frmMain
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
            this.btnShowColorPicker = new System.Windows.Forms.Button();
            this.btnShowRageMessageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowColorPicker
            // 
            this.btnShowColorPicker.Location = new System.Drawing.Point(12, 12);
            this.btnShowColorPicker.Name = "btnShowColorPicker";
            this.btnShowColorPicker.Size = new System.Drawing.Size(215, 78);
            this.btnShowColorPicker.TabIndex = 0;
            this.btnShowColorPicker.Text = "Color Picker demo";
            this.btnShowColorPicker.UseVisualStyleBackColor = true;
            this.btnShowColorPicker.Click += new System.EventHandler(this.btnShowColorPicker_Click);
            // 
            // btnShowRageMessageBox
            // 
            this.btnShowRageMessageBox.Location = new System.Drawing.Point(12, 96);
            this.btnShowRageMessageBox.Name = "btnShowRageMessageBox";
            this.btnShowRageMessageBox.Size = new System.Drawing.Size(215, 78);
            this.btnShowRageMessageBox.TabIndex = 1;
            this.btnShowRageMessageBox.Text = "RageMessageBox demo";
            this.btnShowRageMessageBox.UseVisualStyleBackColor = true;
            this.btnShowRageMessageBox.Click += new System.EventHandler(this.btnShowRageMessageBox_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 403);
            this.Controls.Add(this.btnShowRageMessageBox);
            this.Controls.Add(this.btnShowColorPicker);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowColorPicker;
        private System.Windows.Forms.Button btnShowRageMessageBox;
    }
}
using FerretLib.WinForms;
using FerretLib.WinForms.Controls;

namespace FerretLib.WinForms.Demo
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tagList = new FerretLib.WinForms.Controls.TagListControl();
            this.SuspendLayout();
            // 
            // tagList
            // 
            this.tagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagList.Location = new System.Drawing.Point(0, 0);
            this.tagList.Name = "tagList";
            this.tagList.Size = new System.Drawing.Size(617, 280);
            this.tagList.TabIndex = 0;
            this.tagList.Tags = ((System.Collections.Generic.List<string>)(resources.GetObject("tagList.Tags")));
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 280);
            this.Controls.Add(this.tagList);
            this.Name = "frmMain";
            this.Text = "FerretLib.WinForms demo";
            this.ResumeLayout(false);

        }

        #endregion

        private TagListControl tagList;
    }
}


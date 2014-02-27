namespace FerretLib.WinForms.Controls
{
    partial class ColourPicker
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
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(17, 6);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(90, 45);
            this.trackBarR.SmallChange = 16;
            this.trackBarR.TabIndex = 0;
            this.trackBarR.TickFrequency = 64;
            this.trackBarR.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // numR
            // 
            this.numR.Location = new System.Drawing.Point(113, 6);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(51, 20);
            this.numR.TabIndex = 1;
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(113, 40);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(51, 20);
            this.numG.TabIndex = 3;
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(17, 41);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(90, 45);
            this.trackBarG.SmallChange = 16;
            this.trackBarG.TabIndex = 2;
            this.trackBarG.TickFrequency = 64;
            this.trackBarG.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(113, 106);
            this.numA.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(51, 20);
            this.numA.TabIndex = 7;
            this.numA.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(17, 106);
            this.trackBarA.Maximum = 255;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(90, 45);
            this.trackBarA.SmallChange = 16;
            this.trackBarA.TabIndex = 6;
            this.trackBarA.TickFrequency = 64;
            this.trackBarA.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarA.Value = 255;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(113, 72);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(51, 20);
            this.numB.TabIndex = 5;
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(17, 74);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(90, 45);
            this.trackBarB.SmallChange = 16;
            this.trackBarB.TabIndex = 4;
            this.trackBarB.TickFrequency = 64;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FerretLib.WinForms.Properties.Resources.transparency;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(178, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 132);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ColourPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.numR);
            this.Controls.Add(this.trackBarR);
            this.Name = "ColourPicker";
            this.Size = new System.Drawing.Size(315, 140);
            this.Load += new System.EventHandler(this.ColourPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}

namespace HHIMS
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editImag = new System.Windows.Forms.Button();
            this.addPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(637, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editImag
            // 
            this.editImag.Location = new System.Drawing.Point(671, 198);
            this.editImag.Name = "editImag";
            this.editImag.Size = new System.Drawing.Size(106, 19);
            this.editImag.TabIndex = 2;
            this.editImag.Text = "Edit Image";
            this.editImag.UseVisualStyleBackColor = true;
            // 
            // addPatient
            // 
            this.addPatient.Location = new System.Drawing.Point(42, 49);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(119, 100);
            this.addPatient.TabIndex = 3;
            this.addPatient.Text = "button1";
            this.addPatient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 593);
            this.Controls.Add(this.addPatient);
            this.Controls.Add(this.editImag);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editImag;
        private System.Windows.Forms.Button addPatient;
    }
}


namespace HHIMS
{
    partial class MainMenu
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
            System.Windows.Forms.Button addPatient;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button5;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editImag = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            addPatient = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addPatient
            // 
            addPatient.BackColor = System.Drawing.Color.Teal;
            addPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addPatient.ForeColor = System.Drawing.Color.Snow;
            addPatient.Image = ((System.Drawing.Image)(resources.GetObject("addPatient.Image")));
            addPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            addPatient.Location = new System.Drawing.Point(12, 112);
            addPatient.Name = "addPatient";
            addPatient.Size = new System.Drawing.Size(118, 39);
            addPatient.TabIndex = 3;
            addPatient.Text = "Add";
            addPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addPatient.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Teal;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.Snow;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.Location = new System.Drawing.Point(12, 300);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 39);
            button1.TabIndex = 4;
            button1.Text = "History";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Teal;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.Snow;
            button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button2.Location = new System.Drawing.Point(165, 204);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(115, 39);
            button2.TabIndex = 5;
            button2.Text = "Add";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Teal;
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.Color.Snow;
            button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button3.Location = new System.Drawing.Point(12, 204);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(118, 39);
            button3.TabIndex = 6;
            button3.Text = "Settings";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Teal;
            button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.ForeColor = System.Drawing.Color.Snow;
            button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button4.Location = new System.Drawing.Point(165, 112);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(115, 39);
            button4.TabIndex = 7;
            button4.Text = "Search";
            button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Teal;
            button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.Color.Snow;
            button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button5.Location = new System.Drawing.Point(165, 300);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(115, 39);
            button5.TabIndex = 8;
            button5.Text = "logs";
            button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(684, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editImag
            // 
            this.editImag.BackColor = System.Drawing.Color.Teal;
            this.editImag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editImag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editImag.Location = new System.Drawing.Point(697, 268);
            this.editImag.Name = "editImag";
            this.editImag.Size = new System.Drawing.Size(106, 39);
            this.editImag.TabIndex = 2;
            this.editImag.Text = "Edit Image";
            this.editImag.UseVisualStyleBackColor = false;
            this.editImag.Click += new System.EventHandler(this.editImag_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(848, 593);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 635;
            this.lineShape1.X2 = 634;
            this.lineShape1.Y1 = 65;
            this.lineShape1.Y2 = 587;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Teal;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(-1, 0);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(849, 52);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "HHIMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(680, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "dd.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(button5);
            this.Controls.Add(button4);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(addPatient);
            this.Controls.Add(this.editImag);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Menue";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editImag;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


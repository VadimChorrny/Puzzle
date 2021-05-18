
namespace puzzle_demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbFirst = new System.Windows.Forms.PictureBox();
            this.pbSecond = new System.Windows.Forms.PictureBox();
            this.pbThird = new System.Windows.Forms.PictureBox();
            this.pbFour = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFirst
            // 
            this.pbFirst.Image = global::puzzle_demo.Properties.Resources.avatar;
            this.pbFirst.Location = new System.Drawing.Point(12, 12);
            this.pbFirst.Name = "pbFirst";
            this.pbFirst.Size = new System.Drawing.Size(265, 275);
            this.pbFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFirst.TabIndex = 0;
            this.pbFirst.TabStop = false;
            this.pbFirst.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbFirst_DragDrop);
            this.pbFirst.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbFirst_DragEnter);
            this.pbFirst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFirst_MouseDown);
            // 
            // pbSecond
            // 
            this.pbSecond.Location = new System.Drawing.Point(287, 12);
            this.pbSecond.Name = "pbSecond";
            this.pbSecond.Size = new System.Drawing.Size(265, 275);
            this.pbSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSecond.TabIndex = 1;
            this.pbSecond.TabStop = false;
            this.pbSecond.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbSecond_DragDrop);
            this.pbSecond.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbSecond_DragEnter);
            this.pbSecond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSecond_MouseDown);
            // 
            // pbThird
            // 
            this.pbThird.Location = new System.Drawing.Point(12, 293);
            this.pbThird.Name = "pbThird";
            this.pbThird.Size = new System.Drawing.Size(265, 275);
            this.pbThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThird.TabIndex = 2;
            this.pbThird.TabStop = false;
            this.pbThird.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbThird_DragDrop);
            this.pbThird.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbThird_DragEnter);
            this.pbThird.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbThird_MouseDown);
            // 
            // pbFour
            // 
            this.pbFour.Location = new System.Drawing.Point(283, 293);
            this.pbFour.Name = "pbFour";
            this.pbFour.Size = new System.Drawing.Size(265, 275);
            this.pbFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFour.TabIndex = 3;
            this.pbFour.TabStop = false;
            this.pbFour.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbFour_DragDrop);
            this.pbFour.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbFour_DragEnter);
            this.pbFour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFour_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(536, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbFour);
            this.Controls.Add(this.pbThird);
            this.Controls.Add(this.pbSecond);
            this.Controls.Add(this.pbFirst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Puzzle";
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFirst;
        private System.Windows.Forms.PictureBox pbSecond;
        private System.Windows.Forms.PictureBox pbThird;
        private System.Windows.Forms.PictureBox pbFour;
        private System.Windows.Forms.Button button1;
    }
}


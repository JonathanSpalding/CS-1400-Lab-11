namespace Lab11
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
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.side_a = new System.Windows.Forms.Label();
            this.side_b = new System.Windows.Forms.Label();
            this.side_c = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(41, 12);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 0;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(41, 38);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 1;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(41, 67);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab11.Properties.Resources.Right_Triangle1;
            this.pictureBox1.Location = new System.Drawing.Point(173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // side_a
            // 
            this.side_a.AutoSize = true;
            this.side_a.Location = new System.Drawing.Point(13, 12);
            this.side_a.Name = "side_a";
            this.side_a.Size = new System.Drawing.Size(13, 13);
            this.side_a.TabIndex = 5;
            this.side_a.Text = "a";
            // 
            // side_b
            // 
            this.side_b.AutoSize = true;
            this.side_b.Location = new System.Drawing.Point(12, 38);
            this.side_b.Name = "side_b";
            this.side_b.Size = new System.Drawing.Size(13, 13);
            this.side_b.TabIndex = 6;
            this.side_b.Text = "b";
            // 
            // side_c
            // 
            this.side_c.AutoSize = true;
            this.side_c.Location = new System.Drawing.Point(13, 67);
            this.side_c.Name = "side_c";
            this.side_c.Size = new System.Drawing.Size(13, 13);
            this.side_c.TabIndex = 7;
            this.side_c.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 153);
            this.Controls.Add(this.side_c);
            this.Controls.Add(this.side_b);
            this.Controls.Add(this.side_a);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label side_a;
        private System.Windows.Forms.Label side_b;
        private System.Windows.Forms.Label side_c;
    }
}


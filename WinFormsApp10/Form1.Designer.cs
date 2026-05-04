namespace WinFormsApp10
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
            pictureBox1 = new PictureBox();
            b1 = new Button();
            b2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.George_Floyd;
            pictureBox1.Location = new Point(275, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.SizeModeChanged += pictureBox1_SizeModeChanged;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 14F);
            b1.Location = new Point(275, 380);
            b1.Name = "b1";
            b1.Size = new Size(120, 68);
            b1.TabIndex = 1;
            b1.Text = "НАЗАД";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 14F);
            b2.Location = new Point(532, 380);
            b2.Name = "b2";
            b2.Size = new Size(120, 68);
            b2.TabIndex = 2;
            b2.Text = "ВПЕРЕД";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 846);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button b1;
        private Button b2;
    }
}

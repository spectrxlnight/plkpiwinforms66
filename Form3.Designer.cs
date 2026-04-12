namespace WinFormsApp1
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelPhrase = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.labelPhrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPhrase.Location = new System.Drawing.Point(28, 35);
            this.labelPhrase.Name = "labelPhrase";
            this.labelPhrase.Size = new System.Drawing.Size(373, 91);
            this.labelPhrase.TabIndex = 0;
            this.labelPhrase.Text = "Працюй далі!";
            this.labelPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonNext.Location = new System.Drawing.Point(137, 154);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(144, 39);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Наступний напис";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 233);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelPhrase);
            this.Name = "Form3";
            this.Text = "Зміна напису";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelPhrase;
        private System.Windows.Forms.Button buttonNext;
    }
}

namespace WinFormsApp1
{
    partial class Form2
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxHryvnia = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelEUR = new System.Windows.Forms.Label();
            this.labelPLN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(29, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(143, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Введіть суму в грн:";
            this.textBoxHryvnia.Location = new System.Drawing.Point(32, 61);
            this.textBoxHryvnia.Name = "textBoxHryvnia";
            this.textBoxHryvnia.Size = new System.Drawing.Size(196, 22);
            this.textBoxHryvnia.TabIndex = 1;
            this.buttonConvert.Location = new System.Drawing.Point(32, 101);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(130, 35);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Конвертувати";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(29, 165);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(62, 16);
            this.labelUSD.TabIndex = 3;
            this.labelUSD.Text = "Долари:";
            this.labelEUR.AutoSize = true;
            this.labelEUR.Location = new System.Drawing.Point(29, 197);
            this.labelEUR.Name = "labelEUR";
            this.labelEUR.Size = new System.Drawing.Size(45, 16);
            this.labelEUR.TabIndex = 4;
            this.labelEUR.Text = "Євро:";
            this.labelPLN.AutoSize = true;
            this.labelPLN.Location = new System.Drawing.Point(29, 229);
            this.labelPLN.Name = "labelPLN";
            this.labelPLN.Size = new System.Drawing.Size(45, 16);
            this.labelPLN.TabIndex = 5;
            this.labelPLN.Text = "Злоті:";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 292);
            this.Controls.Add(this.labelPLN);
            this.Controls.Add(this.labelEUR);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxHryvnia);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form2";
            this.Text = "Конвертер валют";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxHryvnia;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.Label labelEUR;
        private System.Windows.Forms.Label labelPLN;
    }
}

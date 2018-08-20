namespace EuroDollarConverter
{
    partial class EuroDollarConverter
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
            this.EuroLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEuro = new System.Windows.Forms.TextBox();
            this.textBoxDollar = new System.Windows.Forms.TextBox();
            this.numericUpDownKoers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.KoersLabel = new System.Windows.Forms.Label();
            this.buttonEuroToDollar = new System.Windows.Forms.Button();
            this.buttonDollarToEuro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoers)).BeginInit();
            this.SuspendLayout();
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroLabel.Location = new System.Drawing.Point(50, 75);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(70, 76);
            this.EuroLabel.TabIndex = 0;
            this.EuroLabel.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "$";
            // 
            // textBoxEuro
            // 
            this.textBoxEuro.Location = new System.Drawing.Point(126, 108);
            this.textBoxEuro.Name = "textBoxEuro";
            this.textBoxEuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuro.TabIndex = 1;
            this.textBoxEuro.Text = "1";
            // 
            // textBoxDollar
            // 
            this.textBoxDollar.Location = new System.Drawing.Point(290, 108);
            this.textBoxDollar.Name = "textBoxDollar";
            this.textBoxDollar.Size = new System.Drawing.Size(100, 20);
            this.textBoxDollar.TabIndex = 4;
            this.textBoxDollar.Text = "1";
            this.textBoxDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownKoers
            // 
            this.numericUpDownKoers.DecimalPlaces = 2;
            this.numericUpDownKoers.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownKoers.Location = new System.Drawing.Point(284, 164);
            this.numericUpDownKoers.Name = "numericUpDownKoers";
            this.numericUpDownKoers.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownKoers.TabIndex = 5;
            this.numericUpDownKoers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // KoersLabel
            // 
            this.KoersLabel.AutoSize = true;
            this.KoersLabel.Location = new System.Drawing.Point(205, 166);
            this.KoersLabel.Name = "KoersLabel";
            this.KoersLabel.Size = new System.Drawing.Size(79, 13);
            this.KoersLabel.TabIndex = 6;
            this.KoersLabel.Text = "Koers: 1 eu = $";
            // 
            // buttonEuroToDollar
            // 
            this.buttonEuroToDollar.AutoSize = true;
            this.buttonEuroToDollar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEuroToDollar.Location = new System.Drawing.Point(261, 108);
            this.buttonEuroToDollar.Name = "buttonEuroToDollar";
            this.buttonEuroToDollar.Size = new System.Drawing.Size(23, 23);
            this.buttonEuroToDollar.TabIndex = 3;
            this.buttonEuroToDollar.Text = ">";
            this.buttonEuroToDollar.UseVisualStyleBackColor = true;
            this.buttonEuroToDollar.Click += new System.EventHandler(this.buttonDollarToEuro_Click);
            // 
            // buttonDollarToEuro
            // 
            this.buttonDollarToEuro.AutoSize = true;
            this.buttonDollarToEuro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDollarToEuro.Location = new System.Drawing.Point(232, 108);
            this.buttonDollarToEuro.Name = "buttonDollarToEuro";
            this.buttonDollarToEuro.Size = new System.Drawing.Size(23, 23);
            this.buttonDollarToEuro.TabIndex = 2;
            this.buttonDollarToEuro.Text = "<";
            this.buttonDollarToEuro.UseVisualStyleBackColor = true;
            this.buttonDollarToEuro.Click += new System.EventHandler(this.buttonEuroToDollar_Click);
            // 
            // EuroDollarConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 260);
            this.Controls.Add(this.buttonDollarToEuro);
            this.Controls.Add(this.buttonEuroToDollar);
            this.Controls.Add(this.KoersLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownKoers);
            this.Controls.Add(this.textBoxDollar);
            this.Controls.Add(this.textBoxEuro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EuroLabel);
            this.Name = "EuroDollarConverter";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEuro;
        private System.Windows.Forms.TextBox textBoxDollar;
        private System.Windows.Forms.NumericUpDown numericUpDownKoers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KoersLabel;
        private System.Windows.Forms.Button buttonEuroToDollar;
        private System.Windows.Forms.Button buttonDollarToEuro;
    }
}


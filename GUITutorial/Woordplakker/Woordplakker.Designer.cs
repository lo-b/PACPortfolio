namespace Woordplakker
{
    partial class Woordplakker
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
            this.textBoxWoord = new System.Windows.Forms.TextBox();
            this.textBoxAantal = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.WoordLabel = new System.Windows.Forms.Label();
            this.AantalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxWoord
            // 
            this.textBoxWoord.Location = new System.Drawing.Point(89, 117);
            this.textBoxWoord.Name = "textBoxWoord";
            this.textBoxWoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxWoord.TabIndex = 0;
            // 
            // textBoxAantal
            // 
            this.textBoxAantal.Location = new System.Drawing.Point(234, 117);
            this.textBoxAantal.Name = "textBoxAantal";
            this.textBoxAantal.Size = new System.Drawing.Size(100, 20);
            this.textBoxAantal.TabIndex = 1;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(377, 114);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // WoordLabel
            // 
            this.WoordLabel.AutoSize = true;
            this.WoordLabel.Location = new System.Drawing.Point(89, 98);
            this.WoordLabel.Name = "WoordLabel";
            this.WoordLabel.Size = new System.Drawing.Size(39, 13);
            this.WoordLabel.TabIndex = 4;
            this.WoordLabel.Text = "Woord";
            // 
            // AantalLabel
            // 
            this.AantalLabel.AutoSize = true;
            this.AantalLabel.Location = new System.Drawing.Point(231, 98);
            this.AantalLabel.Name = "AantalLabel";
            this.AantalLabel.Size = new System.Drawing.Size(37, 13);
            this.AantalLabel.TabIndex = 5;
            this.AantalLabel.Text = "Aantal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 291);
            this.Controls.Add(this.AantalLabel);
            this.Controls.Add(this.WoordLabel);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.textBoxAantal);
            this.Controls.Add(this.textBoxWoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWoord;
        private System.Windows.Forms.TextBox textBoxAantal;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label WoordLabel;
        private System.Windows.Forms.Label AantalLabel;
    }
}


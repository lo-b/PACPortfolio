namespace Haxor
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
            this.buttonHaxor = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonHaxor
            // 
            this.buttonHaxor.Location = new System.Drawing.Point(227, 271);
            this.buttonHaxor.Name = "buttonHaxor";
            this.buttonHaxor.Size = new System.Drawing.Size(75, 23);
            this.buttonHaxor.TabIndex = 0;
            this.buttonHaxor.Text = "Haxor!";
            this.buttonHaxor.UseVisualStyleBackColor = true;
            this.buttonHaxor.Click += new System.EventHandler(this.buttonHaxor_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(378, 158);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 17);
            this.labelOutput.TabIndex = 1;
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(143, 158);
            this.textBoxUserInput.Multiline = true;
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(229, 107);
            this.textBoxUserInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxUserInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonHaxor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHaxor;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxUserInput;
    }
}


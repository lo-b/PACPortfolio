namespace IndexVanE
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
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonStartESearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(271, 132);
            this.textBoxUserInput.Multiline = true;
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(261, 176);
            this.textBoxUserInput.TabIndex = 0;
            this.textBoxUserInput.Text = "Type hier uw text";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(556, 210);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 17);
            this.labelOutput.TabIndex = 1;
            // 
            // buttonStartESearch
            // 
            this.buttonStartESearch.Location = new System.Drawing.Point(361, 314);
            this.buttonStartESearch.Name = "buttonStartESearch";
            this.buttonStartESearch.Size = new System.Drawing.Size(90, 23);
            this.buttonStartESearch.TabIndex = 2;
            this.buttonStartESearch.Text = "Zoek index";
            this.buttonStartESearch.UseVisualStyleBackColor = true;
            this.buttonStartESearch.Click += new System.EventHandler(this.buttonStartESearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartESearch);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxUserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonStartESearch;
    }
}


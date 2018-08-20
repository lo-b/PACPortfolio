namespace Tekstverwerker
{
    partial class Tekstverwerker
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
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(255, 522);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(93, 40);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(12, 12);
            this.FileTextBox.Multiline = true;
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(773, 479);
            this.FileTextBox.TabIndex = 1;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(448, 522);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(93, 40);
            this.SaveFileButton.TabIndex = 2;
            this.SaveFileButton.Text = "Save";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // Tekstverwerker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 590);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "Tekstverwerker";
            this.Text = "Tekstverwerker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button SaveFileButton;
    }
}


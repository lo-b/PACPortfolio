namespace HalloJij
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
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonVrouw = new System.Windows.Forms.RadioButton();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.buttonShowMsgBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(443, 233);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(56, 21);
            this.radioButtonMan.TabIndex = 0;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonVrouw
            // 
            this.radioButtonVrouw.AutoSize = true;
            this.radioButtonVrouw.Location = new System.Drawing.Point(325, 233);
            this.radioButtonVrouw.Name = "radioButtonVrouw";
            this.radioButtonVrouw.Size = new System.Drawing.Size(68, 21);
            this.radioButtonVrouw.TabIndex = 1;
            this.radioButtonVrouw.TabStop = true;
            this.radioButtonVrouw.Text = "Vrouw";
            this.radioButtonVrouw.UseVisualStyleBackColor = true;
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserInput.Location = new System.Drawing.Point(325, 170);
            this.textBoxUserInput.Multiline = true;
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(174, 57);
            this.textBoxUserInput.TabIndex = 2;
            this.textBoxUserInput.Text = "Type hier uw voor- en achternaam";
            // 
            // buttonShowMsgBox
            // 
            this.buttonShowMsgBox.AutoSize = true;
            this.buttonShowMsgBox.Location = new System.Drawing.Point(371, 260);
            this.buttonShowMsgBox.Name = "buttonShowMsgBox";
            this.buttonShowMsgBox.Size = new System.Drawing.Size(84, 27);
            this.buttonShowMsgBox.TabIndex = 3;
            this.buttonShowMsgBox.Text = "Begroeten";
            this.buttonShowMsgBox.UseVisualStyleBackColor = true;
            this.buttonShowMsgBox.Click += new System.EventHandler(this.buttonShowMsgBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowMsgBox);
            this.Controls.Add(this.textBoxUserInput);
            this.Controls.Add(this.radioButtonVrouw);
            this.Controls.Add(this.radioButtonMan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.RadioButton radioButtonVrouw;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Button buttonShowMsgBox;
    }
}


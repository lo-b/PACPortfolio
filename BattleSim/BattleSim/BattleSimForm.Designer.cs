namespace BattleSim
{
    partial class BattleSimForm
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
            this.playerTwoAttackBtn = new System.Windows.Forms.Button();
            this.playerOneAttackBtn = new System.Windows.Forms.Button();
            this.playerOnePicBox = new System.Windows.Forms.PictureBox();
            this.playerTwoPicBox = new System.Windows.Forms.PictureBox();
            this.healthLblPlayerOne = new System.Windows.Forms.Label();
            this.healthLblPlayerTwo = new System.Windows.Forms.Label();
            this.healthBarPlayerOne = new System.Windows.Forms.ProgressBar();
            this.healthBarPlayerTwo = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.playerOnePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerTwoAttackBtn
            // 
            this.playerTwoAttackBtn.Enabled = false;
            this.playerTwoAttackBtn.Location = new System.Drawing.Point(519, 377);
            this.playerTwoAttackBtn.Name = "playerTwoAttackBtn";
            this.playerTwoAttackBtn.Size = new System.Drawing.Size(217, 23);
            this.playerTwoAttackBtn.TabIndex = 3;
            this.playerTwoAttackBtn.Text = "Attack!";
            this.playerTwoAttackBtn.UseVisualStyleBackColor = true;
            this.playerTwoAttackBtn.Click += new System.EventHandler(this.playerTwoAttackBtn_Click);
            // 
            // playerOneAttackBtn
            // 
            this.playerOneAttackBtn.Enabled = false;
            this.playerOneAttackBtn.Location = new System.Drawing.Point(109, 377);
            this.playerOneAttackBtn.Name = "playerOneAttackBtn";
            this.playerOneAttackBtn.Size = new System.Drawing.Size(217, 23);
            this.playerOneAttackBtn.TabIndex = 4;
            this.playerOneAttackBtn.Text = "Attack!";
            this.playerOneAttackBtn.UseVisualStyleBackColor = true;
            this.playerOneAttackBtn.Click += new System.EventHandler(this.playerOneAttackBtn_Click);
            // 
            // playerOnePicBox
            // 
            this.playerOnePicBox.Image = global::BattleSim.Properties.Resources.nightElfArcher;
            this.playerOnePicBox.InitialImage = null;
            this.playerOnePicBox.Location = new System.Drawing.Point(49, 27);
            this.playerOnePicBox.Name = "playerOnePicBox";
            this.playerOnePicBox.Size = new System.Drawing.Size(330, 344);
            this.playerOnePicBox.TabIndex = 5;
            this.playerOnePicBox.TabStop = false;
            // 
            // playerTwoPicBox
            // 
            this.playerTwoPicBox.Image = global::BattleSim.Properties.Resources.orc;
            this.playerTwoPicBox.Location = new System.Drawing.Point(462, 27);
            this.playerTwoPicBox.Name = "playerTwoPicBox";
            this.playerTwoPicBox.Size = new System.Drawing.Size(330, 344);
            this.playerTwoPicBox.TabIndex = 0;
            this.playerTwoPicBox.TabStop = false;
            // 
            // healthLblPlayerOne
            // 
            this.healthLblPlayerOne.Location = new System.Drawing.Point(109, 403);
            this.healthLblPlayerOne.Name = "healthLblPlayerOne";
            this.healthLblPlayerOne.Size = new System.Drawing.Size(217, 15);
            this.healthLblPlayerOne.TabIndex = 6;
            this.healthLblPlayerOne.Text = "playerOneHealth";
            this.healthLblPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthLblPlayerTwo
            // 
            this.healthLblPlayerTwo.Location = new System.Drawing.Point(519, 403);
            this.healthLblPlayerTwo.Name = "healthLblPlayerTwo";
            this.healthLblPlayerTwo.Size = new System.Drawing.Size(217, 15);
            this.healthLblPlayerTwo.TabIndex = 7;
            this.healthLblPlayerTwo.Text = "playerTwoHealth";
            this.healthLblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthBarPlayerOne
            // 
            this.healthBarPlayerOne.Location = new System.Drawing.Point(109, 421);
            this.healthBarPlayerOne.Name = "healthBarPlayerOne";
            this.healthBarPlayerOne.Size = new System.Drawing.Size(217, 23);
            this.healthBarPlayerOne.Step = 1;
            this.healthBarPlayerOne.TabIndex = 8;
            this.healthBarPlayerOne.Value = 100;
            // 
            // healthBarPlayerTwo
            // 
            this.healthBarPlayerTwo.Location = new System.Drawing.Point(519, 421);
            this.healthBarPlayerTwo.Name = "healthBarPlayerTwo";
            this.healthBarPlayerTwo.Size = new System.Drawing.Size(217, 23);
            this.healthBarPlayerTwo.Step = 1;
            this.healthBarPlayerTwo.TabIndex = 9;
            this.healthBarPlayerTwo.Value = 100;
            // 
            // BattleSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 484);
            this.Controls.Add(this.healthBarPlayerTwo);
            this.Controls.Add(this.healthBarPlayerOne);
            this.Controls.Add(this.healthLblPlayerTwo);
            this.Controls.Add(this.healthLblPlayerOne);
            this.Controls.Add(this.playerOnePicBox);
            this.Controls.Add(this.playerOneAttackBtn);
            this.Controls.Add(this.playerTwoAttackBtn);
            this.Controls.Add(this.playerTwoPicBox);
            this.Name = "BattleSimForm";
            this.Text = "BattleSim";
            ((System.ComponentModel.ISupportInitialize)(this.playerOnePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerTwoPicBox;
        private System.Windows.Forms.Button playerTwoAttackBtn;
        private System.Windows.Forms.Button playerOneAttackBtn;
        private System.Windows.Forms.PictureBox playerOnePicBox;
        private System.Windows.Forms.Label healthLblPlayerOne;
        private System.Windows.Forms.Label healthLblPlayerTwo;
        private System.Windows.Forms.ProgressBar healthBarPlayerOne;
        private System.Windows.Forms.ProgressBar healthBarPlayerTwo;
    }
}


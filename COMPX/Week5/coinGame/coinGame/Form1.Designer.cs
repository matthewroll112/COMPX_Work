namespace coinGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxL1 = new System.Windows.Forms.PictureBox();
            this.radioButtonHeads = new System.Windows.Forms.RadioButton();
            this.radioButtonTails = new System.Windows.Forms.RadioButton();
            this.buttonFlip = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxR1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxL2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(12, 12);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(163, 20);
            this.textBoxBalance.TabIndex = 0;
            this.textBoxBalance.Text = "Balance: $";
            // 
            // textBoxBet
            // 
            this.textBoxBet.Location = new System.Drawing.Point(341, 346);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(129, 20);
            this.textBoxBet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bet Amount";
            // 
            // pictureBoxL1
            // 
            this.pictureBoxL1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxL1.Image")));
            this.pictureBoxL1.Location = new System.Drawing.Point(226, 114);
            this.pictureBoxL1.Name = "pictureBoxL1";
            this.pictureBoxL1.Size = new System.Drawing.Size(176, 176);
            this.pictureBoxL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxL1.TabIndex = 3;
            this.pictureBoxL1.TabStop = false;
            // 
            // radioButtonHeads
            // 
            this.radioButtonHeads.AutoSize = true;
            this.radioButtonHeads.Location = new System.Drawing.Point(245, 379);
            this.radioButtonHeads.Name = "radioButtonHeads";
            this.radioButtonHeads.Size = new System.Drawing.Size(56, 17);
            this.radioButtonHeads.TabIndex = 4;
            this.radioButtonHeads.TabStop = true;
            this.radioButtonHeads.Text = "Heads";
            this.radioButtonHeads.UseVisualStyleBackColor = true;
            // 
            // radioButtonTails
            // 
            this.radioButtonTails.AutoSize = true;
            this.radioButtonTails.Location = new System.Drawing.Point(245, 411);
            this.radioButtonTails.Name = "radioButtonTails";
            this.radioButtonTails.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTails.TabIndex = 5;
            this.radioButtonTails.TabStop = true;
            this.radioButtonTails.Text = "Tails";
            this.radioButtonTails.UseVisualStyleBackColor = true;
            // 
            // buttonFlip
            // 
            this.buttonFlip.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFlip.Location = new System.Drawing.Point(341, 379);
            this.buttonFlip.Name = "buttonFlip";
            this.buttonFlip.Size = new System.Drawing.Size(129, 49);
            this.buttonFlip.TabIndex = 6;
            this.buttonFlip.Text = "Flip Coins";
            this.buttonFlip.UseVisualStyleBackColor = false;
            this.buttonFlip.Click += new System.EventHandler(this.buttonFlip_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(691, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 35);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxR1
            // 
            this.pictureBoxR1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxR1.Image")));
            this.pictureBoxR1.Location = new System.Drawing.Point(408, 114);
            this.pictureBoxR1.Name = "pictureBoxR1";
            this.pictureBoxR1.Size = new System.Drawing.Size(176, 176);
            this.pictureBoxR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxR1.TabIndex = 8;
            this.pictureBoxR1.TabStop = false;
            // 
            // pictureBoxL2
            // 
            this.pictureBoxL2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxL2.Image")));
            this.pictureBoxL2.Location = new System.Drawing.Point(226, 114);
            this.pictureBoxL2.Name = "pictureBoxL2";
            this.pictureBoxL2.Size = new System.Drawing.Size(176, 176);
            this.pictureBoxL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxL2.TabIndex = 9;
            this.pictureBoxL2.TabStop = false;
            // 
            // pictureBoxR2
            // 
            this.pictureBoxR2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxR2.Image")));
            this.pictureBoxR2.Location = new System.Drawing.Point(408, 114);
            this.pictureBoxR2.Name = "pictureBoxR2";
            this.pictureBoxR2.Size = new System.Drawing.Size(176, 176);
            this.pictureBoxR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxR2.TabIndex = 10;
            this.pictureBoxR2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxR2);
            this.Controls.Add(this.pictureBoxL2);
            this.Controls.Add(this.pictureBoxR1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFlip);
            this.Controls.Add(this.radioButtonTails);
            this.Controls.Add(this.radioButtonHeads);
            this.Controls.Add(this.pictureBoxL1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.textBoxBalance);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxL1;
        private System.Windows.Forms.RadioButton radioButtonHeads;
        private System.Windows.Forms.RadioButton radioButtonTails;
        private System.Windows.Forms.Button buttonFlip;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxR1;
        private System.Windows.Forms.PictureBox pictureBoxL2;
        private System.Windows.Forms.PictureBox pictureBoxR2;
    }
}


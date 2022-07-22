namespace Practical
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
            this.buttonDrawPhone = new System.Windows.Forms.Button();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.buttonBalls = new System.Windows.Forms.Button();
            this.textBoxBalls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrawPhone
            // 
            this.buttonDrawPhone.Location = new System.Drawing.Point(12, 11);
            this.buttonDrawPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawPhone.Name = "buttonDrawPhone";
            this.buttonDrawPhone.Size = new System.Drawing.Size(112, 30);
            this.buttonDrawPhone.TabIndex = 3;
            this.buttonDrawPhone.Text = "Draw Phone";
            this.buttonDrawPhone.UseVisualStyleBackColor = true;
            this.buttonDrawPhone.Click += new System.EventHandler(this.buttonDrawPhone_Click);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(214, 11);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(400, 730);
            this.pictureBoxDisplay.TabIndex = 2;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // buttonBalls
            // 
            this.buttonBalls.Location = new System.Drawing.Point(12, 92);
            this.buttonBalls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBalls.Name = "buttonBalls";
            this.buttonBalls.Size = new System.Drawing.Size(112, 30);
            this.buttonBalls.TabIndex = 4;
            this.buttonBalls.Text = "Draw Balls";
            this.buttonBalls.UseVisualStyleBackColor = true;
            this.buttonBalls.Click += new System.EventHandler(this.buttonBalls_Click);
            // 
            // textBoxBalls
            // 
            this.textBoxBalls.Location = new System.Drawing.Point(13, 67);
            this.textBoxBalls.Name = "textBoxBalls";
            this.textBoxBalls.Size = new System.Drawing.Size(139, 20);
            this.textBoxBalls.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount of balls in row";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(17, 699);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 30);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 751);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBalls);
            this.Controls.Add(this.buttonBalls);
            this.Controls.Add(this.buttonDrawPhone);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawPhone;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button buttonBalls;
        private System.Windows.Forms.TextBox textBoxBalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
    }
}


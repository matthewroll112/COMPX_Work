namespace hardAsConcrete
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxKG = new System.Windows.Forms.TextBox();
            this.textBoxBags = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(190, 69);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.ReadOnly = true;
            this.textBoxVolume.Size = new System.Drawing.Size(411, 27);
            this.textBoxVolume.TabIndex = 0;
            // 
            // textBoxKG
            // 
            this.textBoxKG.Location = new System.Drawing.Point(190, 125);
            this.textBoxKG.Name = "textBoxKG";
            this.textBoxKG.ReadOnly = true;
            this.textBoxKG.Size = new System.Drawing.Size(411, 27);
            this.textBoxKG.TabIndex = 1;
            // 
            // textBoxBags
            // 
            this.textBoxBags.Location = new System.Drawing.Point(190, 184);
            this.textBoxBags.Name = "textBoxBags";
            this.textBoxBags.ReadOnly = true;
            this.textBoxBags.Size = new System.Drawing.Size(411, 27);
            this.textBoxBags.TabIndex = 2;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(190, 243);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(411, 27);
            this.textBoxCost.TabIndex = 3;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(190, 318);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(185, 27);
            this.textBoxLength.TabIndex = 4;
            this.textBoxLength.Text = "Input Length Here (m):";
            this.textBoxLength.Click += new System.EventHandler(this.textBoxLength_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(415, 318);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(186, 27);
            this.textBoxWidth.TabIndex = 5;
            this.textBoxWidth.Text = "Input Width Here (m):";
            this.textBoxWidth.Click += new System.EventHandler(this.textBoxWidth_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCalculate.Location = new System.Drawing.Point(190, 375);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(185, 47);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate Cost";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonClear.Location = new System.Drawing.Point(416, 375);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(185, 47);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(612, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(185, 47);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxBags);
            this.Controls.Add(this.textBoxKG);
            this.Controls.Add(this.textBoxVolume);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxVolume;
        private TextBox textBoxKG;
        private TextBox textBoxBags;
        private TextBox textBoxCost;
        private TextBox textBoxLength;
        private TextBox textBoxWidth;
        private Button buttonCalculate;
        private Button buttonClear;
        private Button buttonExit;
    }
}
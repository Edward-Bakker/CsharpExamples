namespace FormsExample
{
    partial class FormExample
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
            this.plusInputL = new System.Windows.Forms.NumericUpDown();
            this.plusInputR = new System.Windows.Forms.NumericUpDown();
            this.plusLabel = new System.Windows.Forms.Label();
            this.plusEqualsLabel = new System.Windows.Forms.Label();
            this.plusOutputLabel = new System.Windows.Forms.Label();
            this.plusCalculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plusInputL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusInputR)).BeginInit();
            this.SuspendLayout();
            // 
            // plusInputL
            // 
            this.plusInputL.Location = new System.Drawing.Point(37, 43);
            this.plusInputL.Name = "plusInputL";
            this.plusInputL.Size = new System.Drawing.Size(120, 23);
            this.plusInputL.TabIndex = 0;
            // 
            // plusInputR
            // 
            this.plusInputR.Location = new System.Drawing.Point(183, 43);
            this.plusInputR.Name = "plusInputR";
            this.plusInputR.Size = new System.Drawing.Size(120, 23);
            this.plusInputR.TabIndex = 0;
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plusLabel.Location = new System.Drawing.Point(161, 43);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(21, 21);
            this.plusLabel.TabIndex = 1;
            this.plusLabel.Text = "+";
            // 
            // plusEqualsLabel
            // 
            this.plusEqualsLabel.AutoSize = true;
            this.plusEqualsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plusEqualsLabel.Location = new System.Drawing.Point(309, 43);
            this.plusEqualsLabel.Name = "plusEqualsLabel";
            this.plusEqualsLabel.Size = new System.Drawing.Size(21, 21);
            this.plusEqualsLabel.TabIndex = 1;
            this.plusEqualsLabel.Text = "=";
            // 
            // plusOutputLabel
            // 
            this.plusOutputLabel.AutoSize = true;
            this.plusOutputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plusOutputLabel.Location = new System.Drawing.Point(331, 43);
            this.plusOutputLabel.Name = "plusOutputLabel";
            this.plusOutputLabel.Size = new System.Drawing.Size(0, 21);
            this.plusOutputLabel.TabIndex = 1;
            // 
            // plusCalculateButton
            // 
            this.plusCalculateButton.Location = new System.Drawing.Point(442, 40);
            this.plusCalculateButton.Name = "plusCalculateButton";
            this.plusCalculateButton.Size = new System.Drawing.Size(75, 23);
            this.plusCalculateButton.TabIndex = 2;
            this.plusCalculateButton.Text = "Calculate";
            this.plusCalculateButton.UseVisualStyleBackColor = true;
            this.plusCalculateButton.Click += new System.EventHandler(this.plusCalculateButton_Click);
            // 
            // FormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 159);
            this.Controls.Add(this.plusCalculateButton);
            this.Controls.Add(this.plusOutputLabel);
            this.Controls.Add(this.plusEqualsLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.plusInputR);
            this.Controls.Add(this.plusInputL);
            this.Name = "FormExample";
            this.Text = "FormExample";
            ((System.ComponentModel.ISupportInitialize)(this.plusInputL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusInputR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown plusInputL;
        private System.Windows.Forms.NumericUpDown plusInputR;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label plusEqualsLabel;
        private System.Windows.Forms.Label plusOutputLabel;
        private System.Windows.Forms.Button plusCalculateButton;
    }
}


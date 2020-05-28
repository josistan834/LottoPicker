namespace LottoPicker
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(-3, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUCKY LOTTO NUMBER GENERATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the maximum value:";
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(360, 100);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(100, 20);
            this.maxInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter the amount of values:";
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(360, 151);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(100, 20);
            this.numInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "(If invalid or blank, default of 0-45 and 6 values will apply)";
            // 
            // genButton
            // 
            this.genButton.BackColor = System.Drawing.Color.GhostWhite;
            this.genButton.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.genButton.Location = new System.Drawing.Point(126, 220);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(230, 86);
            this.genButton.TabIndex = 6;
            this.genButton.Text = "GENERATE VALUES";
            this.genButton.UseVisualStyleBackColor = false;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.GhostWhite;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(61, 340);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(361, 42);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "YOUR LUCKY NUMBERS WILL APPEAR HERE";
            this.outputBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "LOTTO PICKER!!! GET YOUR LUCKY NUMBERS TODAY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Label outputBox;
    }
}


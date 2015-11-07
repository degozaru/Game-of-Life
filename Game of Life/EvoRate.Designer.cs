namespace Game_of_Life
{
    partial class EvoRate
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
            this.Confirm = new System.Windows.Forms.Button();
            this.xCtr = new System.Windows.Forms.NumericUpDown();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xCtr)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(47, 73);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 20;
            this.Confirm.Text = "Set";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // xCtr
            // 
            this.xCtr.Location = new System.Drawing.Point(57, 47);
            this.xCtr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xCtr.Name = "xCtr";
            this.xCtr.Size = new System.Drawing.Size(55, 20);
            this.xCtr.TabIndex = 19;
            this.xCtr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 20);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(146, 13);
            this.Label.TabIndex = 18;
            this.Label.Text = "How many times per second?";
            // 
            // evoRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 102);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.xCtr);
            this.Controls.Add(this.Label);
            this.Name = "evoRate";
            this.Text = "evoRate";
            ((System.ComponentModel.ISupportInitialize)(this.xCtr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.NumericUpDown xCtr;
        private System.Windows.Forms.Label Label;
    }
}
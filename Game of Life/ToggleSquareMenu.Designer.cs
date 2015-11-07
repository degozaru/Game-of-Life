namespace Game_of_Life
{
    partial class ToggleSquareMenu
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
            this.Label = new System.Windows.Forms.Label();
            this.xCtr = new System.Windows.Forms.NumericUpDown();
            this.yCtr = new System.Windows.Forms.NumericUpDown();
            this.Xlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xCtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCtr)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(24, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(112, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Toggle which square?";
            // 
            // xCtr
            // 
            this.xCtr.Location = new System.Drawing.Point(9, 45);
            this.xCtr.Name = "xCtr";
            this.xCtr.Size = new System.Drawing.Size(55, 20);
            this.xCtr.TabIndex = 1;
            // 
            // yCtr
            // 
            this.yCtr.Location = new System.Drawing.Point(94, 45);
            this.yCtr.Name = "yCtr";
            this.yCtr.Size = new System.Drawing.Size(53, 20);
            this.yCtr.TabIndex = 2;
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(26, 29);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(14, 13);
            this.Xlabel.TabIndex = 3;
            this.Xlabel.Text = "X";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(119, 29);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(14, 13);
            this.Ylabel.TabIndex = 4;
            this.Ylabel.Text = "Y";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(44, 71);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "Toggle";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // ToggleSquareMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 103);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Ylabel);
            this.Controls.Add(this.Xlabel);
            this.Controls.Add(this.yCtr);
            this.Controls.Add(this.xCtr);
            this.Controls.Add(this.Label);
            this.Name = "ToggleSquareMenu";
            this.Text = "ToggleSquareMenu";
            ((System.ComponentModel.ISupportInitialize)(this.xCtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCtr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.NumericUpDown xCtr;
        private System.Windows.Forms.NumericUpDown yCtr;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Button Confirm;
    }
}
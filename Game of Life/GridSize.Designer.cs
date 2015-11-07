namespace Game_of_Life
{
    partial class GridSize
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
            this.Ylabel = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.yCtr = new System.Windows.Forms.NumericUpDown();
            this.xCtr = new System.Windows.Forms.NumericUpDown();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yCtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCtr)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(53, 78);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 11;
            this.Confirm.Text = "Set";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(128, 36);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(14, 13);
            this.Ylabel.TabIndex = 10;
            this.Ylabel.Text = "Y";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(35, 36);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(14, 13);
            this.Xlabel.TabIndex = 9;
            this.Xlabel.Text = "X";
            // 
            // yCtr
            // 
            this.yCtr.Location = new System.Drawing.Point(103, 52);
            this.yCtr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yCtr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yCtr.Name = "yCtr";
            this.yCtr.Size = new System.Drawing.Size(53, 20);
            this.yCtr.TabIndex = 8;
            this.yCtr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xCtr
            // 
            this.xCtr.Location = new System.Drawing.Point(18, 52);
            this.xCtr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xCtr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xCtr.Name = "xCtr";
            this.xCtr.Size = new System.Drawing.Size(55, 20);
            this.xCtr.TabIndex = 7;
            this.xCtr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(50, 20);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(68, 13);
            this.Label.TabIndex = 6;
            this.Label.Text = "Set Grid Size";
            // 
            // GridSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 119);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Ylabel);
            this.Controls.Add(this.Xlabel);
            this.Controls.Add(this.yCtr);
            this.Controls.Add(this.xCtr);
            this.Controls.Add(this.Label);
            this.Name = "GridSize";
            this.Text = "GridSize";
            ((System.ComponentModel.ISupportInitialize)(this.yCtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCtr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.NumericUpDown yCtr;
        private System.Windows.Forms.NumericUpDown xCtr;
        private System.Windows.Forms.Label Label;
    }
}
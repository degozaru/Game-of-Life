namespace Game_of_Life
{
    partial class SurvivalSetting
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
            this.smaxIn = new System.Windows.Forms.NumericUpDown();
            this.sminIn = new System.Windows.Forms.NumericUpDown();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bmaxIn = new System.Windows.Forms.NumericUpDown();
            this.bminIn = new System.Windows.Forms.NumericUpDown();
            this.defaultBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.smaxIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sminIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmaxIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bminIn)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(15, 143);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(63, 23);
            this.Confirm.TabIndex = 17;
            this.Confirm.Text = "Set";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(94, 90);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(37, 13);
            this.Ylabel.TabIndex = 16;
            this.Ylabel.Text = "SMAX";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(12, 90);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(34, 13);
            this.Xlabel.TabIndex = 15;
            this.Xlabel.Text = "SMIN";
            // 
            // smaxIn
            // 
            this.smaxIn.Location = new System.Drawing.Point(97, 106);
            this.smaxIn.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.smaxIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smaxIn.Name = "smaxIn";
            this.smaxIn.Size = new System.Drawing.Size(53, 20);
            this.smaxIn.TabIndex = 14;
            this.smaxIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sminIn
            // 
            this.sminIn.Location = new System.Drawing.Point(12, 106);
            this.sminIn.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sminIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sminIn.Name = "sminIn";
            this.sminIn.Size = new System.Drawing.Size(55, 20);
            this.sminIn.TabIndex = 13;
            this.sminIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(54, 17);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(68, 13);
            this.Label.TabIndex = 12;
            this.Label.Text = "Set Grid Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "BMAX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "BMIN";
            // 
            // bmaxIn
            // 
            this.bmaxIn.Location = new System.Drawing.Point(97, 60);
            this.bmaxIn.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.bmaxIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bmaxIn.Name = "bmaxIn";
            this.bmaxIn.Size = new System.Drawing.Size(53, 20);
            this.bmaxIn.TabIndex = 19;
            this.bmaxIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bminIn
            // 
            this.bminIn.Location = new System.Drawing.Point(12, 60);
            this.bminIn.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.bminIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bminIn.Name = "bminIn";
            this.bminIn.Size = new System.Drawing.Size(55, 20);
            this.bminIn.TabIndex = 18;
            this.bminIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // defaultBut
            // 
            this.defaultBut.Location = new System.Drawing.Point(87, 143);
            this.defaultBut.Name = "defaultBut";
            this.defaultBut.Size = new System.Drawing.Size(63, 23);
            this.defaultBut.TabIndex = 22;
            this.defaultBut.Text = "Defaults";
            this.defaultBut.UseVisualStyleBackColor = true;
            this.defaultBut.Click += new System.EventHandler(this.defaultBut_Click);
            // 
            // SurvivalSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 191);
            this.Controls.Add(this.defaultBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bmaxIn);
            this.Controls.Add(this.bminIn);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Ylabel);
            this.Controls.Add(this.Xlabel);
            this.Controls.Add(this.smaxIn);
            this.Controls.Add(this.sminIn);
            this.Controls.Add(this.Label);
            this.Name = "SurvivalSetting";
            this.Text = "SurvivalSetting";
            ((System.ComponentModel.ISupportInitialize)(this.smaxIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sminIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmaxIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bminIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.NumericUpDown smaxIn;
        private System.Windows.Forms.NumericUpDown sminIn;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bmaxIn;
        private System.Windows.Forms.NumericUpDown bminIn;
        private System.Windows.Forms.Button defaultBut;
    }
}
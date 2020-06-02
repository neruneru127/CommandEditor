namespace CommandEditor.TargetSelect
{
    partial class TargetSelectSettingForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.xLocationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.zLocationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.yLocationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLocationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(261, 325);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(342, 325);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "呼び出し";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // xLocationNumeric
            // 
            this.xLocationNumeric.Location = new System.Drawing.Point(50, 8);
            this.xLocationNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xLocationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xLocationNumeric.Name = "xLocationNumeric";
            this.xLocationNumeric.Size = new System.Drawing.Size(48, 19);
            this.xLocationNumeric.TabIndex = 20;
            this.xLocationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "X";
            // 
            // zLocationNumeric
            // 
            this.zLocationNumeric.Location = new System.Drawing.Point(50, 58);
            this.zLocationNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.zLocationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zLocationNumeric.Name = "zLocationNumeric";
            this.zLocationNumeric.Size = new System.Drawing.Size(48, 19);
            this.zLocationNumeric.TabIndex = 22;
            this.zLocationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Z";
            // 
            // yLocationNumeric
            // 
            this.yLocationNumeric.Location = new System.Drawing.Point(50, 33);
            this.yLocationNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yLocationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yLocationNumeric.Name = "yLocationNumeric";
            this.yLocationNumeric.Size = new System.Drawing.Size(48, 19);
            this.yLocationNumeric.TabIndex = 24;
            this.yLocationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y";
            // 
            // TargetSelectSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 360);
            this.Controls.Add(this.yLocationNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zLocationNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xLocationNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "TargetSelectSettingForm";
            this.Text = "TargetSelectSettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.xLocationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLocationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.NumericUpDown xLocationNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown zLocationNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yLocationNumeric;
        private System.Windows.Forms.Label label2;
    }
}
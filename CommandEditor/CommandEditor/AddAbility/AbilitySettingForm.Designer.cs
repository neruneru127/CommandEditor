namespace CommandEditor.AddAbility
{
    partial class AbilitySettingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AbilityNameTextBox = new System.Windows.Forms.TextBox();
            this.OperationComboBox = new System.Windows.Forms.ComboBox();
            this.AbilityTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SlotCombBox = new System.Windows.Forms.ComboBox();
            this.UUIDMostNumeric = new System.Windows.Forms.NumericUpDown();
            this.UUIDLeastNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UUIDMostNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UUIDLeastNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "能力名";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "能力の種類";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "装備箇所";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "値";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "UUIDMost";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "UUIDLeast";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "演算方法";
            // 
            // AbilityNameTextBox
            // 
            this.AbilityNameTextBox.Location = new System.Drawing.Point(129, 7);
            this.AbilityNameTextBox.Name = "AbilityNameTextBox";
            this.AbilityNameTextBox.Size = new System.Drawing.Size(161, 19);
            this.AbilityNameTextBox.TabIndex = 8;
            // 
            // OperationComboBox
            // 
            this.OperationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationComboBox.FormattingEnabled = true;
            this.OperationComboBox.Location = new System.Drawing.Point(129, 83);
            this.OperationComboBox.Name = "OperationComboBox";
            this.OperationComboBox.Size = new System.Drawing.Size(161, 20);
            this.OperationComboBox.TabIndex = 11;
            // 
            // AbilityTypeComboBox
            // 
            this.AbilityTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AbilityTypeComboBox.FormattingEnabled = true;
            this.AbilityTypeComboBox.Location = new System.Drawing.Point(129, 32);
            this.AbilityTypeComboBox.Name = "AbilityTypeComboBox";
            this.AbilityTypeComboBox.Size = new System.Drawing.Size(161, 20);
            this.AbilityTypeComboBox.TabIndex = 12;
            // 
            // ValueNumeric
            // 
            this.ValueNumeric.DecimalPlaces = 1;
            this.ValueNumeric.Location = new System.Drawing.Point(129, 58);
            this.ValueNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ValueNumeric.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            -2147483648});
            this.ValueNumeric.Name = "ValueNumeric";
            this.ValueNumeric.Size = new System.Drawing.Size(161, 19);
            this.ValueNumeric.TabIndex = 13;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(134, 185);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(215, 185);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SlotCombBox
            // 
            this.SlotCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SlotCombBox.FormattingEnabled = true;
            this.SlotCombBox.Location = new System.Drawing.Point(129, 109);
            this.SlotCombBox.Name = "SlotCombBox";
            this.SlotCombBox.Size = new System.Drawing.Size(161, 20);
            this.SlotCombBox.TabIndex = 17;
            // 
            // UUIDMostNumeric
            // 
            this.UUIDMostNumeric.Location = new System.Drawing.Point(129, 135);
            this.UUIDMostNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UUIDMostNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UUIDMostNumeric.Name = "UUIDMostNumeric";
            this.UUIDMostNumeric.Size = new System.Drawing.Size(161, 19);
            this.UUIDMostNumeric.TabIndex = 18;
            this.UUIDMostNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UUIDLeastNumeric
            // 
            this.UUIDLeastNumeric.Location = new System.Drawing.Point(129, 160);
            this.UUIDLeastNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UUIDLeastNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UUIDLeastNumeric.Name = "UUIDLeastNumeric";
            this.UUIDLeastNumeric.Size = new System.Drawing.Size(161, 19);
            this.UUIDLeastNumeric.TabIndex = 19;
            this.UUIDLeastNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AbilitySettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 214);
            this.Controls.Add(this.UUIDLeastNumeric);
            this.Controls.Add(this.UUIDMostNumeric);
            this.Controls.Add(this.SlotCombBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ValueNumeric);
            this.Controls.Add(this.AbilityTypeComboBox);
            this.Controls.Add(this.OperationComboBox);
            this.Controls.Add(this.AbilityNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AbilitySettingForm";
            this.Text = "AbilitySettingWindow";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UUIDMostNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UUIDLeastNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AbilityNameTextBox;
        private System.Windows.Forms.ComboBox OperationComboBox;
        private System.Windows.Forms.ComboBox AbilityTypeComboBox;
        private System.Windows.Forms.NumericUpDown ValueNumeric;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox SlotCombBox;
        private System.Windows.Forms.NumericUpDown UUIDMostNumeric;
        private System.Windows.Forms.NumericUpDown UUIDLeastNumeric;
    }
}
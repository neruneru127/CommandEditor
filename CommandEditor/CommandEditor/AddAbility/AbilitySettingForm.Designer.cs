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
            this.abilityNameTextBox = new System.Windows.Forms.TextBox();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.abilityTypeComboBox = new System.Windows.Forms.ComboBox();
            this.valueNumeric = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.slotCombBox = new System.Windows.Forms.ComboBox();
            this.uuidMostNumeric = new System.Windows.Forms.NumericUpDown();
            this.uuidLeastNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuidMostNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuidLeastNumeric)).BeginInit();
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
            // abilityNameTextBox
            // 
            this.abilityNameTextBox.Location = new System.Drawing.Point(129, 7);
            this.abilityNameTextBox.Name = "abilityNameTextBox";
            this.abilityNameTextBox.Size = new System.Drawing.Size(161, 19);
            this.abilityNameTextBox.TabIndex = 8;
            // 
            // operationComboBox
            // 
            this.operationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Location = new System.Drawing.Point(129, 83);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(161, 20);
            this.operationComboBox.TabIndex = 11;
            // 
            // abilityTypeComboBox
            // 
            this.abilityTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abilityTypeComboBox.FormattingEnabled = true;
            this.abilityTypeComboBox.Location = new System.Drawing.Point(129, 32);
            this.abilityTypeComboBox.Name = "abilityTypeComboBox";
            this.abilityTypeComboBox.Size = new System.Drawing.Size(161, 20);
            this.abilityTypeComboBox.TabIndex = 12;
            // 
            // valueNumeric
            // 
            this.valueNumeric.DecimalPlaces = 1;
            this.valueNumeric.Location = new System.Drawing.Point(129, 58);
            this.valueNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valueNumeric.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            -2147483648});
            this.valueNumeric.Name = "valueNumeric";
            this.valueNumeric.Size = new System.Drawing.Size(161, 19);
            this.valueNumeric.TabIndex = 13;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(134, 185);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(215, 185);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // slotCombBox
            // 
            this.slotCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slotCombBox.FormattingEnabled = true;
            this.slotCombBox.Location = new System.Drawing.Point(129, 109);
            this.slotCombBox.Name = "slotCombBox";
            this.slotCombBox.Size = new System.Drawing.Size(161, 20);
            this.slotCombBox.TabIndex = 17;
            // 
            // uuidMostNumeric
            // 
            this.uuidMostNumeric.Location = new System.Drawing.Point(129, 135);
            this.uuidMostNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uuidMostNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uuidMostNumeric.Name = "uuidMostNumeric";
            this.uuidMostNumeric.Size = new System.Drawing.Size(161, 19);
            this.uuidMostNumeric.TabIndex = 18;
            this.uuidMostNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uuidLeastNumeric
            // 
            this.uuidLeastNumeric.Location = new System.Drawing.Point(129, 160);
            this.uuidLeastNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uuidLeastNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uuidLeastNumeric.Name = "uuidLeastNumeric";
            this.uuidLeastNumeric.Size = new System.Drawing.Size(161, 19);
            this.uuidLeastNumeric.TabIndex = 19;
            this.uuidLeastNumeric.Value = new decimal(new int[] {
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
            this.Controls.Add(this.uuidLeastNumeric);
            this.Controls.Add(this.uuidMostNumeric);
            this.Controls.Add(this.slotCombBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.valueNumeric);
            this.Controls.Add(this.abilityTypeComboBox);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.abilityNameTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.valueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuidMostNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuidLeastNumeric)).EndInit();
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
        private System.Windows.Forms.TextBox abilityNameTextBox;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.ComboBox abilityTypeComboBox;
        private System.Windows.Forms.NumericUpDown valueNumeric;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox slotCombBox;
        private System.Windows.Forms.NumericUpDown uuidMostNumeric;
        private System.Windows.Forms.NumericUpDown uuidLeastNumeric;
    }
}
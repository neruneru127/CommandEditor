namespace CommandEditor
{
    partial class GiveForm
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemDescTextBox = new System.Windows.Forms.TextBox();
            this.ItemCombBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addAbilityForm = new CommandEditor.AddAbilityForm();
            this.targetSelectForm = new CommandEditor.TargetSelectForm();
            this.ItemLoadButton = new System.Windows.Forms.Button();
            this.enchantForm = new CommandEditor.Enchant.EnchantForm();
            this.ItemNBTButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemCountNumric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCountNumric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "アイテム名";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "アイテムの説明";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(127, 51);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(135, 19);
            this.ItemNameTextBox.TabIndex = 3;
            // 
            // ItemDescTextBox
            // 
            this.ItemDescTextBox.Location = new System.Drawing.Point(127, 76);
            this.ItemDescTextBox.Multiline = true;
            this.ItemDescTextBox.Name = "ItemDescTextBox";
            this.ItemDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemDescTextBox.Size = new System.Drawing.Size(135, 55);
            this.ItemDescTextBox.TabIndex = 4;
            // 
            // ItemCombBox
            // 
            this.ItemCombBox.FormattingEnabled = true;
            this.ItemCombBox.Location = new System.Drawing.Point(128, 25);
            this.ItemCombBox.Name = "ItemCombBox";
            this.ItemCombBox.Size = new System.Drawing.Size(134, 20);
            this.ItemCombBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "アイテムの種類";
            // 
            // ItemSaveButton
            // 
            this.ItemSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemSaveButton.Location = new System.Drawing.Point(499, 255);
            this.ItemSaveButton.Name = "ItemSaveButton";
            this.ItemSaveButton.Size = new System.Drawing.Size(102, 23);
            this.ItemSaveButton.TabIndex = 9;
            this.ItemSaveButton.Text = "アイテム情報保存";
            this.ItemSaveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(24, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "アイテムNBT";
            // 
            // addAbilityForm
            // 
            this.addAbilityForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAbilityForm.Location = new System.Drawing.Point(294, 137);
            this.addAbilityForm.Name = "addAbilityForm";
            this.addAbilityForm.Size = new System.Drawing.Size(433, 107);
            this.addAbilityForm.TabIndex = 13;
            // 
            // targetSelectForm
            // 
            this.targetSelectForm.Location = new System.Drawing.Point(27, 164);
            this.targetSelectForm.Name = "targetSelectForm";
            this.targetSelectForm.Size = new System.Drawing.Size(236, 53);
            this.targetSelectForm.TabIndex = 5;
            // 
            // ItemLoadButton
            // 
            this.ItemLoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemLoadButton.Location = new System.Drawing.Point(607, 255);
            this.ItemLoadButton.Name = "ItemLoadButton";
            this.ItemLoadButton.Size = new System.Drawing.Size(120, 23);
            this.ItemLoadButton.TabIndex = 14;
            this.ItemLoadButton.Text = "アイテム情報呼び出し";
            this.ItemLoadButton.UseVisualStyleBackColor = true;
            // 
            // enchantForm
            // 
            this.enchantForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enchantForm.Location = new System.Drawing.Point(294, 25);
            this.enchantForm.Name = "enchantForm";
            this.enchantForm.Size = new System.Drawing.Size(433, 106);
            this.enchantForm.TabIndex = 15;
            // 
            // ItemNBTButton
            // 
            this.ItemNBTButton.Location = new System.Drawing.Point(171, 221);
            this.ItemNBTButton.Name = "ItemNBTButton";
            this.ItemNBTButton.Size = new System.Drawing.Size(91, 23);
            this.ItemNBTButton.TabIndex = 16;
            this.ItemNBTButton.Text = "NBT設定";
            this.ItemNBTButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "個数";
            // 
            // ItemCountNumric
            // 
            this.ItemCountNumric.Location = new System.Drawing.Point(130, 139);
            this.ItemCountNumric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ItemCountNumric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ItemCountNumric.Name = "ItemCountNumric";
            this.ItemCountNumric.Size = new System.Drawing.Size(132, 19);
            this.ItemCountNumric.TabIndex = 18;
            this.ItemCountNumric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemCountNumric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemNBTButton);
            this.Controls.Add(this.enchantForm);
            this.Controls.Add(this.ItemLoadButton);
            this.Controls.Add(this.addAbilityForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemSaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemCombBox);
            this.Controls.Add(this.targetSelectForm);
            this.Controls.Add(this.ItemDescTextBox);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GiveForm";
            this.Size = new System.Drawing.Size(730, 281);
            ((System.ComponentModel.ISupportInitialize)(this.ItemCountNumric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TextBox ItemDescTextBox;
        private TargetSelectForm targetSelectForm;
        private System.Windows.Forms.ComboBox ItemCombBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ItemSaveButton;
        private System.Windows.Forms.Label label5;
        private AddAbilityForm addAbilityForm;
        private System.Windows.Forms.Button ItemLoadButton;
        private Enchant.EnchantForm enchantForm;
        private System.Windows.Forms.Button ItemNBTButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ItemCountNumric;
    }
}

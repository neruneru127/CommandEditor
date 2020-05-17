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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addAbilityForm1 = new CommandEditor.AddAbilityForm();
            this.targetSelectForm1 = new CommandEditor.TargetSelectForm();
            this.ItemLoadButton = new System.Windows.Forms.Button();
            this.enchantForm1 = new CommandEditor.Enchant.EnchantForm();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 19);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 20);
            this.comboBox1.TabIndex = 6;
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
            this.ItemSaveButton.Location = new System.Drawing.Point(542, 258);
            this.ItemSaveButton.Name = "ItemSaveButton";
            this.ItemSaveButton.Size = new System.Drawing.Size(102, 23);
            this.ItemSaveButton.TabIndex = 9;
            this.ItemSaveButton.Text = "アイテム情報保存";
            this.ItemSaveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "NBT";
            // 
            // addAbilityForm1
            // 
            this.addAbilityForm1.Location = new System.Drawing.Point(317, 137);
            this.addAbilityForm1.Name = "addAbilityForm1";
            this.addAbilityForm1.Size = new System.Drawing.Size(433, 119);
            this.addAbilityForm1.TabIndex = 13;
            // 
            // targetSelectForm1
            // 
            this.targetSelectForm1.Location = new System.Drawing.Point(26, 101);
            this.targetSelectForm1.Name = "targetSelectForm1";
            this.targetSelectForm1.Size = new System.Drawing.Size(238, 53);
            this.targetSelectForm1.TabIndex = 5;
            // 
            // ItemLoadButton
            // 
            this.ItemLoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemLoadButton.Location = new System.Drawing.Point(650, 258);
            this.ItemLoadButton.Name = "ItemLoadButton";
            this.ItemLoadButton.Size = new System.Drawing.Size(120, 23);
            this.ItemLoadButton.TabIndex = 14;
            this.ItemLoadButton.Text = "アイテム情報呼び出し";
            this.ItemLoadButton.UseVisualStyleBackColor = true;
            // 
            // enchantForm1
            // 
            this.enchantForm1.Location = new System.Drawing.Point(317, 25);
            this.enchantForm1.Name = "enchantForm1";
            this.enchantForm1.Size = new System.Drawing.Size(433, 106);
            this.enchantForm1.TabIndex = 15;
            // 
            // GiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enchantForm1);
            this.Controls.Add(this.ItemLoadButton);
            this.Controls.Add(this.addAbilityForm1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemSaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.targetSelectForm1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GiveForm";
            this.Size = new System.Drawing.Size(773, 287);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private TargetSelectForm targetSelectForm1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ItemSaveButton;
        private System.Windows.Forms.Label label5;
        private AddAbilityForm addAbilityForm1;
        private System.Windows.Forms.Button ItemLoadButton;
        private Enchant.EnchantForm enchantForm1;
    }
}

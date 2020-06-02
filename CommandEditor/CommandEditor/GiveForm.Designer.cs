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
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemDescTextBox = new System.Windows.Forms.TextBox();
            this.itemCombBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemLoadButton = new System.Windows.Forms.Button();
            this.itemNBTButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.itemCountNumric = new System.Windows.Forms.NumericUpDown();
            this.itemNBTTextBox = new System.Windows.Forms.TextBox();
            this.hideFlagListBox = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.repairNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.enchantForm = new CommandEditor.Enchant.EnchantForm();
            this.addAbilityForm = new CommandEditor.AddAbilityForm();
            this.targetSelectForm = new CommandEditor.TargetSelectForm();
            ((System.ComponentModel.ISupportInitialize)(this.itemCountNumric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairNumeric)).BeginInit();
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
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(127, 51);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(135, 19);
            this.itemNameTextBox.TabIndex = 3;
            // 
            // itemDescTextBox
            // 
            this.itemDescTextBox.Location = new System.Drawing.Point(127, 76);
            this.itemDescTextBox.Multiline = true;
            this.itemDescTextBox.Name = "itemDescTextBox";
            this.itemDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemDescTextBox.Size = new System.Drawing.Size(135, 55);
            this.itemDescTextBox.TabIndex = 4;
            // 
            // itemCombBox
            // 
            this.itemCombBox.FormattingEnabled = true;
            this.itemCombBox.Location = new System.Drawing.Point(128, 25);
            this.itemCombBox.Name = "itemCombBox";
            this.itemCombBox.Size = new System.Drawing.Size(134, 20);
            this.itemCombBox.TabIndex = 6;
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
            this.ItemSaveButton.Location = new System.Drawing.Point(499, 360);
            this.ItemSaveButton.Name = "ItemSaveButton";
            this.ItemSaveButton.Size = new System.Drawing.Size(102, 23);
            this.ItemSaveButton.TabIndex = 9;
            this.ItemSaveButton.Text = "アイテム情報保存";
            this.ItemSaveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(291, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "アイテムNBT";
            // 
            // ItemLoadButton
            // 
            this.ItemLoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemLoadButton.Location = new System.Drawing.Point(607, 360);
            this.ItemLoadButton.Name = "ItemLoadButton";
            this.ItemLoadButton.Size = new System.Drawing.Size(120, 23);
            this.ItemLoadButton.TabIndex = 14;
            this.ItemLoadButton.Text = "アイテム情報呼び出し";
            this.ItemLoadButton.UseVisualStyleBackColor = true;
            // 
            // itemNBTButton
            // 
            this.itemNBTButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNBTButton.Location = new System.Drawing.Point(707, 296);
            this.itemNBTButton.Name = "itemNBTButton";
            this.itemNBTButton.Size = new System.Drawing.Size(22, 19);
            this.itemNBTButton.TabIndex = 16;
            this.itemNBTButton.Text = "...";
            this.itemNBTButton.UseVisualStyleBackColor = true;
            this.itemNBTButton.Click += new System.EventHandler(this.ItemNBTButton_Click);
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
            // itemCountNumric
            // 
            this.itemCountNumric.Location = new System.Drawing.Point(127, 139);
            this.itemCountNumric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.itemCountNumric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemCountNumric.Name = "itemCountNumric";
            this.itemCountNumric.Size = new System.Drawing.Size(135, 19);
            this.itemCountNumric.TabIndex = 18;
            this.itemCountNumric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemNBTTextBox
            // 
            this.itemNBTTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNBTTextBox.Location = new System.Drawing.Point(372, 296);
            this.itemNBTTextBox.Name = "itemNBTTextBox";
            this.itemNBTTextBox.Size = new System.Drawing.Size(329, 19);
            this.itemNBTTextBox.TabIndex = 19;
            // 
            // hideFlagListBox
            // 
            this.hideFlagListBox.CheckOnClick = true;
            this.hideFlagListBox.FormattingEnabled = true;
            this.hideFlagListBox.Location = new System.Drawing.Point(128, 165);
            this.hideFlagListBox.Name = "hideFlagListBox";
            this.hideFlagListBox.Size = new System.Drawing.Size(134, 74);
            this.hideFlagListBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(24, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "非表示設定";
            // 
            // repairNumeric
            // 
            this.repairNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repairNumeric.Location = new System.Drawing.Point(372, 141);
            this.repairNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.repairNumeric.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.repairNumeric.Name = "repairNumeric";
            this.repairNumeric.Size = new System.Drawing.Size(355, 19);
            this.repairNumeric.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(293, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "修繕コスト";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(27, 350);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 16);
            this.listBox1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(24, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "タグ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 19);
            this.button1.TabIndex = 26;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // enchantForm
            // 
            this.enchantForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enchantForm.Location = new System.Drawing.Point(294, 25);
            this.enchantForm.Name = "enchantForm";
            this.enchantForm.Size = new System.Drawing.Size(433, 106);
            this.enchantForm.TabIndex = 15;
            // 
            // addAbilityForm
            // 
            this.addAbilityForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAbilityForm.Location = new System.Drawing.Point(294, 171);
            this.addAbilityForm.Name = "addAbilityForm";
            this.addAbilityForm.Size = new System.Drawing.Size(433, 107);
            this.addAbilityForm.TabIndex = 13;
            // 
            // targetSelectForm
            // 
            this.targetSelectForm.Location = new System.Drawing.Point(27, 247);
            this.targetSelectForm.Name = "targetSelectForm";
            this.targetSelectForm.Size = new System.Drawing.Size(236, 68);
            this.targetSelectForm.TabIndex = 5;
            // 
            // GiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.repairNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hideFlagListBox);
            this.Controls.Add(this.itemNBTTextBox);
            this.Controls.Add(this.itemCountNumric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemNBTButton);
            this.Controls.Add(this.enchantForm);
            this.Controls.Add(this.ItemLoadButton);
            this.Controls.Add(this.addAbilityForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemSaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemCombBox);
            this.Controls.Add(this.targetSelectForm);
            this.Controls.Add(this.itemDescTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GiveForm";
            this.Size = new System.Drawing.Size(730, 386);
            ((System.ComponentModel.ISupportInitialize)(this.itemCountNumric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemDescTextBox;
        private TargetSelectForm targetSelectForm;
        private System.Windows.Forms.ComboBox itemCombBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ItemSaveButton;
        private System.Windows.Forms.Label label5;
        private AddAbilityForm addAbilityForm;
        private System.Windows.Forms.Button ItemLoadButton;
        private Enchant.EnchantForm enchantForm;
        private System.Windows.Forms.Button itemNBTButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown itemCountNumric;
        private System.Windows.Forms.TextBox itemNBTTextBox;
        private System.Windows.Forms.CheckedListBox hideFlagListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown repairNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

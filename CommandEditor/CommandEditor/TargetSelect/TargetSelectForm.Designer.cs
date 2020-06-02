namespace CommandEditor
{
    partial class TargetSelectForm
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
            this.targetSelectCombBox = new System.Windows.Forms.ComboBox();
            this.NBTSettingButton = new System.Windows.Forms.Button();
            this.targetNBTTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(-3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ターゲットセレクタ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(-3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ターゲットNBT";
            // 
            // targetSelectCombBox
            // 
            this.targetSelectCombBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetSelectCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetSelectCombBox.FormattingEnabled = true;
            this.targetSelectCombBox.Location = new System.Drawing.Point(139, 3);
            this.targetSelectCombBox.Name = "targetSelectCombBox";
            this.targetSelectCombBox.Size = new System.Drawing.Size(93, 20);
            this.targetSelectCombBox.TabIndex = 2;
            // 
            // NBTSettingButton
            // 
            this.NBTSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NBTSettingButton.Location = new System.Drawing.Point(210, 48);
            this.NBTSettingButton.Name = "NBTSettingButton";
            this.NBTSettingButton.Size = new System.Drawing.Size(22, 19);
            this.NBTSettingButton.TabIndex = 3;
            this.NBTSettingButton.Text = "...";
            this.NBTSettingButton.UseVisualStyleBackColor = true;
            this.NBTSettingButton.Click += new System.EventHandler(this.NBTSettingButton_Click);
            // 
            // targetNBTTextBox
            // 
            this.targetNBTTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.targetNBTTextBox.Location = new System.Drawing.Point(0, 48);
            this.targetNBTTextBox.Name = "targetNBTTextBox";
            this.targetNBTTextBox.Size = new System.Drawing.Size(204, 19);
            this.targetNBTTextBox.TabIndex = 4;
            // 
            // TargetSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.targetNBTTextBox);
            this.Controls.Add(this.NBTSettingButton);
            this.Controls.Add(this.targetSelectCombBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TargetSelectForm";
            this.Size = new System.Drawing.Size(232, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox targetSelectCombBox;
        private System.Windows.Forms.Button NBTSettingButton;
        private System.Windows.Forms.TextBox targetNBTTextBox;
    }
}

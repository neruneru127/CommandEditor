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
            this.TargetSelectCombBox = new System.Windows.Forms.ComboBox();
            this.NBTSettingButton = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(-3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ターゲットNBT";
            // 
            // TargetSelectCombBox
            // 
            this.TargetSelectCombBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetSelectCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetSelectCombBox.FormattingEnabled = true;
            this.TargetSelectCombBox.Location = new System.Drawing.Point(139, 3);
            this.TargetSelectCombBox.Name = "TargetSelectCombBox";
            this.TargetSelectCombBox.Size = new System.Drawing.Size(93, 20);
            this.TargetSelectCombBox.TabIndex = 2;
            // 
            // NBTSettingButton
            // 
            this.NBTSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NBTSettingButton.Location = new System.Drawing.Point(139, 26);
            this.NBTSettingButton.Name = "NBTSettingButton";
            this.NBTSettingButton.Size = new System.Drawing.Size(93, 23);
            this.NBTSettingButton.TabIndex = 3;
            this.NBTSettingButton.Text = "NBT指定";
            this.NBTSettingButton.UseVisualStyleBackColor = true;
            this.NBTSettingButton.Click += new System.EventHandler(this.NBTSettingButton_Click);
            // 
            // TargetSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NBTSettingButton);
            this.Controls.Add(this.TargetSelectCombBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TargetSelectForm";
            this.Size = new System.Drawing.Size(232, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TargetSelectCombBox;
        private System.Windows.Forms.Button NBTSettingButton;
    }
}
